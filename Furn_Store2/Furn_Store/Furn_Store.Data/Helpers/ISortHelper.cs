using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furn_Store.Data.Helpers
{
    public interface ISortHepler<T>
    {
        IQueryable<T> ApplySort(IQueryable<T> entities, QueryStringParameters orderByQueryString);
    }
}
