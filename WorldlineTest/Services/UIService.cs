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
            return null;
        }

        public string output(string message)
        {
            return null;

        }
    }
}
