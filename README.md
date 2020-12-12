# WebcamWinForm

<div align="center">
    <img src="https://gclstorage.blob.core.windows.net/images/WebcamWinForm-banner.png" />
</div>

[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Donate](https://img.shields.io/badge/$-donate-ff69b4.svg)](https://www.buymeacoffee.com/chunlin)

A simple Windows Forms (.NET 5) application to demonstrate how to record video and audio via a Logitech webcam using C#.

## Objective
In 2017, inspired by ["How to use a web cam in C# with .NET Framework 4.0 and Microsoft Expression Encoder 4", a project on Code Project by Italian software developer Massimo Conti](https://www.codeproject.com/Articles/202464/How-to-use-a-WebCam-in-C-with-the-NET-Framework), I built a simple demo to show how we can connect C# Windows Form with a webcam to record both video and audio.

In 2020, .NET 5 is officially announced by Microsoft. Many libraries that I used earlier are no longer working. Hence, I took the chance to upgraded this project to use .NET 5 together with other new libraries.

The recorded media will be saved as a MP4 file locally. The file will also be uploaded to [Microsoft Azure Storage](https://azure.microsoft.com/en-us/services/storage/) at the same time in a container named "webcam-videos", hence the user interface asks for the connection string to the Azure Storage.

The webcam that I have tested with is [Logitech HD Webcam C270](https://www.logitech.com/en-us/products/webcams/c270-hd-webcam.960-000694.html).

## Important Nuget Packages
- [DirectShowLib.Standard 2.1.0](https://www.nuget.org/packages/DirectShowLib.Standard/);
- [OpenCvSharp4 4.5.0.20201013](https://www.nuget.org/packages/OpenCvSharp4/);
- [OpenCvSharp4.runtime.win 4.5.0.20201013](https://www.nuget.org/packages/OpenCvSharp4.runtime.win/);
- [BasicAudio 2020.11.10.1](https://www.nuget.org/packages/BasicAudio/);
- [FFMpegCore 3.2.4](https://www.nuget.org/packages/FFMpegCore/);
- [Azure.Storage.Blobs 12.7.0](https://www.nuget.org/packages/Azure.Storage.Blobs/).

## References
- [How to Use a Webcam in C# with .NET Framework 4.0 and Microsoft Expression Encoder 4](https://www.codeproject.com/Articles/202464/How-to-use-a-WebCam-in-C-with-the-NET-Framework);
- [Visual Studio C# VideoCapture](https://stackoverflow.com/a/49303081/1177328);
- [Memory Leak while converting Opencv Mat to .net BitMap](https://stackoverflow.com/a/43839778/1177328);
- [memory leak with videocapture, memory goes up with the function of read(image)](https://github.com/opencv/opencv/issues/5715);
- [openCV video saving in python](https://stackoverflow.com/a/29317298/1177328);
- [EMGU CV videowriter is unable to make video](https://stackoverflow.com/a/32021413/1177328);
- [WebCam Video Recording in MPEG using C# Desktop Application](https://stackoverflow.com/questions/19366260/webcam-video-recording-in-mpeg-using-c-sharp-desktop-application);
- [GitHub: rosenbjerg/FFMpegCore](https://github.com/rosenbjerg/FFMpegCore)
- [Look at me! Windows Image Acquisition](https://channel9.msdn.com/coding4fun/articles/Look-at-me-Windows-Image-Acquisition);
- [Record audio in Windows Form C#](https://www.youtube.com/watch?v=xjcoAWHxi1A);
- [Multimedia Command Strings](https://docs.microsoft.com/en-us/previous-versions/ms712587(v=vs.85));
- [How to Install FFmpeg on Windows](http://blog.gregzaal.com/how-to-install-ffmpeg-on-windows/);
- [GitHub: BtbN/FFmpeg-Builds](https://github.com/BtbN/FFmpeg-Builds/releases);
- [Quickstart: Azure Blob storage client library v12 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet).

## License ##

This library is distributed under the GPL-3.0 License found in the [LICENSE](./LICENSE) file.