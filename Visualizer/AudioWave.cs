namespace UniXPlayerlib.Visualizer
{
    internal class AudioWave
    {
        int Width { get; set; }
        int Height { get; set; }
        int[]? WaveData { get; set; }

        int[]? AudioData { get; set; }

        int AMP { get; set; }

        public AudioWave(int width, int height, int[] waveData, int amp)
        {
            Width = width;
            Height = height;
            WaveData = waveData;
            AMP = amp;
        }
    }
}
