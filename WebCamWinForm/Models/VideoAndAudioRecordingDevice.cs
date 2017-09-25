using Microsoft.Expression.Encoder.Devices;

namespace WebCamWinForm.Models
{
    public class VideoAndAudioRecordingDevice
    {
        public EncoderDevice VideoRecordingDevice { get; set; }

        public EncoderDevice AudioRecordingDevice { get; set; }
    }
}
