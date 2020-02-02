using davidketner.Data.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace davidketner.Data.Entities
{
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string UserCreatedId { get; set; }
        public string UserUpdatedId { get; set; }
        public string UserDeletedId { get; set; }
        public bool Locked { get; set; }
    }
}
