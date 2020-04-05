using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SimFileMapperModel;
using FileSelectorLibrary;
using SimFileMapperModel.Model;
using System.Text;
using System.Diagnostics;
using NAudio.Wave;
using System.Collections.Generic;

namespace SimFileMapperView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			StepPattern.CreateStepPatterns();
			TXTBpm.TextChanged += (sender, e) => {
				if (song != null)
				{
					try
					{
						song.BeatsPerMinute = (float)Convert.ToDouble((sender as TextBox).Text);
					} catch(FormatException) { }
				}
			};
			TXTOffset.TextChanged += (sender, e) =>
			{
				if (song != null)
				{
					try
					{
						song.msTilStart = (float)Convert.ToDouble((sender as TextBox).Text);
					} catch (FormatException)
					{

					}
				}
			};
		}

		public Form1(string arg) : this()
		{
			mp3Selector.TextBox1.Text = arg;
		}

		private void NumberValidation(object sender, EventArgs e)
		{
			var widget = sender as Control;
			widget.Text = string.Join("", widget.Text.Where(x => char.IsDigit(x)));
		}
		private void FloatVailidation(object sender, EventArgs e)
		{
			var widget = sender as Control;
			widget.Text = string.Join("", widget.Text.Where(x => char.IsDigit(x) || x == '.' || x == '-'));
			if (widget.Text.Count(x => x == '.') > 1)
			{
				StringBuilder s = new StringBuilder(widget.Text);
				bool periodFound = false;
				for (int i = 0; i < s.Length; i += 1)
				{
					if (!periodFound && s[i] == '.')
					{
						periodFound = true;
					} else if (s[i] == '.')
					{
						s.Remove(i, 1);
						i -= 1;
					}
				}
			}
		}
		Song song;
		private void mp3Selector_FileFound(object sender, FileSelector.FileFoundEventArgs e)
		{
			string fileName = e.FileLocation;
			try
			{
				//if (!fileName.EndsWith(".wav")) throw new Exception("Right now this program only supports wav files");
				mp3Selector.LockFileFoundEvent = true;
				mp3Selector.TextBox1.Text = fileName;
				mp3Selector.LockFileFoundEvent = false;
				string text = File.ReadAllText(fileName);
				song = new Song(fileName);
				BannerSelector.Enabled = BackGroundImageSelector.Enabled = GBXSongSettings.Enabled = true;
				BTNGenerateData.Enabled = true;
				TXTBpm.Text = song.BeatsPerMinute.ToString();
				TXTOffset.Text = song.msTilStart.ToString();
				if ((sender as FileSelector).TextBox1.Text == "")
				{
					BannerSelector.Enabled = BackGroundImageSelector.Enabled = GBXSongSettings.Enabled = false;
				}
			} catch (Exception ex)
			{
				MessageBox.Show("Error - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				(sender as FileSelector).TextBox1.Text = "";
				BannerSelector.Enabled = BackGroundImageSelector.Enabled = GBXSongSettings.Enabled = false;

			}
		}

		private void BTNBPMFind_Click(object sender, EventArgs e)
		{
			
		}

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void comboBox2_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = !e.KeyCode.IsAnyOf(Keys.Up, Keys.Down);
		}

		private void BTNGenerateData_Click(object sender, EventArgs e)
		{
			try
			{
				song.GenerateStepsV2((float)Convert.ToDouble(TXTBpm.Text),(float)Convert.ToDouble(TXTOffset.Text), trackBar2.Value);
				StringBuilder builder = new StringBuilder("01:00:------" + Environment.NewLine);
				int i = 1;
				foreach (var measure in song.Measures)
				{
					int j = 0;
					foreach (var step in measure.Steps)
					{
						if (step == null)
						{
							builder.Append(i.ToString().PadLeft(3,'0') + ":" + (++j).ToString().PadLeft(2, '0') + ":|    |" + Environment.NewLine);
						}
						else
						{
							builder.Append(i.ToString().PadLeft(3, '0') + ":" + (++j).ToString().PadLeft(2, '0') + ":|" + step.ToArrows() + '|' + Environment.NewLine);
						}
					}
					builder.Append((++i) + ":0:------" + Environment.NewLine);
				}
				textBox1.Text = builder.ToString();
				BTNExportSimFile.Enabled = BTNAddToSimFile.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			Measure.Resolution = Convert.ToInt32(comboBox1.SelectedItem.ToString());
		}

		private void BTNExportSimFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog()
			{
				InitialDirectory = Path.GetDirectoryName(mp3Selector.FileName),
				Filter = "Step Mania File (*.sm) | *.sm",
			};
			DialogResult result = dialog.ShowDialog();
			if (result != DialogResult.Cancel)
			{
				using (StreamWriter smFile = new StreamWriter(dialog.FileName))
				{
					smFile.WriteLine("#TITLE:" + TXTTitle.Text + ";");
					smFile.WriteLine("#SUBTITLE:;");
					smFile.WriteLine("#ARTIST:" + TXTArtist.Text + ";");
					smFile.WriteLine("#TITLETRANSLIT:;\n#SUBTITLETRANSLIT:;\n#ARTISTTRANSLIT:;\n#GENRE:;\n#CREDIT:;");
					smFile.WriteLine("#MUSIC:" + mp3Selector.FileName.Split('\\').Last() + ";");
					smFile.WriteLine("#BANNER:" + BannerSelector.FileName + ";");
					smFile.WriteLine("#BACKGROUND:" + BackGroundImageSelector.FileName + ";");
					smFile.WriteLine("#CDTITLE:;\n#SAMPLESTART:0.000;\n#SAMPLELENGTH:0.000;\n#SELECTABLE:YES;\n#OFFSET:" + (Convert.ToDouble(TXTOffset.Text) / -1000.0));
					smFile.WriteLine("#BPMS:0.000=" + TXTBpm.Text + ";");
					smFile.WriteLine("#STOPS:;\n#BGCHANGES:;\n#FGCHANGES:;");
					smFile.WriteLine(song.ToString(TXTMapper.Text, TXTDifficultyName.Text, TXTDifficultyNumber.Text));
				}
				if (File.Exists("ArrowVortex.exe"))
				{
					result = MessageBox.Show("Would you like to open in ArrowVortex?", "Arrow Vortex", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						Process arrowVortex = new Process()
						{
							StartInfo = new ProcessStartInfo("ArrowVortex.exe", '"' + dialog.FileName + '"')
						};
						arrowVortex.Start();
					}
				}
			}
			
		}

		private void BTNAddToSimFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog()
			{
				Filter = "Step Mania File (*.sm) | *.sm",
			};
			DialogResult result = dialog.ShowDialog();
			if (result != DialogResult.Cancel)
			{
				using (StreamWriter appender = new StreamWriter(dialog.FileName, append: true))
				{
					appender.WriteLine(song.ToString());
				}
			}
		}
	}
}
