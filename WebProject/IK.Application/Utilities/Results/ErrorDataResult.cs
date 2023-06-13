using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //public ErrorDataResult(T data, string message) : base(data, false, message)
        //{
        //}

        //public ErrorDataResult(T data, IEnumerable<object> logs) : base(data, false, logs)
        //{
        //}

        //public ErrorDataResult(T data, IEnumerable<object> logs, string message) : base(data, false, logs, message)
        //{
        //}



    }
}
