using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Models
{
    public class Payout : Operation
    {
        public Payout() : base("Payout", 0)
        {

        }
        public override void Apply(Account account)
        {
            account.transfers += account.balance;
            account.balance = 0;
        }
    }
}
