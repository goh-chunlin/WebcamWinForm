# WebcamWinForm
A simple Windows Form application to demonstrate how to record video and audio via a Logitech webcam using C#.

## Objective
Inspired by ["How to use a web cam in C# with .NET Framework 4.0 and Microsoft Expression Encoder 4", a project on Code Project by Italian software developer Massimo Conti](https://www.codeproject.com/Articles/202464/How-to-use-a-WebCam-in-C-with-the-NET-Framework), I built a simple demo to show how we can connect C# Windows Form with a webcam to record both video and audio.

The recorded media will be saved as a MP4 file locally. The file will also be uploaded to [Microsoft Azure Storage](https://azure.microsoft.com/en-us/services/storage/) at the same time in a container named "webcam-videos", hence the user interface asks for the connection string to the Azure Storage.

The webcam that I have tested with is [Logitech HD Webcam C525](http://www.logitech.com/en-hk/product/hd-webcam-c525).

## Important Nuget Packages
- [Microsoft.Expression.Encoder 4.0.4276.3](https://www.nuget.org/packages/Microsoft.Expression.Encoder/)
- [WindowsAzure.Storage 8.4.0](https://www.nuget.org/packages/WindowsAzure.Storage/)

## Reference
- [How to Use a Webcam in C# with .NET Framework 4.0 and Microsoft Expression Encoder 4](https://www.codeproject.com/Articles/202464/How-to-use-a-WebCam-in-C-with-the-NET-Framework)
