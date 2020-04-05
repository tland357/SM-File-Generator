namespace SimFileMapperView
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.BTNAddToSimFile = new System.Windows.Forms.Button();
			this.GBXSongSettings = new System.Windows.Forms.GroupBox();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.TXTMapper = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TXTArtist = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TXTTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TXTOffset = new System.Windows.Forms.TextBox();
			this.JumpPercentLabel = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TXTBpm = new System.Windows.Forms.TextBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.BTNExportSimFile = new System.Windows.Forms.Button();
			this.BTNGenerateData = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BannerSelector = new FileSelectorLibrary.FileSelector();
			this.BackGroundImageSelector = new FileSelectorLibrary.FileSelector();
			this.mp3Selector = new FileSelectorLibrary.FileSelector();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.TXTDifficultyName = new System.Windows.Forms.TextBox();
			this.TXTDifficultyNumber = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.GBXSongSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BTNAddToSimFile);
			this.panel1.Controls.Add(this.GBXSongSettings);
			this.panel1.Controls.Add(this.BTNExportSimFile);
			this.panel1.Controls.Add(this.BTNGenerateData);
			this.panel1.Controls.Add(this.BannerSelector);
			this.panel1.Controls.Add(this.BackGroundImageSelector);
			this.panel1.Controls.Add(this.mp3Selector);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(633, 492);
			this.panel1.TabIndex = 1;
			// 
			// BTNAddToSimFile
			// 
			this.BTNAddToSimFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTNAddToSimFile.Enabled = false;
			this.BTNAddToSimFile.Location = new System.Drawing.Point(433, 104);
			this.BTNAddToSimFile.Name = "BTNAddToSimFile";
			this.BTNAddToSimFile.Size = new System.Drawing.Size(189, 39);
			this.BTNAddToSimFile.TabIndex = 7;
			this.BTNAddToSimFile.Text = "Add Difficulty To Existing";
			this.BTNAddToSimFile.UseVisualStyleBackColor = true;
			this.BTNAddToSimFile.Click += new System.EventHandler(this.BTNAddToSimFile_Click);
			// 
			// GBXSongSettings
			// 
			this.GBXSongSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GBXSongSettings.Controls.Add(this.TXTDifficultyNumber);
			this.GBXSongSettings.Controls.Add(this.TXTDifficultyName);
			this.GBXSongSettings.Controls.Add(this.label10);
			this.GBXSongSettings.Controls.Add(this.label9);
			this.GBXSongSettings.Controls.Add(this.trackBar2);
			this.GBXSongSettings.Controls.Add(this.TXTMapper);
			this.GBXSongSettings.Controls.Add(this.label8);
			this.GBXSongSettings.Controls.Add(this.TXTArtist);
			this.GBXSongSettings.Controls.Add(this.label7);
			this.GBXSongSettings.Controls.Add(this.TXTTitle);
			this.GBXSongSettings.Controls.Add(this.label6);
			this.GBXSongSettings.Controls.Add(this.label5);
			this.GBXSongSettings.Controls.Add(this.comboBox1);
			this.GBXSongSettings.Controls.Add(this.label3);
			this.GBXSongSettings.Controls.Add(this.TXTOffset);
			this.GBXSongSettings.Controls.Add(this.JumpPercentLabel);
			this.GBXSongSettings.Controls.Add(this.trackBar1);
			this.GBXSongSettings.Controls.Add(this.checkBox9);
			this.GBXSongSettings.Controls.Add(this.checkBox8);
			this.GBXSongSettings.Controls.Add(this.checkBox6);
			this.GBXSongSettings.Controls.Add(this.label4);
			this.GBXSongSettings.Controls.Add(this.textBox2);
			this.GBXSongSettings.Controls.Add(this.label2);
			this.GBXSongSettings.Controls.Add(this.label1);
			this.GBXSongSettings.Controls.Add(this.TXTBpm);
			this.GBXSongSettings.Controls.Add(this.checkBox7);
			this.GBXSongSettings.Enabled = false;
			this.GBXSongSettings.Location = new System.Drawing.Point(9, 161);
			this.GBXSongSettings.Name = "GBXSongSettings";
			this.GBXSongSettings.Size = new System.Drawing.Size(613, 322);
			this.GBXSongSettings.TabIndex = 6;
			this.GBXSongSettings.TabStop = false;
			this.GBXSongSettings.Text = "Song Settings";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(226, 147);
			this.trackBar2.Maximum = 100;
			this.trackBar2.Minimum = 50;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(171, 56);
			this.trackBar2.TabIndex = 24;
			this.trackBar2.TickFrequency = 5;
			this.trackBar2.Value = 75;
			// 
			// TXTMapper
			// 
			this.TXTMapper.Location = new System.Drawing.Point(67, 83);
			this.TXTMapper.MaxLength = 1200;
			this.TXTMapper.Name = "TXTMapper";
			this.TXTMapper.Size = new System.Drawing.Size(145, 22);
			this.TXTMapper.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 82);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 22;
			this.label8.Text = "Mapper:";
			// 
			// TXTArtist
			// 
			this.TXTArtist.Location = new System.Drawing.Point(56, 52);
			this.TXTArtist.MaxLength = 1200;
			this.TXTArtist.Name = "TXTArtist";
			this.TXTArtist.Size = new System.Drawing.Size(156, 22);
			this.TXTArtist.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 17);
			this.label7.TabIndex = 20;
			this.label7.Text = "Artist:";
			// 
			// TXTTitle
			// 
			this.TXTTitle.Location = new System.Drawing.Point(88, 24);
			this.TXTTitle.MaxLength = 1200;
			this.TXTTitle.Name = "TXTTitle";
			this.TXTTitle.Size = new System.Drawing.Size(124, 22);
			this.TXTTitle.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Song Title:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(416, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Measure Resolution";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "48",
            "36",
            "24",
            "16",
            "12",
            "8",
            "4"});
			this.comboBox1.Location = new System.Drawing.Point(556, 20);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(50, 24);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.Text = "48";
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(229, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Offset (ms):";
			// 
			// TXTOffset
			// 
			this.TXTOffset.Location = new System.Drawing.Point(317, 53);
			this.TXTOffset.MaxLength = 10;
			this.TXTOffset.Name = "TXTOffset";
			this.TXTOffset.Size = new System.Drawing.Size(83, 22);
			this.TXTOffset.TabIndex = 14;
			this.TXTOffset.TextChanged += new System.EventHandler(this.FloatVailidation);
			// 
			// JumpPercentLabel
			// 
			this.JumpPercentLabel.AutoSize = true;
			this.JumpPercentLabel.Location = new System.Drawing.Point(229, 213);
			this.JumpPercentLabel.Name = "JumpPercentLabel";
			this.JumpPercentLabel.Size = new System.Drawing.Size(171, 17);
			this.JumpPercentLabel.TabIndex = 13;
			this.JumpPercentLabel.Text = "Suggested Jump Percent:";
			// 
			// trackBar1
			// 
			this.trackBar1.Enabled = false;
			this.trackBar1.Location = new System.Drawing.Point(226, 237);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(171, 56);
			this.trackBar1.TabIndex = 12;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 15;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Enabled = false;
			this.checkBox9.Location = new System.Drawing.Point(419, 134);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(103, 21);
			this.checkBox9.TabIndex = 11;
			this.checkBox9.Text = "Allow Mines";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Enabled = false;
			this.checkBox8.Location = new System.Drawing.Point(419, 107);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(97, 21);
			this.checkBox8.TabIndex = 10;
			this.checkBox8.Text = "Allow Rolls";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Enabled = false;
			this.checkBox6.Location = new System.Drawing.Point(419, 53);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(107, 21);
			this.checkBox6.TabIndex = 8;
			this.checkBox6.Text = "Allow Hands";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(229, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Audio Sensitivity: ";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(368, 83);
			this.textBox2.MaxLength = 1;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(32, 22);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "4";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.TextChanged += new System.EventHandler(this.NumberValidation);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(229, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Beats Per Measure:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(229, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "BPM:";
			// 
			// TXTBpm
			// 
			this.TXTBpm.Location = new System.Drawing.Point(276, 24);
			this.TXTBpm.MaxLength = 10;
			this.TXTBpm.Name = "TXTBpm";
			this.TXTBpm.Size = new System.Drawing.Size(124, 22);
			this.TXTBpm.TabIndex = 0;
			this.TXTBpm.TextChanged += new System.EventHandler(this.FloatVailidation);
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Enabled = false;
			this.checkBox7.Location = new System.Drawing.Point(419, 80);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(155, 21);
			this.checkBox7.TabIndex = 9;
			this.checkBox7.Text = "Allow JackHammers";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// BTNExportSimFile
			// 
			this.BTNExportSimFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTNExportSimFile.Enabled = false;
			this.BTNExportSimFile.Location = new System.Drawing.Point(433, 56);
			this.BTNExportSimFile.Name = "BTNExportSimFile";
			this.BTNExportSimFile.Size = new System.Drawing.Size(189, 39);
			this.BTNExportSimFile.TabIndex = 4;
			this.BTNExportSimFile.Text = "Export New Sim File";
			this.BTNExportSimFile.UseVisualStyleBackColor = true;
			this.BTNExportSimFile.Click += new System.EventHandler(this.BTNExportSimFile_Click);
			// 
			// BTNGenerateData
			// 
			this.BTNGenerateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTNGenerateData.Enabled = false;
			this.BTNGenerateData.Location = new System.Drawing.Point(433, 9);
			this.BTNGenerateData.Name = "BTNGenerateData";
			this.BTNGenerateData.Size = new System.Drawing.Size(189, 39);
			this.BTNGenerateData.TabIndex = 3;
			this.BTNGenerateData.Text = "Generate Data";
			this.BTNGenerateData.UseVisualStyleBackColor = true;
			this.BTNGenerateData.Click += new System.EventHandler(this.BTNGenerateData_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.48969F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.51031F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 498);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(642, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(276, 492);
			this.textBox1.TabIndex = 2;
			// 
			// BannerSelector
			// 
			this.BannerSelector.AllowedFileTypes = "jpg,jpeg,jpe,jfif,png,bmp";
			this.BannerSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BannerSelector.ButtonText = "Select Cover Image";
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.BannerSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.BannerSelector.Enabled = false;
			this.BannerSelector.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe;" +
    " *.jfif; *.png; *.bmp\";";
			this.BannerSelector.Location = new System.Drawing.Point(9, 104);
			this.BannerSelector.LockFileFoundEvent = false;
			this.BannerSelector.Name = "BannerSelector";
			this.BannerSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BannerSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BannerSelector.Size = new System.Drawing.Size(413, 39);
			this.BannerSelector.TabIndex = 2;
			// 
			// BackGroundImageSelector
			// 
			this.BackGroundImageSelector.AllowedFileTypes = "jpg,jpeg,jpe,jfif,png,bmp";
			this.BackGroundImageSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BackGroundImageSelector.ButtonText = "Select Background Image";
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.BackGroundImageSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.BackGroundImageSelector.Enabled = false;
			this.BackGroundImageSelector.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe;" +
    " *.jfif; *.png; *.bmp\";";
			this.BackGroundImageSelector.Location = new System.Drawing.Point(9, 56);
			this.BackGroundImageSelector.LockFileFoundEvent = false;
			this.BackGroundImageSelector.Name = "BackGroundImageSelector";
			this.BackGroundImageSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BackGroundImageSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BackGroundImageSelector.Size = new System.Drawing.Size(413, 39);
			this.BackGroundImageSelector.TabIndex = 1;
			// 
			// mp3Selector
			// 
			this.mp3Selector.AllowedFileTypes = "mp3,wav";
			this.mp3Selector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mp3Selector.ButtonText = "Select Song";
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.mp3Selector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.mp3Selector.Filter = "Music Files (*.mp3),(*.wav)|*.mp3;*.wav";
			this.mp3Selector.Location = new System.Drawing.Point(9, 9);
			this.mp3Selector.LockFileFoundEvent = false;
			this.mp3Selector.Name = "mp3Selector";
			this.mp3Selector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.mp3Selector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.mp3Selector.Size = new System.Drawing.Size(413, 39);
			this.mp3Selector.TabIndex = 0;
			this.mp3Selector.FileFound += new FileSelectorLibrary.FileSelector.FileFoundEventHandler(this.mp3Selector_FileFound);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 17);
			this.label9.TabIndex = 25;
			this.label9.Text = "Difficulty Name:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 140);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(119, 17);
			this.label10.TabIndex = 26;
			this.label10.Text = "Difficulty Number:";
			// 
			// TXTDifficultyName
			// 
			this.TXTDifficultyName.Location = new System.Drawing.Point(109, 112);
			this.TXTDifficultyName.MaxLength = 1200;
			this.TXTDifficultyName.Name = "TXTDifficultyName";
			this.TXTDifficultyName.Size = new System.Drawing.Size(103, 22);
			this.TXTDifficultyName.TabIndex = 27;
			// 
			// TXTDifficultyNumber
			// 
			this.TXTDifficultyNumber.Location = new System.Drawing.Point(131, 140);
			this.TXTDifficultyNumber.MaxLength = 2;
			this.TXTDifficultyNumber.Name = "TXTDifficultyNumber";
			this.TXTDifficultyNumber.Size = new System.Drawing.Size(81, 22);
			this.TXTDifficultyNumber.TabIndex = 28;
			this.TXTDifficultyNumber.TextChanged += new System.EventHandler(this.NumberValidation);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 498);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.GBXSongSettings.ResumeLayout(false);
			this.GBXSongSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		protected FileSelectorLibrary.FileSelector mp3Selector;
		protected FileSelectorLibrary.FileSelector BackGroundImageSelector;
		protected FileSelectorLibrary.FileSelector BannerSelector;
		private System.Windows.Forms.Button BTNExportSimFile;
		private System.Windows.Forms.Button BTNGenerateData;
		private System.Windows.Forms.GroupBox GBXSongSettings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TXTBpm;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label JumpPercentLabel;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.Button BTNAddToSimFile;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXTOffset;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox TXTMapper;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TXTArtist;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TXTTitle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TextBox TXTDifficultyNumber;
		private System.Windows.Forms.TextBox TXTDifficultyName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}

