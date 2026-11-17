
using System;
using LAB07;

Fille f1 = new TextFile(
    "Report.txt", 350, ".txt",
    "UTF-8", 50, false
);

Console.WriteLine(f1);
Console.WriteLine(f1.GetInfo());
f1.Open();
f1.Close();

TextFile t1 = new TextFile(
    "Document.txt", 120, ".txt",
    "UTF-8", 25, false
);

Console.WriteLine(t1);
Console.WriteLine(t1.GetTextPreview());
Console.WriteLine(t1.GetLineCount());

TextFile t2 = new TextFile(
    "Notes.docx", 250, ".docx",
    "Unicode", 40, true
);

Console.WriteLine(t2);
Console.WriteLine(t2.GetInfo());

AudioFile a1 = new AudioFile(
    "Music.mp3", 5000, ".mp3",
    TimeSpan.FromMinutes(3), 320,
    "Artist One", "Album One"
);

Console.WriteLine(a1);
Console.WriteLine(a1.GetInfo());
a1.Open();
a1.Play();
a1.Close();

AudioFile a2 = new AudioFile(
    "Song.wav", 8000, ".wav",
    TimeSpan.FromMinutes(4), 256,
    "Artist Two", "Album Two"
);

Console.WriteLine(a2);
Console.WriteLine(a2.GetInfo());

VideoFile v1 = new VideoFile(
    "Movie.mp4", 150000, ".mp4",
    TimeSpan.FromMinutes(120), "1920x1080",
    30, "H.264"
);

Console.WriteLine(v1);
Console.WriteLine(v1.GetInfo());
v1.Open();
v1.Play();
v1.Close();

VideoFile v2 = new VideoFile(
    "Clip.avi", 90000, ".avi",
    TimeSpan.FromMinutes(15), "1280x720",
    25, "Xvid"
);

Console.WriteLine(v2);
Console.WriteLine(v2.GetInfo());

ImageFile i1 = new ImageFile(
    "Photo.jpg", 2500, ".jpg",
    1920, 1080, 24, "JPEG"
);

Console.WriteLine(i1);
Console.WriteLine(i1.GetInfo());
i1.Open();
i1.Close();

ImageFile i2 = new ImageFile(
    "Picture.png", 3500, ".png",
    1280, 720, 32, "PNG"
);

Console.WriteLine(i2);
Console.WriteLine(i2.GetResolution());
Console.WriteLine(i2.GetSize());

ImageFile i3 = new ImageFile(
    "Landscape.bmp", 6000, ".bmp",
    800, 600, 24, "BMP"
);

Console.WriteLine(i3);
Console.WriteLine(i3.GetInfo());

Fille[] files = { f1, t1, t2, a1, a2, v1, v2, i1, i2, i3 };

Console.WriteLine();
Console.WriteLine("All files:");

foreach (Fille file in files)
{
    Console.WriteLine(file);
    Console.WriteLine(file.GetInfo());
}

long totalVideoSize = 0;

foreach (Fille file in files)
{
    if (file is VideoFile)
    {
        totalVideoSize += file.Size;
    }
}

Console.WriteLine();
Console.WriteLine($"Total size of video files: {totalVideoSize} bytes");

files[0].CreationDate = new DateTime(2022, 5, 10);
files[1].CreationDate = new DateTime(2023, 3, 15);
files[2].CreationDate = new DateTime(2021, 8, 20);
files[3].CreationDate = new DateTime(2024, 1, 12);
files[4].CreationDate = new DateTime(2020, 6, 5);
files[5].CreationDate = new DateTime(2019, 4, 18);
files[6].CreationDate = new DateTime(2022, 9, 25);
files[7].CreationDate = new DateTime(2023, 7, 11);
files[8].CreationDate = new DateTime(2021, 2, 14);
files[9].CreationDate = new DateTime(2024, 5, 30);

Fille oldestFile = files[0];

foreach (Fille file in files)
{
    if (file.CreationDate < oldestFile.CreationDate)
    {
        oldestFile = file;
    }
}

Console.WriteLine();
Console.WriteLine($"Oldest file: {oldestFile.FileName}");
Console.WriteLine($"Creation date: {oldestFile.CreationDate}");

