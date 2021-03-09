namespace Laerdal.FFmpeg
{
    public abstract partial class FFmpegStatisticsDelegate
    {
        public abstract void OnStatisticsReceived(FFmpegStatistics fFmpegStatistics);
    }
}