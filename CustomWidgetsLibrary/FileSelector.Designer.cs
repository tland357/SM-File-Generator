using System.Windows.Forms;

namespace FileSelectorLibrary
{
	partial class FileSelector
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
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.FileOpener1 = new FileSelectorLibrary.FileOpener(TextBox1);
			this.SuspendLayout();
			// 
			// TextBox1
			// 
			this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.Location = new System.Drawing.Point(3, 3);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(94, 94);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// FileOpener1
			// 
			this.FileOpener1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileOpener1.Filter = "";
			this.FileOpener1.Location = new System.Drawing.Point(103, 3);
			this.FileOpener1.Name = "FileOpener1";
			this.FileOpener1.Size = new System.Drawing.Size(94, 94);
			this.FileOpener1.TabIndex = 0;
			this.FileOpener1.Text = "button1";
			this.FileOpener1.UseVisualStyleBackColor = true;
			// 
			// FileSelector
			// 
			this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Controls.Add(this.TextBox1, 0, 0);
			this.Controls.Add(this.FileOpener1, 1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public FileOpener FileOpener1;
		public TextBox TextBox1;
	}
}
