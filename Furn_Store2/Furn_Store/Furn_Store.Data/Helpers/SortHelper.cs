using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace Furn_Store.Data.Helpers
{
	public class SortHelper<T> : ISortHepler<T>
	{
		public IQueryable<T> ApplySort(IQueryable<T> entities, QueryStringParameters orderByQueryString)
		{
			if (!entities.Any())
				return entities;

			if (string.IsNullOrWhiteSpace(orderByQueryString.OrderBy))
			{
				return entities;
			}

			var orderParams = orderByQueryString.OrderBy.Trim().Split(',');
			var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			var orderQueryBuilder = new StringBuilder();

			foreach (var param in orderParams)
			{
				if (string.IsNullOrWhiteSpace(param))
					continue;

				var propertyFromQueryName = param.Split(" ")[0];
				var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

				if (objectProperty == null)
					continue;

				var sortingOrder = param.EndsWith(" desc") ? "descending" : "ascending";

				orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {sortingOrder}, ");
			}

			var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

			return entities.OrderBy(orderQuery);
		}
	}
}
