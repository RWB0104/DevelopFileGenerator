namespace DevelopFileGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.textBoxFolder = new System.Windows.Forms.TextBox();
			this.buttonPath = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.textBoxFile = new System.Windows.Forms.TextBox();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.buttonReset = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.labelProgress = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.labelPath = new System.Windows.Forms.Label();
			this.labelFolder = new System.Windows.Forms.Label();
			this.labelFile = new System.Windows.Forms.Label();
			this.labelFormat = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(16, 23);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(348, 23);
			this.progressBar.TabIndex = 0;
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(76, 107);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(248, 21);
			this.textBoxPath.TabIndex = 2;
			this.textBoxPath.TextChanged += new System.EventHandler(this.TextBoxPath_TextChanged);
			// 
			// textBoxFolder
			// 
			this.textBoxFolder.Location = new System.Drawing.Point(76, 139);
			this.textBoxFolder.Name = "textBoxFolder";
			this.textBoxFolder.Size = new System.Drawing.Size(248, 21);
			this.textBoxFolder.TabIndex = 4;
			this.textBoxFolder.TextChanged += new System.EventHandler(this.TextBoxFolder_TextChanged);
			// 
			// buttonPath
			// 
			this.buttonPath.Location = new System.Drawing.Point(330, 106);
			this.buttonPath.Name = "buttonPath";
			this.buttonPath.Size = new System.Drawing.Size(34, 23);
			this.buttonPath.TabIndex = 3;
			this.buttonPath.Text = "Set";
			this.buttonPath.UseVisualStyleBackColor = true;
			this.buttonPath.Click += new System.EventHandler(this.ButtonPath_Click);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Location = new System.Drawing.Point(61, 274);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(259, 12);
			this.labelCopyright.TabIndex = 4;
			this.labelCopyright.Text = "Copyright (C) 2019. RWB. All Rights Reserve.";
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(289, 60);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
			this.buttonSubmit.TabIndex = 7;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// textBoxFile
			// 
			this.textBoxFile.Location = new System.Drawing.Point(76, 171);
			this.textBoxFile.Name = "textBoxFile";
			this.textBoxFile.Size = new System.Drawing.Size(248, 21);
			this.textBoxFile.TabIndex = 5;
			this.textBoxFile.TextChanged += new System.EventHandler(this.TextBoxFile_TextChanged);
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(61, 63);
			this.numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(60, 21);
			this.numericUpDown.TabIndex = 1;
			this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(206, 60);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 6;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// labelProgress
			// 
			this.labelProgress.AutoSize = true;
			this.labelProgress.Location = new System.Drawing.Point(25, 7);
			this.labelProgress.Name = "labelProgress";
			this.labelProgress.Size = new System.Drawing.Size(0, 12);
			this.labelProgress.TabIndex = 9;
			// 
			// labelCount
			// 
			this.labelCount.Location = new System.Drawing.Point(254, 7);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(99, 13);
			this.labelCount.TabIndex = 10;
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonInfo
			// 
			this.buttonInfo.Location = new System.Drawing.Point(16, 61);
			this.buttonInfo.Name = "buttonInfo";
			this.buttonInfo.Size = new System.Drawing.Size(36, 23);
			this.buttonInfo.TabIndex = 11;
			this.buttonInfo.Text = "Info";
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
			// 
			// labelPath
			// 
			this.labelPath.Location = new System.Drawing.Point(12, 107);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(58, 21);
			this.labelPath.TabIndex = 12;
			this.labelPath.Text = "경로";
			this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelFolder
			// 
			this.labelFolder.Location = new System.Drawing.Point(12, 139);
			this.labelFolder.Name = "labelFolder";
			this.labelFolder.Size = new System.Drawing.Size(58, 21);
			this.labelFolder.TabIndex = 13;
			this.labelFolder.Text = "폴더 이름";
			this.labelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelFile
			// 
			this.labelFile.Location = new System.Drawing.Point(12, 171);
			this.labelFile.Name = "labelFile";
			this.labelFile.Size = new System.Drawing.Size(58, 21);
			this.labelFile.TabIndex = 14;
			this.labelFile.Text = "파일 형식";
			this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelFormat
			// 
			this.labelFormat.BackColor = System.Drawing.Color.White;
			this.labelFormat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFormat.Location = new System.Drawing.Point(14, 212);
			this.labelFormat.Name = "labelFormat";
			this.labelFormat.Size = new System.Drawing.Size(350, 48);
			this.labelFormat.TabIndex = 16;
			this.labelFormat.Text = "Path Formatter";
			this.labelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(378, 295);
			this.Controls.Add(this.labelFormat);
			this.Controls.Add(this.labelFile);
			this.Controls.Add(this.labelFolder);
			this.Controls.Add(this.labelPath);
			this.Controls.Add(this.buttonInfo);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelProgress);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.textBoxFile);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.buttonPath);
			this.Controls.Add(this.textBoxFolder);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.progressBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "DevelopFileGenerator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button buttonReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelFormat;
    }
}

