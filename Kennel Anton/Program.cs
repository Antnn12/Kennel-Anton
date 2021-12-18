using Autofac;
using System;

namespace Kennel_Anton
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
