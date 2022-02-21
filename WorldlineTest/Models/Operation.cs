using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Models;

namespace WorldlineTest.Models
{
    public abstract class Operation
    {
        private readonly string _type;
        private readonly decimal _amount;
        public abstract string Apply(Account account);
        public Operation(string type , decimal amount)
        {
            _type = type;
            _amount = amount;
        }
        public override string ToString()
        {
            return $"Type {_type} , Amount {_amount}";
        }

    }
}
