using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using WebCamWinForm.Models;

namespace WebCamWinForm.Services
{
    public class Webcam
    {
        private Size _frameSize = new Size(640, 480);
        private long _frameDuration = 25;

        public LiveJob Job { get; set; }

        public LiveDeviceSource DeviceStatus { get; set; }

        public VideoAndAudioRecordingDevice RecordingSources { get; set; }

        public RecordingOutputFile RecordingOutputFileInfo { get; set; }




        public void StartJob()
        {
            Job = new LiveJob();

            Job.OutputFormat.VideoProfile.Size = _frameSize;

            DeviceStatus = Job.AddDeviceSource(RecordingSources.VideoRecordingDevice, RecordingSources.AudioRecordingDevice);
            DeviceStatus.PickBestVideoFormat(_frameSize, _frameDuration);

            Job.ActivateSource(DeviceStatus);
        }

        public void ConnectSelectedVideoAndAudioDevices(RecordingDeviceInfo selectedVideoDevice, RecordingDeviceInfo selectedAudioDevice)
        {
            EncoderDevice videoSource = null;
            EncoderDevice audioSource = null;

            foreach (EncoderDevice device in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (device.Name == selectedVideoDevice.DeviceName)
                {
                    videoSource = device;
                    break;
                }
            }

            foreach (EncoderDevice device in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (device.Name == selectedAudioDevice.DeviceName)
                {
                    audioSource = device;
                    break;
                }
            }

            RecordingSources = new VideoAndAudioRecordingDevice { VideoRecordingDevice = videoSource, AudioRecordingDevice = audioSource };
        }

        public void StartEncoding()
        {
            Job.StartEncoding();
        }

        public void StopEncoding()
        {
            Job.StopEncoding();
        }

        public void GenerateOutputFile()
        {
            FileArchivePublishFormat fileOut = new FileArchivePublishFormat();

            string fileName = $"{DateTime.Now.ToString("yyyy_MM_dd_HHmmss")}_TESTING.mp4";

            string webcamVideoLocalDirectory = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Videos";
            if (!Directory.Exists(webcamVideoLocalDirectory))
            {
                Directory.CreateDirectory(webcamVideoLocalDirectory);
            }

            string filePath = Path.Combine(webcamVideoLocalDirectory, fileName);
            fileOut.OutputFileName = filePath;

            Job.PublishFormats.Clear();
            Job.PublishFormats.Add(fileOut);

            RecordingOutputFileInfo = new RecordingOutputFile { FilePath = filePath, FileName = fileName };
        }

        public void StopJob()
        {
            if (Job != null)
            {
                Job.StopEncoding();

                if (DeviceStatus != null)
                {
                    Job.RemoveDeviceSource(DeviceStatus);

                    DeviceStatus = null;
                }
                
            }
        }
    }
}
