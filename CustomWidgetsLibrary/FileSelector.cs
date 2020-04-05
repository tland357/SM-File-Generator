using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileSelectorLibrary
{
	[DefaultEvent("FileFound")]
	public partial class FileSelector : TableLayoutPanel
	{
		public class FileType
		{
			[Browsable(true)]
			[DisplayName("FileEnding")]
			public string FileEnding { get; set; }
			public FileType()
			{
				FileEnding = "";
			}
			public FileType(string ending)
			{
				FileEnding = ending;
			}
			public override string ToString()
			{
				return FileEnding;
			}
		}
		public class FileFoundEventArgs : EventArgs
		{
			public FileFoundEventArgs(string fileLocation)
			{
				FileLocation = fileLocation;
			}
			public readonly string FileLocation;
		}
		public delegate void FileFoundEventHandler(object sender, FileFoundEventArgs e);
		public FileSelector()
		{
			InitializeComponent();
		}
		[Browsable(true)]
		public string Filter
		{
			get
			{
				return FileOpener1.Filter;
			}
			set
			{
				FileOpener1.Filter = value;
			}
		}

		[Browsable(true)]
		[Description("A comma separated list of file endings. If none are included then all files are allowed")]
		public string AllowedFileTypes { get; set; }
		[Browsable(true)]
		public string FileName
		{
			get
			{
				return FileOpener1.FileName;
			}
		}
		FileFoundEventHandler fileFound;
		public event FileFoundEventHandler FileFound {
			add
			{
				fileFound += value;
			}
			remove
			{
				fileFound -= value;
			}
		}
		public string ButtonText
		{
			get
			{
				return FileOpener1.Text;
			}
			set
			{
				FileOpener1.Text = value;
			}
		}
		[Browsable(true)]
		public bool LockFileFoundEvent { get; set; }
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			string file = TextBox1.Text;
			if (File.Exists(file) && !LockFileFoundEvent)
			{
				if (string.IsNullOrWhiteSpace(AllowedFileTypes) ||
					(AllowedFileTypes.Contains(",") && AllowedFileTypes.Split(',').Any(x => file.ToLower().EndsWith(x.ToLower()))) ||
					file.EndsWith(AllowedFileTypes))
				{
					fileFound(this, new FileFoundEventArgs(file));
				} else
				{
					TextBox1.Text = "";
				}
			}
		}
	}
}
