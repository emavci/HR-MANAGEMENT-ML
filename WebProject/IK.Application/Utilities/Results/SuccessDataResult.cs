using System.Collections.Generic;

namespace IK.Application.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data, IEnumerable<object> logs) : base(data, true, logs)
        {
        }

        public SuccessDataResult(T data, IEnumerable<object> logs, string message) : base(data, true, logs, message)
        {
        }
    }
}
