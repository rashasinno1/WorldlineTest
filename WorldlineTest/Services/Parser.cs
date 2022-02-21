using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;
using WorldlineTest.Models;

namespace WorldlineTest.Services
{
    public static class Parser
    {
        public static  List<Operation> ParseInput(string input)
        {
            var operations = new List<Operation>();
            string[] strOperations = input.Split("\\n");
            foreach (string op in strOperations)
            {
                //Verify REGEX op start with P,R,F or L and then has a decimal                 
                decimal value = 0;
                if (op.Length > 1) value = Decimal.Parse(op.Substring(1));

                if (op.ToUpper().StartsWith("P"))
                {
                    operations.Add(new Payment(value));
                }
                else if (op.ToUpper().StartsWith("R"))
                {
                    operations.Add(new Refund(value));
                }
                else if (op.ToUpper().StartsWith("F"))
                {
                    operations.Add(new TransactionFee(value));
                }
                else if (op.ToUpper().StartsWith("L"))
                {
                    operations.Add(new Payout());
                }
            }
            return operations;
        }
    }
}
