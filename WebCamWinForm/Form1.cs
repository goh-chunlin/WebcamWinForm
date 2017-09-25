using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WebCamWinForm.Models;
using WebCamWinForm.Services;

namespace WebCamWinForm
{
    public partial class Form1 : Form
    {
        private Webcam _webcam;

        Dictionary<int, Tuple<string, int>> availableVideoDurationOptions = new Dictionary<int, Tuple<string, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                ddlVideoDevices.Items.Add(edv.Name);
            }

            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                ddlAudioDevices.Items.Add(edv.Name);
            }

            availableVideoDurationOptions.Add(0, new Tuple<string, int>("10 seconds", 10));
            availableVideoDurationOptions.Add(1, new Tuple<string, int>("15 seconds", 15));
            availableVideoDurationOptions.Add(2, new Tuple<string, int>("30 seconds", 30));
            availableVideoDurationOptions.Add(3, new Tuple<string, int>("60 seconds", 60));
            availableVideoDurationOptions.Add(4, new Tuple<string, int>("3 minutes", 180));

            foreach (var option in availableVideoDurationOptions)
            {
                ddlVideoDuration.Items.Add(option.Value.Item1);
            }

            ddlVideoDuration.SelectedIndex = 0;

            _webcam = new Webcam();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (ddlVideoDevices.SelectedIndex < 0 || ddlAudioDevices.SelectedIndex < 0 || ddlVideoDuration.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtAzureStorageConnectionString.Text))
            {
                string warningMessage = "Please make sure all inputs are filled in properly.";
                MessageBox.Show(warningMessage);
                lblStatus.Text = warningMessage;
            }
            else
            {
                workerRecordingVideo.RunWorkerAsync();

                UpdateUserInputsEnability(false);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _webcam.StopJob();
        }

        private void webcamRecordingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                webcamRecordingTimer.Enabled = false;
                webcamRecordingTimer.Stop();

                _webcam.StopEncoding();

                _webcam.StopJob();

                workerStoringVideoAsFile.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void workerRecordingVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            try
            {
                worker.ReportProgress(0, "Getting physical selected device...");

                int selectedVideoDeviceIndex = -1;
                int selectedAudioDeviceIndex = -1;
                string selectedVideoDeviceName = null;
                string selectedAudioDeviceName = null;

                if (ddlVideoDevices.InvokeRequired)
                {
                    ddlVideoDevices.Invoke(new MethodInvoker(delegate {
                        selectedVideoDeviceIndex = ddlVideoDevices.SelectedIndex;
                        selectedVideoDeviceName = ddlVideoDevices.SelectedItem.ToString();
                    }));
                }

                if (ddlAudioDevices.InvokeRequired)
                {
                    ddlAudioDevices.Invoke(new MethodInvoker(delegate {
                        selectedAudioDeviceIndex = ddlAudioDevices.SelectedIndex;
                        selectedAudioDeviceName = ddlAudioDevices.SelectedItem.ToString();
                    }));
                }

                _webcam.ConnectSelectedVideoAndAudioDevices(
                       new RecordingDeviceInfo { DeviceOptionIndex = selectedVideoDeviceIndex, DeviceName = selectedVideoDeviceName },
                       new RecordingDeviceInfo { DeviceOptionIndex = selectedAudioDeviceIndex, DeviceName = selectedAudioDeviceName });

                _webcam.StopJob();

                worker.ReportProgress(25, "Creating job...");

                _webcam.StartJob();

                worker.ReportProgress(40, "Set device source.");

                _webcam.GenerateOutputFile();

                worker.ReportProgress(50, "Created a media file.");

                _webcam.StartEncoding();

                worker.ReportProgress(60, "Starting to record...");
            }
            catch (Exception ex)
            {
                worker.ReportProgress(100, ex.Message);
            }
        }

        private void workerRecordingVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarStatus.Visible = true;
            progressBarStatus.Value = e.ProgressPercentage;

            lblStatus.Text = (string)e.UserState;
        }

        private void workerRecordingVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            webcamRecordingTimer.Enabled = true;
            webcamRecordingTimer.Interval = availableVideoDurationOptions[ddlVideoDuration.SelectedIndex].Item2 * 1000;
            webcamRecordingTimer.Start();
        }

        private void workerStoringVideoAsFile_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            try
            {
                worker.ReportProgress(80, "Start uploading video...");

                AzureStorage.UploadFile(txtAzureStorageConnectionString.Text, 
                    _webcam.RecordingOutputFileInfo.FileName, FileProcessor.ConvertFileToBytes(_webcam.RecordingOutputFileInfo.FilePath));

                worker.ReportProgress(100, $"Success!");
            }
            catch (Exception ex)
            {
                worker.ReportProgress(100, ex.Message);
            }
        }

        private void workerStoringVideoAsFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarStatus.Visible = true;
            progressBarStatus.Value = e.ProgressPercentage;

            lblStatus.Text = (string)e.UserState;
        }

        private void workerStoringVideoAsFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarStatus.Visible = false;

            UpdateUserInputsEnability(true);
        }

        private void UpdateUserInputsEnability(bool isSetToEnabled)
        {
            ddlVideoDevices.Enabled = 
                ddlAudioDevices.Enabled = 
                ddlVideoDuration.Enabled = 
                txtAzureStorageConnectionString.Enabled = 
                btnRecord.Enabled = isSetToEnabled;
        }
    }
}
