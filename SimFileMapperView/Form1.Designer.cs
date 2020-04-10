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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.BTNAddToSimFile = new System.Windows.Forms.Button();
			this.GBXSongSettings = new System.Windows.Forms.GroupBox();
			this.BTNBPMCalc = new System.Windows.Forms.Button();
			this.TXTDifficultyNumber = new System.Windows.Forms.TextBox();
			this.TXTDifficultyName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
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
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TXTBpm = new System.Windows.Forms.TextBox();
			this.BTNExportSimFile = new System.Windows.Forms.Button();
			this.BTNGenerateData = new System.Windows.Forms.Button();
			this.BannerSelector = new FileSelectorLibrary.FileSelector();
			this.BackGroundImageSelector = new FileSelectorLibrary.FileSelector();
			this.mp3Selector = new FileSelectorLibrary.FileSelector();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.BTNArrowVortex = new System.Windows.Forms.Button();
			this.CHKRoundBeatTimings = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.GBXSongSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(634, 492);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// BTNAddToSimFile
			// 
			this.BTNAddToSimFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTNAddToSimFile.Enabled = false;
			this.BTNAddToSimFile.Location = new System.Drawing.Point(434, 104);
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
			this.GBXSongSettings.Controls.Add(this.CHKRoundBeatTimings);
			this.GBXSongSettings.Controls.Add(this.BTNArrowVortex);
			this.GBXSongSettings.Controls.Add(this.BTNBPMCalc);
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
			this.GBXSongSettings.Controls.Add(this.label4);
			this.GBXSongSettings.Controls.Add(this.textBox2);
			this.GBXSongSettings.Controls.Add(this.label2);
			this.GBXSongSettings.Controls.Add(this.label1);
			this.GBXSongSettings.Controls.Add(this.TXTBpm);
			this.GBXSongSettings.Enabled = false;
			this.GBXSongSettings.Location = new System.Drawing.Point(9, 161);
			this.GBXSongSettings.Name = "GBXSongSettings";
			this.GBXSongSettings.Size = new System.Drawing.Size(614, 322);
			this.GBXSongSettings.TabIndex = 6;
			this.GBXSongSettings.TabStop = false;
			this.GBXSongSettings.Text = "Song Settings";
			// 
			// BTNBPMCalc
			// 
			this.BTNBPMCalc.Enabled = false;
			this.BTNBPMCalc.Location = new System.Drawing.Point(232, 180);
			this.BTNBPMCalc.Name = "BTNBPMCalc";
			this.BTNBPMCalc.Size = new System.Drawing.Size(168, 40);
			this.BTNBPMCalc.TabIndex = 33;
			this.BTNBPMCalc.Text = "Open BPM Calculator";
			this.BTNBPMCalc.UseVisualStyleBackColor = true;
			this.BTNBPMCalc.Click += new System.EventHandler(this.button1_Click);
			// 
			// TXTDifficultyNumber
			// 
			this.TXTDifficultyNumber.Location = new System.Drawing.Point(131, 144);
			this.TXTDifficultyNumber.MaxLength = 2;
			this.TXTDifficultyNumber.Name = "TXTDifficultyNumber";
			this.TXTDifficultyNumber.Size = new System.Drawing.Size(81, 22);
			this.TXTDifficultyNumber.TabIndex = 28;
			this.TXTDifficultyNumber.TextChanged += new System.EventHandler(this.NumberValidation);
			// 
			// TXTDifficultyName
			// 
			this.TXTDifficultyName.Location = new System.Drawing.Point(109, 114);
			this.TXTDifficultyName.MaxLength = 1200;
			this.TXTDifficultyName.Name = "TXTDifficultyName";
			this.TXTDifficultyName.Size = new System.Drawing.Size(103, 22);
			this.TXTDifficultyName.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(119, 17);
			this.label10.TabIndex = 26;
			this.label10.Text = "Difficulty Number:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 116);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 17);
			this.label9.TabIndex = 25;
			this.label9.Text = "Difficulty Name:";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(226, 136);
			this.trackBar2.Maximum = 100;
			this.trackBar2.Minimum = 50;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(171, 56);
			this.trackBar2.TabIndex = 24;
			this.trackBar2.TickFrequency = 5;
			this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar2.Value = 75;
			// 
			// TXTMapper
			// 
			this.TXTMapper.Location = new System.Drawing.Point(67, 85);
			this.TXTMapper.MaxLength = 1200;
			this.TXTMapper.Name = "TXTMapper";
			this.TXTMapper.Size = new System.Drawing.Size(145, 22);
			this.TXTMapper.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 22;
			this.label8.Text = "Mapper:";
			// 
			// TXTArtist
			// 
			this.TXTArtist.Location = new System.Drawing.Point(56, 54);
			this.TXTArtist.MaxLength = 1200;
			this.TXTArtist.Name = "TXTArtist";
			this.TXTArtist.Size = new System.Drawing.Size(156, 22);
			this.TXTArtist.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 56);
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
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Song Title:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(418, 88);
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
            "16",
            "12",
            "8",
            "4"});
			this.comboBox1.Location = new System.Drawing.Point(558, 85);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(50, 24);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.Text = "48";
			this.toolTip1.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip"));
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(229, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Offset (s):";
			// 
			// TXTOffset
			// 
			this.TXTOffset.Location = new System.Drawing.Point(317, 53);
			this.TXTOffset.MaxLength = 10;
			this.TXTOffset.Name = "TXTOffset";
			this.TXTOffset.Size = new System.Drawing.Size(83, 22);
			this.TXTOffset.TabIndex = 14;
			this.toolTip1.SetToolTip(this.TXTOffset, resources.GetString("TXTOffset.ToolTip"));
			this.TXTOffset.TextChanged += new System.EventHandler(this.FloatVailidation);
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
			this.textBox2.Enabled = false;
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
			this.TXTBpm.BackColor = System.Drawing.SystemColors.Window;
			this.TXTBpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTBpm.Location = new System.Drawing.Point(276, 24);
			this.TXTBpm.MaxLength = 10;
			this.TXTBpm.Name = "TXTBpm";
			this.TXTBpm.Size = new System.Drawing.Size(124, 22);
			this.TXTBpm.TabIndex = 0;
			this.toolTip1.SetToolTip(this.TXTBpm, resources.GetString("TXTBpm.ToolTip"));
			this.TXTBpm.TextChanged += new System.EventHandler(this.FloatVailidation);
			// 
			// BTNExportSimFile
			// 
			this.BTNExportSimFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTNExportSimFile.Enabled = false;
			this.BTNExportSimFile.Location = new System.Drawing.Point(434, 56);
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
			this.BTNGenerateData.BackColor = System.Drawing.SystemColors.Control;
			this.BTNGenerateData.Enabled = false;
			this.BTNGenerateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNGenerateData.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BTNGenerateData.Location = new System.Drawing.Point(434, 9);
			this.BTNGenerateData.Name = "BTNGenerateData";
			this.BTNGenerateData.Size = new System.Drawing.Size(189, 39);
			this.BTNGenerateData.TabIndex = 3;
			this.BTNGenerateData.Text = "Generate Data";
			this.BTNGenerateData.UseVisualStyleBackColor = false;
			this.BTNGenerateData.Click += new System.EventHandler(this.BTNGenerateData_Click);
			// 
			// BannerSelector
			// 
			this.BannerSelector.AllowedFileTypes = "";
			this.BannerSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BannerSelector.BackColor = System.Drawing.SystemColors.Control;
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
			this.BannerSelector.Filter = "";
			this.BannerSelector.Location = new System.Drawing.Point(9, 104);
			this.BannerSelector.LockFileFoundEvent = false;
			this.BannerSelector.Name = "BannerSelector";
			this.BannerSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BannerSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BannerSelector.Size = new System.Drawing.Size(414, 39);
			this.BannerSelector.TabIndex = 2;
			// 
			// BackGroundImageSelector
			// 
			this.BackGroundImageSelector.AllowedFileTypes = "";
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
			this.BackGroundImageSelector.Filter = "";
			this.BackGroundImageSelector.Location = new System.Drawing.Point(9, 56);
			this.BackGroundImageSelector.LockFileFoundEvent = false;
			this.BackGroundImageSelector.Name = "BackGroundImageSelector";
			this.BackGroundImageSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BackGroundImageSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.BackGroundImageSelector.Size = new System.Drawing.Size(414, 39);
			this.BackGroundImageSelector.TabIndex = 1;
			// 
			// mp3Selector
			// 
			this.mp3Selector.AllowedFileTypes = "mp3";
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
			this.mp3Selector.Filter = "Music Files (*.mp3)|*.mp3";
			this.mp3Selector.Location = new System.Drawing.Point(9, 9);
			this.mp3Selector.LockFileFoundEvent = false;
			this.mp3Selector.Name = "mp3Selector";
			this.mp3Selector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.mp3Selector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.mp3Selector.Size = new System.Drawing.Size(414, 39);
			this.mp3Selector.TabIndex = 0;
			this.mp3Selector.FileFound += new FileSelectorLibrary.FileSelector.FileFoundEventHandler(this.mp3Selector_FileFound);
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
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(643, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(275, 492);
			this.textBox1.TabIndex = 2;
			// 
			// BTNArrowVortex
			// 
			this.BTNArrowVortex.Location = new System.Drawing.Point(421, 21);
			this.BTNArrowVortex.Name = "BTNArrowVortex";
			this.BTNArrowVortex.Size = new System.Drawing.Size(187, 57);
			this.BTNArrowVortex.TabIndex = 34;
			this.BTNArrowVortex.Text = "Open ArrowVortex From Song";
			this.BTNArrowVortex.UseVisualStyleBackColor = true;
			this.BTNArrowVortex.Click += new System.EventHandler(this.BTNArrowVortex_Click);
			// 
			// CHKRoundBeatTimings
			// 
			this.CHKRoundBeatTimings.AutoSize = true;
			this.CHKRoundBeatTimings.Checked = true;
			this.CHKRoundBeatTimings.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CHKRoundBeatTimings.Location = new System.Drawing.Point(421, 116);
			this.CHKRoundBeatTimings.Name = "CHKRoundBeatTimings";
			this.CHKRoundBeatTimings.Size = new System.Drawing.Size(132, 38);
			this.CHKRoundBeatTimings.TabIndex = 35;
			this.CHKRoundBeatTimings.Text = "Round to Likely \r\nBeat Timings";
			this.CHKRoundBeatTimings.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(921, 498);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "SM File Mapper";
			this.panel1.ResumeLayout(false);
			this.GBXSongSettings.ResumeLayout(false);
			this.GBXSongSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		protected FileSelectorLibrary.FileSelector BackGroundImageSelector;
		protected FileSelectorLibrary.FileSelector BannerSelector;
		private System.Windows.Forms.Button BTNExportSimFile;
		private System.Windows.Forms.Button BTNGenerateData;
		private System.Windows.Forms.GroupBox GBXSongSettings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TXTBpm;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
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
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button BTNBPMCalc;
		public FileSelectorLibrary.FileSelector mp3Selector;
		private System.Windows.Forms.Button BTNArrowVortex;
		private System.Windows.Forms.CheckBox CHKRoundBeatTimings;
	}
}

