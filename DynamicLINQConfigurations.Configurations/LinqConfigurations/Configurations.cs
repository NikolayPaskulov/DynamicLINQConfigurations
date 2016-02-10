using System;
using System.Collections.Generic;
using DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations
{
	public class Configurations : IConfiguration
	{
		public Configurations()
		{
			DynamicModelConfigurations = new HashSet<IDynamicModelConfiguration>();
		}

		public ICollection<IDynamicModelConfiguration> DynamicModelConfigurations { get; set; }
	}
}
