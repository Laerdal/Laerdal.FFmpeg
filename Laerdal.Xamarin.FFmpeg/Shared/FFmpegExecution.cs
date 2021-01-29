using System;

namespace Laerdal.Xamarin.FFmpeg
{
    public partial class FFmpegExecution
    {
        public string Command { get; }
        public long ExecutionId { get; }
        public DateTime StartTime { get; }
    }
}