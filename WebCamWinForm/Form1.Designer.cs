
namespace WebCamWinForm2020
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVideoDevices = new System.Windows.Forms.Label();
            this.ddlVideoDevices = new System.Windows.Forms.ComboBox();
            this.lblAzureStorageConnectionString = new System.Windows.Forms.Label();
            this.txtAzureStorageConnectionString = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recordingTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVideoDevices
            // 
            this.lblVideoDevices.AutoSize = true;
            this.lblVideoDevices.Location = new System.Drawing.Point(12, 9);
            this.lblVideoDevices.Name = "lblVideoDevices";
            this.lblVideoDevices.Size = new System.Drawing.Size(100, 20);
            this.lblVideoDevices.TabIndex = 0;
            this.lblVideoDevices.Text = "Video Source:";
            // 
            // ddlVideoDevices
            // 
            this.ddlVideoDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVideoDevices.FormattingEnabled = true;
            this.ddlVideoDevices.Location = new System.Drawing.Point(12, 32);
            this.ddlVideoDevices.Name = "ddlVideoDevices";
            this.ddlVideoDevices.Size = new System.Drawing.Size(943, 28);
            this.ddlVideoDevices.TabIndex = 1;
            // 
            // lblAzureStorageConnectionString
            // 
            this.lblAzureStorageConnectionString.AutoSize = true;
            this.lblAzureStorageConnectionString.Location = new System.Drawing.Point(12, 63);
            this.lblAzureStorageConnectionString.Name = "lblAzureStorageConnectionString";
            this.lblAzureStorageConnectionString.Size = new System.Drawing.Size(263, 20);
            this.lblAzureStorageConnectionString.TabIndex = 6;
            this.lblAzureStorageConnectionString.Text = "Azure Blob Storage Connection String:";
            // 
            // txtAzureStorageConnectionString
            // 
            this.txtAzureStorageConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAzureStorageConnectionString.Location = new System.Drawing.Point(12, 86);
            this.txtAzureStorageConnectionString.Name = "txtAzureStorageConnectionString";
            this.txtAzureStorageConnectionString.Size = new System.Drawing.Size(943, 27);
            this.txtAzureStorageConnectionString.TabIndex = 7;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.Location = new System.Drawing.Point(832, 119);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(123, 41);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 557);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(967, 26);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 20);
            this.lblStatus.Text = "Strip Status Label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // recordingTimer
            // 
            this.recordingTimer.Interval = 17;
            this.recordingTimer.Tick += new System.EventHandler(this.recordingTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtAzureStorageConnectionString);
            this.Controls.Add(this.lblAzureStorageConnectionString);
            this.Controls.Add(this.ddlVideoDevices);
            this.Controls.Add(this.lblVideoDevices);
            this.Name = "Form1";
            this.Text = "Webcam App (Demo)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVideoDevices;
        private System.Windows.Forms.ComboBox ddlVideoDevices;
        private System.Windows.Forms.Label lblAzureStorageConnectionString;
        private System.Windows.Forms.TextBox txtAzureStorageConnectionString;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer recordingTimer;
    }
}

