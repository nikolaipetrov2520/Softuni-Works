using System;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\1", @"D:\2\ZipPic.zip");

            ZipFile.ExtractToDirectory(@"D:\2\ZipPic.zip", @"D:\3");
        }
    }
}
