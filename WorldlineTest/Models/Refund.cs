using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Models
{
    public class Refund : Operation
    {
        public Refund(decimal amount) : base("Refund", amount)
        {

        }
        public override void Apply(Account account)
        {
            account.balance -= _amount;// can balance be negative?
        }
    }
}
