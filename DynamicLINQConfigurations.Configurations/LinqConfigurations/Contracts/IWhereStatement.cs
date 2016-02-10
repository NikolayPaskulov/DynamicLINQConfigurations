using DynamicLINQConfigurations.Configurations.LinqConfigurations.Enums;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts
{
	public interface IWhereStatement
	{
		string PropertyName { get; set; }

		Operator Operator { get; set; }

		object Value { get; set; }

		LogicalOperator LogicalOperator { get; set; }
	}
}
