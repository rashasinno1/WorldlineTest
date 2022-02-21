
using Microsoft.Extensions.DependencyInjection;
using System;
using WorldlineTest.Interfaces;
using WorldlineTest.Services;

namespace WorldlineTest
{
    public  class Startup
    {


        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                    .AddTransient<IUIService, UIService>()
                    .AddTransient<IActionService, ActionService>()
                    .BuildServiceProvider();
            return provider;

        }
    }
}
