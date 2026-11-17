using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Fille
    {
        public string FileName { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastAccessDate { get; set; }
        public bool IsOpen { get; set; }

        public Fille(
            string fileName,
            long size,
            string extension
        )
        {
            FileName = fileName;
            Size = size;
            Extension = extension;
            CreationDate = DateTime.Now;
            LastAccessDate = DateTime.Now;
            IsOpen = false;
        }

        public virtual void Open()
        {
            IsOpen = true;
            LastAccessDate = DateTime.Now;
            Console.WriteLine("File opened.");
        }

        public virtual void Close()
        {
            IsOpen = false;
            Console.WriteLine("File closed.");
        }

        public virtual string GetInfo()
        {
            return $"Name: {FileName}, Size: {Size} bytes, Extension: {Extension}";
        }

        public override string ToString()
        {
            return $"File: Name={FileName}, Size={Size}, Extension={Extension}";
        }
    }
}
