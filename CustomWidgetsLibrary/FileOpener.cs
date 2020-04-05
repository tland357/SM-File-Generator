using System;
using System.IO;
using System.Windows.Forms;

namespace FileSelectorLibrary
{
	public partial class FileOpener : Button
	{
		public FileOpener()
		{
			InitializeComponent();
			openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
		}
		public FileOpener(TextBox display)
		{
			InitializeComponent();
			openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
			textReference = display;
			if (textReference != null)
			{
				textReference.ReadOnly = true;
				textReference.Enabled = false;
			}
		}

		TextBox textReference;

		public string Filter
		{
			get
			{
				return openFileDialog1.Filter;
			}
			set
			{
				openFileDialog1.Filter = value;
			}
		}

		public string FileName 
		{
			get
			{
				return openFileDialog1.FileName;
			}	
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK && textReference != null)
			{
				textReference.Text = "";
				textReference.Text = openFileDialog1.FileName;
			}
		}
	}
}
