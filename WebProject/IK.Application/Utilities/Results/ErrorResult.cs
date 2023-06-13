using System.Collections.Generic;

namespace IK.Application.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult(IEnumerable<object> logs) : base(false, logs)
        {
        }

        public ErrorResult(IEnumerable<object> logs, string message) : base(false, logs, message)
        {
        }
    }



}
