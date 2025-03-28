using System.Runtime.Versioning;

namespace UniXPlayerlib
{
    public class MusicPlayer
    {
        [SupportedOSPlatform("windows")]
        [SupportedOSPlatform("linux")]
        [SupportedOSPlatform("macos")]
        [SupportedOSPlatform("android")]
        public string[] SupportedFormats = { "MP3", "WAV", "FLAC", "OGG" };
        public string? CurrentSong { get; set; }
        public bool IsPlaying { get; set; }
        public TimeOnly CurrentTime { get; set; }
        public TimeOnly Duration { get; set; }
        public void Play(string song)
        {
            CurrentSong = song;
            IsPlaying = true;
        }

        public const int MaxVolume = 100;
        public const int MinVolume = 0;
        public int Volume { get; set; } = 50;

        public void VolumeUp()
        {
            if (Volume < MaxVolume)
            {
                Volume++;
            }
        }

        public void VolumeDown()
        {
            if (Volume > MinVolume)
            {
                Volume--;
            }
        }
    }
}
