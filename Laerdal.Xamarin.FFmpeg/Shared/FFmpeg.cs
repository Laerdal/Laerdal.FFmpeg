using System;
using System.Collections.Generic;
using System.Linq;

namespace Laerdal.Xamarin.FFmpeg
{
    public static class FFmpeg
    {
        private static FFmpegImplementation FFmpegImplementation { get; } = new FFmpegImplementation();

        /// <summary>
        /// Global library version
        /// </summary>
        public static string Version => FFmpegImplementation.Version;
        
        /// <summary>
        /// Synchronously executes FFmpeg command provided. Space character is used to split command into arguments.
        /// </summary>
        /// <param name="arguments">FFmpeg command</param>
        /// <returns>zero on successful execution, 255 on user cancel and non-zero on error</returns>
        public static int Execute(string arguments) => FFmpegImplementation.Execute(arguments);
        
        /// <summary>
        /// Synchronously executes FFmpeg with arguments provided.
        /// </summary>
        /// <param name="arguments">FFmpeg command options/arguments as string array</param>
        /// <returns>zero on successful execution, 255 on user cancel and non-zero on error</returns>
        public static int Execute(string[] arguments) => FFmpegImplementation.Execute(arguments);

        /// <summary>
        /// Cancels an ongoing operation.
        /// This function does not wait for termination to complete and returns immediately.
        /// </summary>
        /// <param name="executionId">execution id</param>
        public static void Cancel(long executionId) => FFmpegImplementation.Cancel(executionId);

        /// <summary>
        /// Lists ongoing executions.
        /// </summary>
        /// <returns>list of ongoing executions</returns>
        public static IEnumerable<FFmpegExecution> ListExecutions() => FFmpegImplementation.ListExecutions();
    }
}