using DynamicLINQConfigurations.Configurations.LinqConfigurations.Contracts;

namespace DynamicLINQConfigurations.Configurations.LinqConfigurations.Statements
{
	public class SelectStatements : ISelectStatement
	{
		public string PropertyName { get; set; }

		public string VariableName { get; set; }
	}
}
