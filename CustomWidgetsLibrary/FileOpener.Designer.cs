namespace FileSelectorLibrary
{
	partial class FileOpener
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// FileOpener
			// 
			this.Click += new System.EventHandler(this.button1_Click);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
