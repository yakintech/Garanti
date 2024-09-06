using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Models
{
    public class RealImage : IImage
    {
        private string _fileName;


        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk(fileName);
        }


        private void LoadImageFromDisk(string fileName)
        {
            Console.WriteLine($"Loading image: {fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }
}
