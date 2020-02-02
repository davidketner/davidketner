using System;
using System.Collections.Generic;
using System.Text;

namespace davidketner.Data.Entities.Interfaces
{
    public interface IBaseEntity<T> : IModifiedEntity
    {
        T Id { get; set; }
    }
}
