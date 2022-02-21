using Microsoft.Extensions.DependencyInjection;
using System;
using WorldlineTest.Interfaces;

namespace WorldlineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = Startup.ConfigureService();
                while (true)
                {
                    var UIService = container.GetRequiredService<IUIService>();
                    string result = UIService.input();
                    string output = UIService.output(result);
                    if (!String.IsNullOrEmpty(output) && output.ToUpper().Equals("Y")) break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
