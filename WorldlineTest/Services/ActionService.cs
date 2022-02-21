using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;
using WorldlineTest.Models;

namespace WorldlineTest.Services
{
    class ActionService : IActionService
    {
        private readonly Account _account;

        public ActionService(Account account)
        {
            _account = account;
        }
        
        public string Report(string input)
        {
            var operations = Parser.ParseInput(input);
            foreach (Operation op in operations)
            {
                op.Apply(_account);
            }

            return _account.ToString();
        }

    }
}
