using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class VideoFile : Fille
    {
        public TimeSpan Duration { get; set; }
        public string Resolution { get; set; }
        public double FrameRate { get; set; }
        public string Codec { get; set; }

        public VideoFile(
            string fileName,
            long size,
            string extension,
            TimeSpan duration,
            string resolution,
            double frameRate,
            string codec
        ) : base(fileName, size, extension)
        {
            Duration = duration;
            Resolution = resolution;
            FrameRate = frameRate;
            Codec = codec;
        }

        public override void Open()
        {
            IsOpen = true;
            LastAccessDate = DateTime.Now;
            Console.WriteLine("Video file opened.");
        }

        public void Play()
        {
            Console.WriteLine("Playing video file.");
        }

        public override string GetInfo()
        {
            return $"Video file: {FileName}, Duration: {Duration}, Resolution: {Resolution}, Frame rate: {FrameRate}, Codec: {Codec}";
        }

        public override string ToString()
        {
            return $"VideoFile: Name={FileName}, Size={Size}, Extension={Extension}";
        }
    }
}
