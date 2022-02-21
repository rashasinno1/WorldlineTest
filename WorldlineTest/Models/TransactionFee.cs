using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Models
{
    public class TransactionFee : Operation
    {
        public TransactionFee(decimal amount) : base("TransactionFee", amount)
        {

        }
        public override void Apply(Account account)
        {
            account.balance -= _amount;// can balance be negative?
            account.fees += _amount;
        }
    }
}
