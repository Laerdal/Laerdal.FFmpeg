using System;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
	[Preserve (AllMembers = true)]
    public partial class FFmpegExecution
    {
        public FFmpegExecution(iOS.FFmpegExecution fFmpegExecution)
        {
            Command = fFmpegExecution.Command;
            ExecutionId = fFmpegExecution.ExecutionId;
            StartTime = NsDateToDateTime(fFmpegExecution.StartTime);
        }
        
        public DateTime NsDateToDateTime(Foundation.NSDate nsDate) {
            return new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(nsDate.SecondsSinceReferenceDate);
        }
    }
}