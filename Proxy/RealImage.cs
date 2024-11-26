namespace Proxy
{
    using System;

    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {_fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }

}
