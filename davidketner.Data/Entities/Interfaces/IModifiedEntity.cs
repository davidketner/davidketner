using System;
using System.Collections.Generic;
using System.Text;

namespace davidketner.Data.Entities.Interfaces
{
    public interface IModifiedEntity
    {
        DateTime Created { get; set; }
        DateTime? Updated { get; set; }
        DateTime? Deleted { get; set; }
        string UserCreatedId { get; set; }
        string UserUpdatedId { get; set; }
        string UserDeletedId { get; set; }
        bool Locked { get; set; }
    }
}
