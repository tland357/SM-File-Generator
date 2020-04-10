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
using System.Drawing;
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
			this.Traverse(c =>
			{
				if (c is ButtonBase)
				{
					ButtonBase b = c as ButtonBase;
					b.FlatStyle = FlatStyle.Flat;
					b.FlatAppearance.BorderColor = Color.Black;
					b.Cursor = Cursors.Hand;
				}
				else if (c is TextBox)
				{
					TextBox t = c as TextBox;
					t.BorderStyle = BorderStyle.FixedSingle;
					t.Cursor = Cursors.IBeam;
				}
				//c.BackColor = Color.FromArgb(40, 40, 40);
				//c.ForeColor = Color.White;
			});
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
		private void NegNumberValidation(object sender, EventArgs e)
		{
			var widget = sender as Control;
			widget.Text = string.Join("", widget.Text.Where(x => char.IsDigit(x) || (x == '-' && widget.Text.LastIndexOf('-') == 0)));
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
		public Song song;
		private void mp3Selector_FileFound(object sender, FileSelector.FileFoundEventArgs e)
		{
			string fileName = e.FileLocation;
			try
			{
				//if (!fileName.EndsWith(".wav")) throw new Exception("Right now this program only supports wav files");
				string text = File.ReadAllText(fileName);
				song = new Song(fileName);
				BannerSelector.Enabled = BackGroundImageSelector.Enabled = GBXSongSettings.Enabled = true;
				BTNGenerateData.Enabled = true;
				//TXTBpm.Text = song.BeatsPerMinute.ToString();
				//TXTOffset.Text = song.msTilStart.ToString();
				TXTTitle.Text = e.FileLocation.Split('\\').Last().Replace(".mp3", "").Replace(".sm","");
				if ((sender as FileSelector).TextBox1.Text == "")
				{
					BannerSelector.Enabled = BackGroundImageSelector.Enabled = GBXSongSettings.Enabled = false;
				}
				DialogResult result = MessageBox.Show("Would you like to attempt auto-bpm detection? (Warning! this is experimental and prone to error)", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					double bpm, offset;
					song.CalculateBPM(e.FileLocation, out bpm, out offset);
					TXTBpm.Text = bpm.ToString();
					TXTOffset.Text = offset.ToString();
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
				if (string.IsNullOrWhiteSpace(TXTBpm.Text))
				{
					throw new Exception("Must specify a value for BPM!");
				}
				if (string.IsNullOrWhiteSpace(TXTOffset.Text))
				{
					TXTOffset.Text = "0";
				}
				float bpm = (float)Convert.ToDouble(TXTBpm.Text);
				float offset = (float)Convert.ToDouble(TXTOffset.Text);
				if (bpm <= 0.0f) throw new Exception("BPM must exceed 0!");
				song.GenerateStepsV2(bpm,offset, trackBar2.Value, CHKRoundBeatTimings.Checked);
				StringBuilder builder = new StringBuilder("-----------" + Environment.NewLine);
				int i = 1;
				foreach (var measure in song.Measures)
				{
					int j = 0;
					foreach (var step in measure.ToArrow().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
					{
						builder.Append(i.ToString().PadLeft(3, '0') + ":" + (++j).ToString().PadLeft(2, '0') + ":" + step + Environment.NewLine);
					}
					builder.Append("-----------" + Environment.NewLine);
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
					smFile.WriteLine("#BANNER:" + BannerSelector.FileName.Split('\\').Last() + ";");
					smFile.WriteLine("#BACKGROUND:" + BackGroundImageSelector.FileName.Split('\\').Last() + ";");
					smFile.WriteLine("#CDTITLE:;\n#SAMPLESTART:0.000;\n#SAMPLELENGTH:0.000;\n#SELECTABLE:YES;\n#OFFSET:" + (Convert.ToDouble(TXTOffset.Text)));
					smFile.WriteLine("#BPMS:0.000=" + TXTBpm.Text + ";");
					smFile.WriteLine("#STOPS:;\n#BGCHANGES:;\n#FGCHANGES:;");
					smFile.WriteLine(song.ToString(TXTMapper.Text, TXTDifficultyName.Text, TXTDifficultyNumber.Text));
				}
				if (File.Exists("ArrowVortex\\ArrowVortex.exe"))
				{
					result = MessageBox.Show("Would you like to open in ArrowVortex?", "Arrow Vortex", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						Process arrowVortex = new Process()
						{
							StartInfo = new ProcessStartInfo("ArrowVortex\\ArrowVortex.exe", '"' + dialog.FileName + '"')
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
					appender.WriteLine(song.ToString(TXTMapper.Text, TXTDifficultyName.Text, TXTDifficultyNumber.Text));
				}
				if (File.Exists("ArrowVortex\\ArrowVortex.exe"))
				{
					result = MessageBox.Show("Would you like to open in ArrowVortex?", "Arrow Vortex", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						Process arrowVortex = new Process()
						{
							StartInfo = new ProcessStartInfo("ArrowVortex\\ArrowVortex.exe", '"' + dialog.FileName + '"')
						};
						arrowVortex.Start();
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BpmCalculator Calc = new BpmCalculator(this);
			Calc.ShowDialog();
		}

		private void BTNArrowVortex_Click(object sender, EventArgs e)
		{
			if (File.Exists("ArrowVortex\\ArrowVortex.exe"))
			{
				Process arrowVortex = new Process()
				{
					StartInfo = new ProcessStartInfo("ArrowVortex\\ArrowVortex.exe", '"' + mp3Selector.FileName + '"')
				};
				arrowVortex.Start();
			} else
			{
				MessageBox.Show("ArrowVortex cannot be found!");
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
