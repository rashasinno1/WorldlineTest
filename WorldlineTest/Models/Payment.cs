using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Models
{
    public class Payment : Operation
    {

        public Payment( decimal amount): base("Payment",amount)
        {
            
        }
        public override string Apply(Account account)
        {
            throw new NotImplementedException();
        }

      

    }
}
