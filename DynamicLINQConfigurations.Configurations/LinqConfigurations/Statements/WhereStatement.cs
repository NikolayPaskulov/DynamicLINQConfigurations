using DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts;
using DynamicLINQConfigurations.Configurations.LinqConfigurations.Enums;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations.Statements
{
	public class WhereStatement : IWhereStatement
	{
		public LogicalOperator LogicalOperator { get; set; }

		public Operator Operator { get; set; }

		public string PropertyName { get; set; }

		public object Value { get; set; }
	}
}
