namespace Laerdal.Xamarin.FFmpeg
{
    public abstract partial class StatisticsDelegate : iOS.StatisticsDelegate
    {
        public override void StatisticsCallback(iOS.Statistics statistics)
        {
            OnStatisticsReceived(new Statistics(statistics));
        }
    }
}