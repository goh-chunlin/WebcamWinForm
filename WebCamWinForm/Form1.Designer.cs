namespace WebCamWinForm
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
            this.ddlVideoDevices = new System.Windows.Forms.ComboBox();
            this.lblVideoDevices = new System.Windows.Forms.Label();
            this.lblAudioDevices = new System.Windows.Forms.Label();
            this.ddlAudioDevices = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtAzureStorageConnectionString = new System.Windows.Forms.TextBox();
            this.ddlVideoDuration = new System.Windows.Forms.ComboBox();
            this.lblVideoDuration = new System.Windows.Forms.Label();
            this.webcamRecordingTimer = new System.Windows.Forms.Timer(this.components);
            this.workerStoringVideoAsFile = new System.ComponentModel.BackgroundWorker();
            this.workerRecordingVideo = new System.ComponentModel.BackgroundWorker();
            this.lblAzureStorageConnectionString = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlVideoDevices
            // 
            this.ddlVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVideoDevices.FormattingEnabled = true;
            this.ddlVideoDevices.Location = new System.Drawing.Point(12, 29);
            this.ddlVideoDevices.Name = "ddlVideoDevices";
            this.ddlVideoDevices.Size = new System.Drawing.Size(637, 24);
            this.ddlVideoDevices.TabIndex = 0;
            // 
            // lblVideoDevices
            // 
            this.lblVideoDevices.AutoSize = true;
            this.lblVideoDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVideoDevices.Location = new System.Drawing.Point(9, 9);
            this.lblVideoDevices.Name = "lblVideoDevices";
            this.lblVideoDevices.Size = new System.Drawing.Size(110, 17);
            this.lblVideoDevices.TabIndex = 1;
            this.lblVideoDevices.Text = "Video Source:";
            // 
            // lblAudioDevices
            // 
            this.lblAudioDevices.AutoSize = true;
            this.lblAudioDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAudioDevices.Location = new System.Drawing.Point(9, 60);
            this.lblAudioDevices.Name = "lblAudioDevices";
            this.lblAudioDevices.Size = new System.Drawing.Size(110, 17);
            this.lblAudioDevices.TabIndex = 2;
            this.lblAudioDevices.Text = "Audio Source:";
            // 
            // ddlAudioDevices
            // 
            this.ddlAudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAudioDevices.FormattingEnabled = true;
            this.ddlAudioDevices.Location = new System.Drawing.Point(12, 80);
            this.ddlAudioDevices.Name = "ddlAudioDevices";
            this.ddlAudioDevices.Size = new System.Drawing.Size(637, 24);
            this.ddlAudioDevices.TabIndex = 3;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(526, 239);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(123, 41);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarStatus,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 398);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(661, 25);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "Status Strip";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(100, 19);
            this.progressBarStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 20);
            this.lblStatus.Text = "Strip Status Label";
            // 
            // txtAzureStorageConnectionString
            // 
            this.txtAzureStorageConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAzureStorageConnectionString.Location = new System.Drawing.Point(12, 190);
            this.txtAzureStorageConnectionString.Name = "txtAzureStorageConnectionString";
            this.txtAzureStorageConnectionString.Size = new System.Drawing.Size(637, 26);
            this.txtAzureStorageConnectionString.TabIndex = 6;
            // 
            // ddlVideoDuration
            // 
            this.ddlVideoDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVideoDuration.FormattingEnabled = true;
            this.ddlVideoDuration.Location = new System.Drawing.Point(12, 133);
            this.ddlVideoDuration.Name = "ddlVideoDuration";
            this.ddlVideoDuration.Size = new System.Drawing.Size(637, 24);
            this.ddlVideoDuration.TabIndex = 8;
            // 
            // lblVideoDuration
            // 
            this.lblVideoDuration.AutoSize = true;
            this.lblVideoDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVideoDuration.Location = new System.Drawing.Point(9, 113);
            this.lblVideoDuration.Name = "lblVideoDuration";
            this.lblVideoDuration.Size = new System.Drawing.Size(140, 17);
            this.lblVideoDuration.TabIndex = 7;
            this.lblVideoDuration.Text = "Duration of Video:";
            // 
            // webcamRecordingTimer
            // 
            this.webcamRecordingTimer.Interval = 1000;
            this.webcamRecordingTimer.Tick += new System.EventHandler(this.webcamRecordingTimer_Tick);
            // 
            // workerStoringVideoAsFile
            // 
            this.workerStoringVideoAsFile.WorkerReportsProgress = true;
            this.workerStoringVideoAsFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerStoringVideoAsFile_DoWork);
            this.workerStoringVideoAsFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerStoringVideoAsFile_ProgressChanged);
            this.workerStoringVideoAsFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerStoringVideoAsFile_RunWorkerCompleted);
            // 
            // workerRecordingVideo
            // 
            this.workerRecordingVideo.WorkerReportsProgress = true;
            this.workerRecordingVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerRecordingVideo_DoWork);
            this.workerRecordingVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerRecordingVideo_ProgressChanged);
            this.workerRecordingVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerRecordingVideo_RunWorkerCompleted);
            // 
            // lblAzureStorageConnectionString
            // 
            this.lblAzureStorageConnectionString.AutoSize = true;
            this.lblAzureStorageConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAzureStorageConnectionString.Location = new System.Drawing.Point(9, 170);
            this.lblAzureStorageConnectionString.Name = "lblAzureStorageConnectionString";
            this.lblAzureStorageConnectionString.Size = new System.Drawing.Size(251, 17);
            this.lblAzureStorageConnectionString.TabIndex = 9;
            this.lblAzureStorageConnectionString.Text = "Azure Storage Connection String:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 423);
            this.Controls.Add(this.lblAzureStorageConnectionString);
            this.Controls.Add(this.ddlVideoDuration);
            this.Controls.Add(this.lblVideoDuration);
            this.Controls.Add(this.txtAzureStorageConnectionString);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.ddlAudioDevices);
            this.Controls.Add(this.lblAudioDevices);
            this.Controls.Add(this.lblVideoDevices);
            this.Controls.Add(this.ddlVideoDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Webcam App (Demo)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlVideoDevices;
        private System.Windows.Forms.Label lblVideoDevices;
        private System.Windows.Forms.Label lblAudioDevices;
        private System.Windows.Forms.ComboBox ddlAudioDevices;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtAzureStorageConnectionString;
        private System.Windows.Forms.ComboBox ddlVideoDuration;
        private System.Windows.Forms.Label lblVideoDuration;
        private System.Windows.Forms.Timer webcamRecordingTimer;
        private System.ComponentModel.BackgroundWorker workerStoringVideoAsFile;
        private System.ComponentModel.BackgroundWorker workerRecordingVideo;
        private System.Windows.Forms.ToolStripProgressBar progressBarStatus;
        private System.Windows.Forms.Label lblAzureStorageConnectionString;
    }
}

