using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Linq;
using NAudio;
using NAudio.Wave;
using libZPlay;

namespace SimFileMapperModel.Model
{
	public class Song
	{
		public double BeatsPerMinute;
		public double msTilStart;
		public float[] Fluxes {
			get { return fluxes; }
		}
		float[] fluxes;
		public Song(string fileDirectory)
		{
			#region cppAnalyzerOld

			/*var FloatSamples = Utilities.FloatArrayFromAudio(fileDirectory).ToArray();
			Process audioAnalyzer = new Process();
			string path = @"AubioAnalyzerCpp.exe";
			string currDirectory = Directory.GetCurrentDirectory();
			audioAnalyzer.StartInfo = new ProcessStartInfo(path, '"' + Directory.GetCurrentDirectory() + "\" " + FloatSamples.Length)
			{
				UseShellExecute = false,
				RedirectStandardInput = true,
				RedirectStandardOutput = true,
			};
			audioAnalyzer.Start();
			foreach (float sample in FloatSamples) {
				audioAnalyzer.StandardInput.WriteLine(sample);
			}
			
			string BPMString = audioAnalyzer.StandardOutput.ReadToEnd();
			BeatsPerMinute = (float)Convert.ToDouble(BPMString);
			audioAnalyzer.WaitForExit();
			if (audioAnalyzer.ExitCode != 0) throw new Exception("Audio Analyzer Failed");*/
			#endregion cppAnalyzerOld

			AudioAnalysis analyzer = new AudioAnalysis();
			analyzer.LoadAudioFromFile(fileDirectory);
			analyzer.DetectOnsets(out fluxes);
			//BPMDetector bpmdet = new BPMDetector(fileDirectory);
			//BeatsPerMinute = bpmdet.getBPM();
			//msTilStart = bpmdet.getOffset();
			Onsets = analyzer.GetOnsets().ToList();
			TimePerSample = analyzer.GetTimePerSample();
		}
		
		public string ToString(string Mapper, string Difficulty, string numberDiff)
		{
			StringBuilder s = new StringBuilder("#NOTES:\n\tdance-single:\n");
			s.AppendLine("\t"+Mapper+":");
			s.AppendLine("\t"+Difficulty+":");
			s.AppendLine("\t" + numberDiff + ":");
			s.AppendLine("\t0,0,0,0,0:");
			for (int i = 0; i < Measures.Count; i += 1) 
			{
				s.Append(Measures[i].ToString());
				s.AppendLine(i == Measures.Count - 1 ? ";" : ",");
			}
			return s.ToString();
		}
		List<float> Onsets = new List<float>();
		List<float> Beats = new List<float>();
		public int BeatsPerMeasure = 4;
		public List<Measure> Measures;
		public void GenerateSteps(List<float> beatTimesMilliseconds)
		{
			double MillisecondsPerMeasure = BeatsPerMeasure / BeatsPerMinute * 60000.0f;
			int MeasureNumber = -1;
			StepPattern pattern = StepPattern.StartsOnRight.First();
			int stepIndex = 0;
			foreach (var time in beatTimesMilliseconds)
			{
				int Measure = (int)((time - msTilStart) / MillisecondsPerMeasure);
				if (Measure >= beatTimesMilliseconds.Count)
				{
					Measures.Add(new Measure());
					MeasureNumber += 1;
				}
				int MeasureRelativeBeat = (int)(time - (MeasureNumber * MillisecondsPerMeasure) / 36.0);
				Measures[MeasureNumber].Steps[MeasureRelativeBeat] = pattern.Steps[stepIndex++];
				if (stepIndex >= pattern.Steps.Count)
				{
					stepIndex = 0;
					pattern = pattern.GetNextViablePattern();
				}
			}
		}
		public void GenerateSteps()
		{
			Measures = new List<Measure>();
			float DistanceBetweenBeats = Beats.Diff().ToList().AverageNoOutliers();
			var NotesInMeasure = Onsets.Select(x => ((int)Math.Round((x - msTilStart) / DistanceBetweenBeats * Measure.Resolution / BeatsPerMeasure)) % Measure.Resolution).ToList();
			var MeasureToPlace = Onsets.Select(x => (int)((x - msTilStart) / DistanceBetweenBeats / BeatsPerMeasure)).ToList();
			StepPattern pattern = StepPattern.StartsOnRight.GetRandom();
			int j = 0;
			bool[,] lookup = new bool[Measure.Resolution, MeasureToPlace.Max() + 1];
			for (int i = 0; i < Onsets.Count; i += 1)
			{
				if (lookup[NotesInMeasure[i], MeasureToPlace[i]]) continue;
				if (NotesInMeasure[i] < 0 || MeasureToPlace[i] < 0) continue;
				while (MeasureToPlace[i] >= Measures.Count)
				{
					Measures.Add(new Measure());
				}
				if (j >= pattern.Steps.Count)
				{
					pattern = pattern.GetNextViablePattern();
					j = 0;
				}
				Measures[MeasureToPlace[i]].Steps[NotesInMeasure[i]] = pattern.Steps[j++];
				lookup[NotesInMeasure[i], MeasureToPlace[i]] = true;
			}
		}
		public float TimePerSample
		{
			get;
			protected set;
		}
		public void CalculateBPM(string FileDirectory, out double BPM, out double OFFSET)
		{
			BPMDetector bpmdet = new BPMDetector(FileDirectory);
			BPM = bpmdet.getBPM();
			OFFSET = bpmdet.getOffset();
		}
		public void GenerateStepsV2(float BPM, float Offset, int difficulty, bool RoundBeats)
		{
			BeatsPerMinute = BPM;
			msTilStart = Offset * -1000;
			List<float> Timings = new List<float>();
			float Sensitivity = (100 - difficulty) / 100.0f;
			float Max = Onsets.Max();
			for (int i = 0; i < Onsets.Count; i += 1)
			{
				if (Onsets[i] > Max * Sensitivity)
				{
					Timings.Add(TimePerSample * i * 1000);
				}
			}
			float MinutesPerBeat = 1 / BPM;
			float MillisecondsPerMinute = 60000;
			Measures = new List<Measure>();
			float DistanceBetweenBeats = MinutesPerBeat * MillisecondsPerMinute;
			var NotesInMeasure = Timings.Select(z => (int)(((Math.Round((z - msTilStart) / DistanceBetweenBeats * Measure.Resolution) / (float)BeatsPerMeasure)) + 1) % Measure.Resolution).ToList();
			//var MeasureToPlace = Timings.Select(z => (int)((z - msTilStart) / DistanceBetweenBeats / BeatsPerMeasure)).ToList();
			var MeasureToPlace = Timings.Select(z => (int)(((Math.Round((z - msTilStart) / DistanceBetweenBeats * Measure.Resolution) / (float)BeatsPerMeasure)) + 1) / Measure.Resolution).ToList();
			//StepPattern pattern = StepPattern.StartsOnRight.GetRandom();
			//int j = 0;
			bool[,] lookup = new bool[Measure.Resolution, MeasureToPlace.Max() + 1];
			Rounder rounder = new Rounder(0, 3, 4, 6, 8, 9, 12, 15, 16, 18, 20, 21, 24, 27, 28, 30, 32, 33, 36, 39, 40, 42, 44, 45);
			//for (int i = 0; i < Timings.Count; i += 1)
			//{
			//	int r = NotesInMeasure[i];
			//	if (RoundBeats)
			//	{
			//		r = rounder.Round(NotesInMeasure[i]);
			//	}
			//	if (r < 0 || MeasureToPlace[i] < 0) continue;
			//	if (lookup[r, MeasureToPlace[i]]) continue;
			//	while (MeasureToPlace[i] >= Measures.Count)
			//	{
			//		Measures.Add(new Measure());
			//	}
			//	if (j >= pattern.Steps.Count)
			//	{
			//		pattern = pattern.GetNextViablePattern();
			//		j = 0;
			//	}
			//	Measures[MeasureToPlace[i]].Steps[r] = pattern.Steps[j++];
			//	lookup[r, MeasureToPlace[i]] = true;
			//}
			int x = 0;
			foreach (var step in StepPattern.StepStream(true))
			{
			restart:
				if (x >= Timings.Count) break;
				int r = NotesInMeasure[x];
				if (RoundBeats)
				{
					r = rounder.Round(NotesInMeasure[x]);
				}
				if (r < 0 || MeasureToPlace[x] < 0 || lookup[r, MeasureToPlace[x]]) {
					x += 1;
					goto restart;
				}
				while (MeasureToPlace[x] >= Measures.Count)
				{
					Measures.Add(new Measure());
				}
				Measures[MeasureToPlace[x]].Steps[r] = step;
				lookup[r, MeasureToPlace[x]] = true;
			}
		}
	}
}
