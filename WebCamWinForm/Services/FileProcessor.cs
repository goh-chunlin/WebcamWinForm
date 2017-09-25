using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamWinForm.Services
{
    public class FileProcessor
    {
        public static byte[] ConvertFileToBytes(string filePath)
        {
            MemoryStream mem = null;
            byte[] buffer = null;
            int bytesRead = 0;

            try
            {
                mem = new MemoryStream();
                buffer = new byte[32768];
                using (FileStream input = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    bytesRead = input.Read(buffer, 0, buffer.Length);
                    while (bytesRead > 0)
                    {
                        mem.Write(buffer, 0, bytesRead);
                        bytesRead = input.Read(buffer, 0, buffer.Length);
                    }
                }
                return mem.ToArray();
            }
            catch (Exception)
            {

            }

            return null;
        }
    }
}
