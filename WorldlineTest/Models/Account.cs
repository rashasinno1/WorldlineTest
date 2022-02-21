using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Models
{
    public class Account
    {
        public  decimal balance;
        public  decimal fees;
        public  decimal transfers;
        public readonly List<Operation> operationsPerformed;
        public void PerformOperation(Operation operation)
        {
            operation.Apply(this);
            operationsPerformed.Add(operation);
        }

        public string LogOperations()
        {
            string logAuditor = "";
            foreach (Operation op in operationsPerformed)
            {
                logAuditor += op.ToString() + Environment.NewLine;
            }

            return logAuditor;
        }
    
        public override string ToString()
        {
            return String.Concat("Balance: ", balance, Environment.NewLine,
                "Total fees: ", fees, Environment.NewLine,
                "Transferred to recipient: ", transfers, Environment.NewLine);
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
    }
}
