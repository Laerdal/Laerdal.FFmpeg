using System;

namespace Laerdal.FFmpeg
{
    public partial class FFmpegExecution
    {
        public string Command { get; }
        public long ExecutionId { get; }
        public DateTime StartTime { get; }
    }
}