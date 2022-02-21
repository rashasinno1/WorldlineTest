using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldlineTest.Models
{
    public class Account
    {
        public decimal balance { get; private set; }
        public decimal fees { get; private set; }
        public decimal transfers { get; private set; }
        public void performOperation(IOperation operation)
        {
            operation.Apply(this);
            
        }
        //public void ReceivePayment(decimal amount)
        //{
        //    balance += amount;
        //}
        //public void RefundPayment(decimal amount)
        //{
        //    balance -= amount;
        //}
        //public void PayFees(decimal amount)
        //{
        //    balance -= amount;
        //    fees += amount;
        //}
        //public void Transfer()
        //{
        //    transfers += balance;
        //    balance -= balance;          
        //}
        public override string ToString()
        {
            return String.Concat("Balance: ", balance, Environment.NewLine,
                "Total fees: ", fees, Environment.NewLine,
                "Transferred to recipient: ", transfers);
        }

    }
}
