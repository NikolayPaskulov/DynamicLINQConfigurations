using DynamicLINQConfigurations.Configurations.LinqConfigurations.Enums;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts
{
	public interface IOrderByStatement
	{
		string PropertyName { get; set; }
		OrderDirection Direction { get; set; }
	}
}
