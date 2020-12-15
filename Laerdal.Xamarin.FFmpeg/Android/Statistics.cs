namespace Laerdal.Xamarin.FFmpeg
{
    public partial class Statistics
    {
        public override double Bitrate => NativeStatistics.Bitrate;
        public override long Size => NativeStatistics.Size;
        public override double Speed => NativeStatistics.Speed;
        public override int Time => NativeStatistics.Time;
        public override long ExecutionId => NativeStatistics.ExecutionId;
        public override float VideoFps => NativeStatistics.VideoFps;
        public override float VideoQuality => NativeStatistics.VideoQuality;
        public override int VideoFrameNumber => NativeStatistics.VideoFrameNumber;
        public Android.Statistics NativeStatistics { get; }
        
        public Statistics(Android.Statistics statistics)
        {
            NativeStatistics = statistics;
        }
    }
}