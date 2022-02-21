using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Services
{
    class UIService : IUIService
    {

        private readonly IActionService mActionService;
        public UIService(IActionService actionService)
        {
            this.mActionService = actionService;
        }
        public string input()
        {
            Console.WriteLine("Enter your command:");
            string input = Console.ReadLine();
            return mActionService.report(input);

        }

        public string output(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Exit  program (Y/N)?");

            return Console.ReadLine();

        }
    }
}
