using System;
using System.Collections.Generic;
using System.Text;

namespace davidketner.Data.Utils
{
    public interface IResult<T> : IResult
    {
        T Obj { get; set; }
    }

    public interface IResult
    {
        bool IsOK { get; }
        string Message { get; }
        ICollection<string> Errors { get; }
    }
}
