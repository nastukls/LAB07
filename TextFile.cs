using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class TextFile : Fille
    {
        public string Encoding { get; set; }
        public int LineCount { get; set; }
        public bool IsReadOnly { get; set; }

        public TextFile(
            string fileName,
            long size,
            string extension,
            string encoding,
            int lineCount,
            bool isReadOnly
        ) : base(fileName, size, extension)
        {
            Encoding = encoding;
            LineCount = lineCount;
            IsReadOnly = isReadOnly;
        }

        public override void Open()
        {
            IsOpen = true;
            LastAccessDate = DateTime.Now;
            Console.WriteLine("Text file opened. Viewing text content.");
        }

        public string GetTextPreview()
        {
            return $"Text preview: {FileName}, Encoding: {Encoding}";
        }

        public int GetLineCount()
        {
            return LineCount;
        }

        public override string GetInfo()
        {
            return $"Text file: {FileName}, Size: {Size} bytes, Encoding: {Encoding}, Lines: {LineCount}, Read only: {IsReadOnly}";
        }

        public override string ToString()
        {
            return $"TextFile: Name={FileName}, Size={Size}, Extension={Extension}";
        }
    }
}
