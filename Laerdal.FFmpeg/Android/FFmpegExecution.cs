using System;

namespace Laerdal.FFmpeg
{
    public partial class FFmpegExecution
    {
        public FFmpegExecution(Android.FFmpegExecution fFmpegExecution)
        {
            Command = fFmpegExecution.Command;
            ExecutionId = fFmpegExecution.ExecutionId;
            StartTime = DateToDateTime(fFmpegExecution.StartTime);
        }
        
        public DateTime DateToDateTime(Java.Util.Date date) {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(date.Time);
        }
        
    }
}