
using Microsoft.Extensions.DependencyInjection;
using System;
using WorldlineTest.Interfaces;
using WorldlineTest.Models;
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
                    .AddTransient<Account>()//new account at each iteration? to be changed upon specs
                    .BuildServiceProvider();
            return provider;

        }
    }
}
