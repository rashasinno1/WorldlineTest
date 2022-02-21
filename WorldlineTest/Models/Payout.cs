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
        public Payout(decimal amount) : base("Payout", amount)
        {

        }
        public override string Apply(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
