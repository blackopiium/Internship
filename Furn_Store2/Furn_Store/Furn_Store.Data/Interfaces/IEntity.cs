using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
