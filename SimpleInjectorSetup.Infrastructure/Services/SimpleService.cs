using SimpleInjectorSetup.Core.Repositories;
using SimpleInjectorSetup.Core.Services;

namespace SimpleInjectorSetup.Infrastructure.Services
{
	public class SimpleService : ISimpleService
	{
		private readonly ISimpleRepository _simpleRepository;

		public SimpleService(ISimpleRepository simpleRepository)
		{
			_simpleRepository = simpleRepository;
		}

		public string GetSimpleMessage()
		{
			return _simpleRepository.GetSimpleMessage();
		}
	}
}
