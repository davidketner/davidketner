using System;
using System.Collections.Generic;
using System.Text;

namespace davidketner.Data.Utils
{
    public class Result<T> : IResult<T>
    {
        public T Obj { get; set; }
        public bool IsOK => Errors.Count == 0;

        private ICollection<string> errors;
        public virtual ICollection<string> Errors
        {
            get { return errors ?? (errors = new HashSet<string>()); }
            set { errors = value; }
        }
        public string Message => !IsOK ? string.Join(", ", Errors) : "";
    }
}
