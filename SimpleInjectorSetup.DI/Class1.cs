using System.Linq;
using System.Reflection;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace SimpleInjectorSetup.DI
{
    public class PrimaryPackage : IPackage
    {
	    public void RegisterServices(Container container)
	    {

			var registrations = 
				from type in Assembly.Load("SimpleInjectorSetup.Infrastructure").GetExportedTypes()
				where type.GetInterfaces().Any()
				select new { Service = type.GetInterfaces().Single(), Implementation = type };

			foreach (var assembly in registrations)
		    {
			    container.Register(assembly.Service, assembly.Implementation, Lifestyle.Scoped);
		    }

	    }
    }
}
