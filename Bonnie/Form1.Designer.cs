namespace Bonnie
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_EBConfig = new System.Windows.Forms.ComboBox();
            this.textBox_EBFilePathBOM = new System.Windows.Forms.TextBox();
            this.label_EBTotalConfig = new System.Windows.Forms.Label();
            this.button_OpenFile1 = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.button_ExplodeBOM = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExplodeBOM = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageImportSide = new System.Windows.Forms.TabPage();
            this.button_ISOpenFileTXT = new System.Windows.Forms.Button();
            this.textBox_ISFilePathTXT = new System.Windows.Forms.TextBox();
            this.button_ImportSide = new System.Windows.Forms.Button();
            this.label_ISConfig = new System.Windows.Forms.Label();
            this.button_ISOpenFileEXP = new System.Windows.Forms.Button();
            this.comboBox_ISConfig = new System.Windows.Forms.ComboBox();
            this.textBox_ISFilePathEXP = new System.Windows.Forms.TextBox();
            this.tabPageOtpionManagement = new System.Windows.Forms.TabPage();
            this.checkBox_OMSimplifySameConfig = new System.Windows.Forms.CheckBox();
            this.button_OM = new System.Windows.Forms.Button();
            this.groupBox_OMAction = new System.Windows.Forms.GroupBox();
            this.label_OMConfig = new System.Windows.Forms.Label();
            this.label_OMAction = new System.Windows.Forms.Label();
            this.comboBox_OMAction = new System.Windows.Forms.ComboBox();
            this.comboBox_OM1 = new System.Windows.Forms.ComboBox();
            this.comboBox_OM2 = new System.Windows.Forms.ComboBox();
            this.label_OM_Total = new System.Windows.Forms.Label();
            this.button_OMOpenFile = new System.Windows.Forms.Button();
            this.textBox_FilePathOM = new System.Windows.Forms.TextBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabel_OfficialSite = new System.Windows.Forms.LinkLabel();
            this.lable_version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageExplodeBOM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageImportSide.SuspendLayout();
            this.tabPageOtpionManagement.SuspendLayout();
            this.groupBox_OMAction.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 14);
            label3.TabIndex = 13;
            label3.Text = "Import to Config";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(197, 14);
            label4.TabIndex = 14;
            label4.Text = "Select .EXP file from Capture Orcad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(260, 14);
            label5.TabIndex = 15;
            label5.Text = "Select RPT/TXT component report from Allegro :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(158, 14);
            label6.TabIndex = 6;
            label6.Text = "Select .BOM file to explode :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(175, 97);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 14);
            label7.TabIndex = 7;
            label7.Text = "Select Config to explode :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(212, 35);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 20);
            label8.TabIndex = 1;
            label8.Text = "Bonnie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            label9.Location = new System.Drawing.Point(213, 59);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(133, 14);
            label9.TabIndex = 3;
            label9.Text = "BOM Management Tool";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(22, 155);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(213, 14);
            label10.TabIndex = 4;
            label10.Text = "Find documents, updates, supports at";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 5);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(197, 14);
            label11.TabIndex = 17;
            label11.Text = "Select .EXP file from Capture Orcad :";
            // 
            // comboBox_EBConfig
            // 
            this.comboBox_EBConfig.Enabled = false;
            this.comboBox_EBConfig.FormattingEnabled = true;
            this.comboBox_EBConfig.Location = new System.Drawing.Point(323, 94);
            this.comboBox_EBConfig.Name = "comboBox_EBConfig";
            this.comboBox_EBConfig.Size = new System.Drawing.Size(80, 22);
            this.comboBox_EBConfig.TabIndex = 0;
            // 
            // textBox_EBFilePathBOM
            // 
            this.textBox_EBFilePathBOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EBFilePathBOM.Enabled = false;
            this.textBox_EBFilePathBOM.Location = new System.Drawing.Point(6, 26);
            this.textBox_EBFilePathBOM.Name = "textBox_EBFilePathBOM";
            this.textBox_EBFilePathBOM.Size = new System.Drawing.Size(411, 22);
            this.textBox_EBFilePathBOM.TabIndex = 1;
            // 
            // label_EBTotalConfig
            // 
            this.label_EBTotalConfig.AutoSize = true;
            this.label_EBTotalConfig.Location = new System.Drawing.Point(192, 66);
            this.label_EBTotalConfig.Name = "label_EBTotalConfig";
            this.label_EBTotalConfig.Size = new System.Drawing.Size(114, 14);
            this.label_EBTotalConfig.TabIndex = 2;
            this.label_EBTotalConfig.Text = "label_EBTotalConfig";
            // 
            // button_OpenFile1
            // 
            this.button_OpenFile1.Location = new System.Drawing.Point(323, 60);
            this.button_OpenFile1.Name = "button_OpenFile1";
            this.button_OpenFile1.Size = new System.Drawing.Size(94, 27);
            this.button_OpenFile1.TabIndex = 3;
            this.button_OpenFile1.Text = "Select BOM File";
            this.button_OpenFile1.UseVisualStyleBackColor = true;
            this.button_OpenFile1.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // LogBox
            // 
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.HorizontalScrollbar = true;
            this.LogBox.ItemHeight = 14;
            this.LogBox.Location = new System.Drawing.Point(6, 254);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(429, 212);
            this.LogBox.TabIndex = 4;
            // 
            // button_ExplodeBOM
            // 
            this.button_ExplodeBOM.Enabled = false;
            this.button_ExplodeBOM.Location = new System.Drawing.Point(323, 143);
            this.button_ExplodeBOM.Name = "button_ExplodeBOM";
            this.button_ExplodeBOM.Size = new System.Drawing.Size(94, 27);
            this.button_ExplodeBOM.TabIndex = 5;
            this.button_ExplodeBOM.Text = "Explode";
            this.button_ExplodeBOM.UseVisualStyleBackColor = true;
            this.button_ExplodeBOM.Click += new System.EventHandler(this.button_Explode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageExplodeBOM);
            this.tabControl1.Controls.Add(this.tabPageImportSide);
            this.tabControl1.Controls.Add(this.tabPageOtpionManagement);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 236);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageExplodeBOM
            // 
            this.tabPageExplodeBOM.Controls.Add(this.groupBox1);
            this.tabPageExplodeBOM.Controls.Add(label7);
            this.tabPageExplodeBOM.Controls.Add(label6);
            this.tabPageExplodeBOM.Controls.Add(this.textBox_EBFilePathBOM);
            this.tabPageExplodeBOM.Controls.Add(this.button_ExplodeBOM);
            this.tabPageExplodeBOM.Controls.Add(this.label_EBTotalConfig);
            this.tabPageExplodeBOM.Controls.Add(this.button_OpenFile1);
            this.tabPageExplodeBOM.Controls.Add(this.comboBox_EBConfig);
            this.tabPageExplodeBOM.Location = new System.Drawing.Point(4, 23);
            this.tabPageExplodeBOM.Name = "tabPageExplodeBOM";
            this.tabPageExplodeBOM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExplodeBOM.Size = new System.Drawing.Size(423, 209);
            this.tabPageExplodeBOM.TabIndex = 0;
            this.tabPageExplodeBOM.Text = "Explode BOM";
            this.tabPageExplodeBOM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Copy";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "CPS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Header";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageImportSide
            // 
            this.tabPageImportSide.Controls.Add(label5);
            this.tabPageImportSide.Controls.Add(label4);
            this.tabPageImportSide.Controls.Add(label3);
            this.tabPageImportSide.Controls.Add(this.button_ISOpenFileTXT);
            this.tabPageImportSide.Controls.Add(this.textBox_ISFilePathTXT);
            this.tabPageImportSide.Controls.Add(this.button_ImportSide);
            this.tabPageImportSide.Controls.Add(this.label_ISConfig);
            this.tabPageImportSide.Controls.Add(this.button_ISOpenFileEXP);
            this.tabPageImportSide.Controls.Add(this.comboBox_ISConfig);
            this.tabPageImportSide.Controls.Add(this.textBox_ISFilePathEXP);
            this.tabPageImportSide.Location = new System.Drawing.Point(4, 23);
            this.tabPageImportSide.Name = "tabPageImportSide";
            this.tabPageImportSide.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportSide.Size = new System.Drawing.Size(423, 209);
            this.tabPageImportSide.TabIndex = 1;
            this.tabPageImportSide.Text = "Import Side";
            this.tabPageImportSide.UseVisualStyleBackColor = true;
            // 
            // button_ISOpenFileTXT
            // 
            this.button_ISOpenFileTXT.Location = new System.Drawing.Point(331, 72);
            this.button_ISOpenFileTXT.Name = "button_ISOpenFileTXT";
            this.button_ISOpenFileTXT.Size = new System.Drawing.Size(86, 27);
            this.button_ISOpenFileTXT.TabIndex = 12;
            this.button_ISOpenFileTXT.Text = "RPT/TXT";
            this.button_ISOpenFileTXT.UseVisualStyleBackColor = true;
            this.button_ISOpenFileTXT.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_ISFilePathTXT
            // 
            this.textBox_ISFilePathTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ISFilePathTXT.Enabled = false;
            this.textBox_ISFilePathTXT.Location = new System.Drawing.Point(6, 76);
            this.textBox_ISFilePathTXT.Name = "textBox_ISFilePathTXT";
            this.textBox_ISFilePathTXT.Size = new System.Drawing.Size(319, 22);
            this.textBox_ISFilePathTXT.TabIndex = 11;
            // 
            // button_ImportSide
            // 
            this.button_ImportSide.Enabled = false;
            this.button_ImportSide.Location = new System.Drawing.Point(342, 176);
            this.button_ImportSide.Name = "button_ImportSide";
            this.button_ImportSide.Size = new System.Drawing.Size(75, 27);
            this.button_ImportSide.TabIndex = 10;
            this.button_ImportSide.Text = "Import";
            this.button_ImportSide.UseVisualStyleBackColor = true;
            this.button_ImportSide.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // label_ISConfig
            // 
            this.label_ISConfig.AutoSize = true;
            this.label_ISConfig.Location = new System.Drawing.Point(4, 112);
            this.label_ISConfig.Name = "label_ISConfig";
            this.label_ISConfig.Size = new System.Drawing.Size(84, 14);
            this.label_ISConfig.TabIndex = 7;
            this.label_ISConfig.Text = "label_ISConfig";
            // 
            // button_ISOpenFileEXP
            // 
            this.button_ISOpenFileEXP.Location = new System.Drawing.Point(331, 22);
            this.button_ISOpenFileEXP.Name = "button_ISOpenFileEXP";
            this.button_ISOpenFileEXP.Size = new System.Drawing.Size(86, 27);
            this.button_ISOpenFileEXP.TabIndex = 8;
            this.button_ISOpenFileEXP.Text = "EXP File";
            this.button_ISOpenFileEXP.UseVisualStyleBackColor = true;
            this.button_ISOpenFileEXP.Click += new System.EventHandler(this.button_OpenFile2_Click);
            // 
            // comboBox_ISConfig
            // 
            this.comboBox_ISConfig.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_ISConfig.Enabled = false;
            this.comboBox_ISConfig.FormattingEnabled = true;
            this.comboBox_ISConfig.Location = new System.Drawing.Point(102, 136);
            this.comboBox_ISConfig.Name = "comboBox_ISConfig";
            this.comboBox_ISConfig.Size = new System.Drawing.Size(80, 22);
            this.comboBox_ISConfig.TabIndex = 6;
            // 
            // textBox_ISFilePathEXP
            // 
            this.textBox_ISFilePathEXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ISFilePathEXP.Enabled = false;
            this.textBox_ISFilePathEXP.Location = new System.Drawing.Point(6, 26);
            this.textBox_ISFilePathEXP.Name = "textBox_ISFilePathEXP";
            this.textBox_ISFilePathEXP.Size = new System.Drawing.Size(319, 22);
            this.textBox_ISFilePathEXP.TabIndex = 2;
            // 
            // tabPageOtpionManagement
            // 
            this.tabPageOtpionManagement.Controls.Add(this.checkBox_OMSimplifySameConfig);
            this.tabPageOtpionManagement.Controls.Add(this.button_OM);
            this.tabPageOtpionManagement.Controls.Add(this.groupBox_OMAction);
            this.tabPageOtpionManagement.Controls.Add(this.label_OM_Total);
            this.tabPageOtpionManagement.Controls.Add(label11);
            this.tabPageOtpionManagement.Controls.Add(this.button_OMOpenFile);
            this.tabPageOtpionManagement.Controls.Add(this.textBox_FilePathOM);
            this.tabPageOtpionManagement.Location = new System.Drawing.Point(4, 23);
            this.tabPageOtpionManagement.Name = "tabPageOtpionManagement";
            this.tabPageOtpionManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOtpionManagement.Size = new System.Drawing.Size(423, 209);
            this.tabPageOtpionManagement.TabIndex = 3;
            this.tabPageOtpionManagement.Text = "Option Management";
            this.tabPageOtpionManagement.UseVisualStyleBackColor = true;
            // 
            // checkBox_OMSimplifySameConfig
            // 
            this.checkBox_OMSimplifySameConfig.AutoSize = true;
            this.checkBox_OMSimplifySameConfig.Location = new System.Drawing.Point(192, 181);
            this.checkBox_OMSimplifySameConfig.Name = "checkBox_OMSimplifySameConfig";
            this.checkBox_OMSimplifySameConfig.Size = new System.Drawing.Size(138, 18);
            this.checkBox_OMSimplifySameConfig.TabIndex = 25;
            this.checkBox_OMSimplifySameConfig.Text = "Simplify Same Config";
            this.checkBox_OMSimplifySameConfig.UseVisualStyleBackColor = true;
            // 
            // button_OM
            // 
            this.button_OM.Enabled = false;
            this.button_OM.Location = new System.Drawing.Point(331, 176);
            this.button_OM.Name = "button_OM";
            this.button_OM.Size = new System.Drawing.Size(86, 27);
            this.button_OM.TabIndex = 22;
            this.button_OM.Text = "Do It !";
            this.button_OM.UseVisualStyleBackColor = true;
            this.button_OM.Click += new System.EventHandler(this.button_OM_Click);
            // 
            // groupBox_OMAction
            // 
            this.groupBox_OMAction.Controls.Add(this.label_OMConfig);
            this.groupBox_OMAction.Controls.Add(this.label_OMAction);
            this.groupBox_OMAction.Controls.Add(this.comboBox_OMAction);
            this.groupBox_OMAction.Controls.Add(this.comboBox_OM1);
            this.groupBox_OMAction.Controls.Add(this.comboBox_OM2);
            this.groupBox_OMAction.Enabled = false;
            this.groupBox_OMAction.Location = new System.Drawing.Point(30, 77);
            this.groupBox_OMAction.Name = "groupBox_OMAction";
            this.groupBox_OMAction.Size = new System.Drawing.Size(331, 62);
            this.groupBox_OMAction.TabIndex = 21;
            this.groupBox_OMAction.TabStop = false;
            this.groupBox_OMAction.Text = "Action";
            // 
            // label_OMConfig
            // 
            this.label_OMConfig.AutoSize = true;
            this.label_OMConfig.Enabled = false;
            this.label_OMConfig.Location = new System.Drawing.Point(117, 24);
            this.label_OMConfig.Name = "label_OMConfig";
            this.label_OMConfig.Size = new System.Drawing.Size(39, 14);
            this.label_OMConfig.TabIndex = 24;
            this.label_OMConfig.Text = "Config";
            // 
            // label_OMAction
            // 
            this.label_OMAction.AutoSize = true;
            this.label_OMAction.Location = new System.Drawing.Point(216, 24);
            this.label_OMAction.Name = "label_OMAction";
            this.label_OMAction.Size = new System.Drawing.Size(40, 14);
            this.label_OMAction.TabIndex = 23;
            this.label_OMAction.Text = "Action";
            // 
            // comboBox_OMAction
            // 
            this.comboBox_OMAction.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_OMAction.Enabled = false;
            this.comboBox_OMAction.FormattingEnabled = true;
            this.comboBox_OMAction.Location = new System.Drawing.Point(12, 21);
            this.comboBox_OMAction.Name = "comboBox_OMAction";
            this.comboBox_OMAction.Size = new System.Drawing.Size(90, 22);
            this.comboBox_OMAction.TabIndex = 21;
            this.comboBox_OMAction.SelectedValueChanged += new System.EventHandler(this.comboBox_OMAction_SelectedValueChanged);
            // 
            // comboBox_OM1
            // 
            this.comboBox_OM1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_OM1.Enabled = false;
            this.comboBox_OM1.FormattingEnabled = true;
            this.comboBox_OM1.Location = new System.Drawing.Point(162, 21);
            this.comboBox_OM1.Name = "comboBox_OM1";
            this.comboBox_OM1.Size = new System.Drawing.Size(48, 22);
            this.comboBox_OM1.TabIndex = 19;
            // 
            // comboBox_OM2
            // 
            this.comboBox_OM2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_OM2.Enabled = false;
            this.comboBox_OM2.FormattingEnabled = true;
            this.comboBox_OM2.Location = new System.Drawing.Point(262, 21);
            this.comboBox_OM2.Name = "comboBox_OM2";
            this.comboBox_OM2.Size = new System.Drawing.Size(48, 22);
            this.comboBox_OM2.TabIndex = 20;
            // 
            // label_OM_Total
            // 
            this.label_OM_Total.AutoSize = true;
            this.label_OM_Total.Location = new System.Drawing.Point(9, 51);
            this.label_OM_Total.Name = "label_OM_Total";
            this.label_OM_Total.Size = new System.Drawing.Size(93, 14);
            this.label_OM_Total.TabIndex = 18;
            this.label_OM_Total.Text = "label_OM_Total";
            // 
            // button_OMOpenFile
            // 
            this.button_OMOpenFile.Location = new System.Drawing.Point(331, 22);
            this.button_OMOpenFile.Name = "button_OMOpenFile";
            this.button_OMOpenFile.Size = new System.Drawing.Size(86, 27);
            this.button_OMOpenFile.TabIndex = 16;
            this.button_OMOpenFile.Text = "EXP File";
            this.button_OMOpenFile.UseVisualStyleBackColor = true;
            this.button_OMOpenFile.Click += new System.EventHandler(this.button_OpenFileOM1_Click);
            // 
            // textBox_FilePathOM
            // 
            this.textBox_FilePathOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FilePathOM.Enabled = false;
            this.textBox_FilePathOM.Location = new System.Drawing.Point(6, 22);
            this.textBox_FilePathOM.Name = "textBox_FilePathOM";
            this.textBox_FilePathOM.Size = new System.Drawing.Size(319, 22);
            this.textBox_FilePathOM.TabIndex = 15;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.linkLabel_OfficialSite);
            this.tabPageAbout.Controls.Add(label10);
            this.tabPageAbout.Controls.Add(label9);
            this.tabPageAbout.Controls.Add(this.lable_version);
            this.tabPageAbout.Controls.Add(label8);
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 23);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(423, 209);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About Bonnie";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel_OfficialSite
            // 
            this.linkLabel_OfficialSite.AutoSize = true;
            this.linkLabel_OfficialSite.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_OfficialSite.Location = new System.Drawing.Point(23, 171);
            this.linkLabel_OfficialSite.Name = "linkLabel_OfficialSite";
            this.linkLabel_OfficialSite.Size = new System.Drawing.Size(111, 14);
            this.linkLabel_OfficialSite.TabIndex = 5;
            this.linkLabel_OfficialSite.TabStop = true;
            this.linkLabel_OfficialSite.Text = "Bonnie Official Site";
            this.linkLabel_OfficialSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lable_version
            // 
            this.lable_version.AutoSize = true;
            this.lable_version.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_version.Location = new System.Drawing.Point(214, 83);
            this.lable_version.Name = "lable_version";
            this.lable_version.Size = new System.Drawing.Size(48, 14);
            this.lable_version.TabIndex = 2;
            this.lable_version.Text = "Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(447, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LogBox);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bonnie - BOM Config";
            this.tabControl1.ResumeLayout(false);
            this.tabPageExplodeBOM.ResumeLayout(false);
            this.tabPageExplodeBOM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageImportSide.ResumeLayout(false);
            this.tabPageImportSide.PerformLayout();
            this.tabPageOtpionManagement.ResumeLayout(false);
            this.tabPageOtpionManagement.PerformLayout();
            this.groupBox_OMAction.ResumeLayout(false);
            this.groupBox_OMAction.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_EBConfig;
        private System.Windows.Forms.TextBox textBox_EBFilePathBOM;
        private System.Windows.Forms.Label label_EBTotalConfig;
        private System.Windows.Forms.Button button_OpenFile1;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Button button_ExplodeBOM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageExplodeBOM;
        private System.Windows.Forms.TabPage tabPageImportSide;
        private System.Windows.Forms.Button button_ISOpenFileTXT;
        private System.Windows.Forms.TextBox textBox_ISFilePathTXT;
        private System.Windows.Forms.Button button_ImportSide;
        private System.Windows.Forms.Label label_ISConfig;
        private System.Windows.Forms.Button button_ISOpenFileEXP;
        private System.Windows.Forms.ComboBox comboBox_ISConfig;
        private System.Windows.Forms.TextBox textBox_ISFilePathEXP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable_version;
        private System.Windows.Forms.LinkLabel linkLabel_OfficialSite;
        private System.Windows.Forms.TabPage tabPageOtpionManagement;
        private System.Windows.Forms.Button button_OMOpenFile;
        private System.Windows.Forms.TextBox textBox_FilePathOM;
        private System.Windows.Forms.Label label_OM_Total;
        private System.Windows.Forms.Button button_OM;
        private System.Windows.Forms.GroupBox groupBox_OMAction;
        private System.Windows.Forms.ComboBox comboBox_OMAction;
        private System.Windows.Forms.ComboBox comboBox_OM1;
        private System.Windows.Forms.ComboBox comboBox_OM2;
        private System.Windows.Forms.Label label_OMAction;
        private System.Windows.Forms.Label label_OMConfig;
        private System.Windows.Forms.CheckBox checkBox_OMSimplifySameConfig;
    }
}

