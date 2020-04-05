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

namespace SimFileMapperModel.Model
{
	public class Difficulty
	{
		public bool AllowHands, AllowRolls, AllowJackHammers, AllowMines;
		public double JumpPercentage;
		public DIFFICULTY Level;
		public Difficulty(DIFFICULTY difficulty, Song owner, bool hands = false, bool rolls = false, bool jacks = false, bool mines = false, double percentjumps = 12.0)
		{
			AllowHands = hands;
			AllowJackHammers = jacks;
			AllowMines = mines;
			AllowRolls = rolls;
			JumpPercentage = percentjumps;
			Level = difficulty;
		}
		
	}
	public class Song
	{
		public float BeatsPerMinute;
		public float msTilStart;
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
			analyzer.DetectOnsets();
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
				var Measure = Measures[i];
				foreach (var step in Measure.Steps)
				{
					s.AppendLine(step?.ToString() ?? "0000");
				}
				s.AppendLine(i == Measures.Count - 1 ? ";" : ",");
			}
			return s.ToString();
		}
		List<float> Onsets = new List<float>();
		List<float> Beats = new List<float>();
		Difficulty difficulty;
		public int BeatsPerMeasure = 4;
		public List<Measure> Measures;
		public void GenerateSteps(List<float> beatTimesMilliseconds)
		{
			float MillisecondsPerMeasure = BeatsPerMeasure / BeatsPerMinute * 60000.0f;
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
		float TimePerSample;
		public void GenerateStepsV2(float BPM, float Offset, int difficulty)
		{
			BeatsPerMinute = BPM;
			msTilStart = Offset;
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
			var NotesInMeasure = Timings.Select(x => ((int)Math.Round((x - msTilStart) / DistanceBetweenBeats * Measure.Resolution) / BeatsPerMeasure) % Measure.Resolution).ToList();
			var MeasureToPlace = Timings.Select(x => (int)((x - msTilStart) / DistanceBetweenBeats / BeatsPerMeasure)).ToList();
			StepPattern pattern = StepPattern.StartsOnRight.GetRandom();
			int j = 0;
			bool[,] lookup = new bool[Measure.Resolution, MeasureToPlace.Max() + 1];
			for (int i = 0; i < Timings.Count; i += 1)
			{
				if (NotesInMeasure[i] < 0 || MeasureToPlace[i] < 0) continue;
				if (lookup[NotesInMeasure[i], MeasureToPlace[i]]) continue;
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
	}
}
