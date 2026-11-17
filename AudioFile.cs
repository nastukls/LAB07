using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class AudioFile : Fille
    {
        public TimeSpan Duration { get; set; }
        public int Bitrate { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        public AudioFile(
            string fileName,
            long size,
            string extension,
            TimeSpan duration,
            int bitrate,
            string artist,
            string album
        ) : base(fileName, size, extension)
        {
            Duration = duration;
            Bitrate = bitrate;
            Artist = artist;
            Album = album;
        }

        public override void Open()
        {
            IsOpen = true;
            LastAccessDate = DateTime.Now;
            Console.WriteLine("Audio file opened.");
        }

        public void Play()
        {
            Console.WriteLine("Playing audio file.");
        }

        public override string GetInfo()
        {
            return $"Audio file: {FileName}, Duration: {Duration}, Bitrate: {Bitrate} kbps, Artist: {Artist}, Album: {Album}";
        }

        public override string ToString()
        {
            return $"AudioFile: Name={FileName}, Size={Size}, Extension={Extension}";
        }
    }
}
