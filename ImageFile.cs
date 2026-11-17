using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class ImageFile : Fille
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int ColorDepth { get; set; }
        public string Format { get; set; }

        public ImageFile(
            string fileName,
            long size,
            string extension,
            int width,
            int height,
            int colorDepth,
            string format
        ) : base(fileName, size, extension)
        {
            Width = width;
            Height = height;
            ColorDepth = colorDepth;
            Format = format;
        }

        public override void Open()
        {
            IsOpen = true;
            LastAccessDate = DateTime.Now;
            Console.WriteLine("Image opened. Viewing image.");
        }

        public string GetResolution()
        {
            return $"{Width}x{Height}";
        }

        public string GetSize()
        {
            return $"{Width * Height} pixels";
        }

        public override string GetInfo()
        {
            return $"Image file: {FileName}, Resolution: {GetResolution()}, Color depth: {ColorDepth}, Format: {Format}";
        }

        public override string ToString()
        {
            return $"ImageFile: Name={FileName}, Size={Size}, Extension={Extension}";
        }
    }
}
