using System.Collections.Generic;

namespace IK.Application.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
        IEnumerable<object> Logs { get; }
    }
}
