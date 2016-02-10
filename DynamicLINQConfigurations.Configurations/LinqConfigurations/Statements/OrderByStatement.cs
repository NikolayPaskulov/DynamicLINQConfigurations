﻿using DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts;
using DynamicLINQConfigurations.Configurations.LinqConfigurations.Enums;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations.Statements
{
	public class OrderByStatement : IOrderByStatement
	{
		public OrderDirection Direction { get; set; }

		public string PropertyName { get; set; }
	}
}
