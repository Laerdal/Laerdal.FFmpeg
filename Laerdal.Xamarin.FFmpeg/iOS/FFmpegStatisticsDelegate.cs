using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
	[Preserve (AllMembers = true)]
    public abstract partial class FFmpegStatisticsDelegate : iOS.StatisticsDelegate
    {
        public override void StatisticsCallback(iOS.Statistics statistics)
        {
            OnStatisticsReceived(new FFmpegStatistics(statistics));
        }
    }
}