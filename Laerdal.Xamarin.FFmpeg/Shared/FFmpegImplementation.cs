using System.Collections.Generic;

namespace Laerdal.Xamarin.FFmpeg
{
    internal abstract class BaseFFmpegImplementation
    {
        /// <summary>
        /// Global library version
        /// </summary>
        public abstract string Version { get; }

        /// <summary>
        /// Synchronously executes FFmpeg command provided. Space character is used to split command into arguments.
        /// </summary>
        /// <param name="arguments">FFmpeg command</param>
        /// <returns>zero on successful execution, 255 on user cancel and non-zero on error</returns>
        public abstract int Execute(string arguments);
        
        /// <summary>
        /// Synchronously executes FFmpeg with arguments provided.
        /// </summary>
        /// <param name="arguments">FFmpeg command options/arguments as string array</param>
        /// <returns>zero on successful execution, 255 on user cancel and non-zero on error</returns>
        public abstract int Execute(string[] arguments);

        /// <summary>
        /// Cancels an ongoing operation.
        /// This function does not wait for termination to complete and returns immediately.
        /// </summary>
        /// <param name="executionId">execution id</param>
        public abstract void Cancel(long executionId);

        /// <summary>
        /// Lists ongoing executions.
        /// </summary>
        /// <returns>list of ongoing executions</returns>
        public abstract IEnumerable<FFmpegExecution> ListExecutions();
    }
    
    internal partial class FFmpegImplementation : BaseFFmpegImplementation
    {
    }
}