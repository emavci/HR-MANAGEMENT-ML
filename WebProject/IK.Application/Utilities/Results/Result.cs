using System.Collections.Generic;

namespace IK.Application.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, IEnumerable<object> logs, string message)
        {
            Success = success;
            Message = message;
            Logs = logs;
        }

        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public Result(bool success, IEnumerable<object> logs)
        {
            Success = success;
            Logs = logs;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public IEnumerable<object> Logs { get; }
    }



}
