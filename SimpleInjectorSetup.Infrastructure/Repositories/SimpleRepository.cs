using SimpleInjectorSetup.Core.Repositories;

namespace SimpleInjectorSetup.Infrastructure.Repositories
{
	public class SimpleRepository : ISimpleRepository
	{
		public string GetSimpleMessage()
		{
			return "This is my simple message";
		}
	}
}
