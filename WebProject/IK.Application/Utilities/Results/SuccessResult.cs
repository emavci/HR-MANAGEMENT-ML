using System.Collections.Generic;

namespace IK.Application.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult(IEnumerable<object> logs) : base(true, logs)
        {
        }

        public SuccessResult(IEnumerable<object> logs, string message) : base(true, logs, message)
        {
        }
    }



}
