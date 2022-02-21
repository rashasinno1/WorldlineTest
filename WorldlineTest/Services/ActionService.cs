using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Services
{
    class ActionService : IActionService
    {
        private decimal balance = 0;
        private decimal totalFees = 0;
        private string balanceDescription = "";
        private string feeDescription = "";
        private string recipientDescription = "";
        public string report(string input)
        {

            string[] operations = input.Split("\\n");
            foreach (string op in operations)
            {
                //Verify REGEX op start with P,R,F or L and then has a decimal                 
                decimal value = 0;
                if (op.Length > 1) value = Decimal.Parse(op.Substring(1));

                if (op.ToUpper().StartsWith("P"))
                {
                    AdjustBalance(value);
                }
                else if (op.ToUpper().StartsWith("R"))
                {
                    AdjustBalance(-value);
                }
                else if (op.ToUpper().StartsWith("F"))
                {
                    AdjustBalance(-value);
                    AddFee(value);
                }
                else if (op.ToUpper().StartsWith("L"))
                {
                    ResetBalance();
                }
            }

            return FormatOutput();

        }
        public string FormatOutput()
        {
            string output = String.Concat(balanceDescription,
                System.Environment.NewLine,
                feeDescription,
                System.Environment.NewLine,
                recipientDescription);
            return output;
        }
        public void AdjustBalance(decimal value)
        {
            balance += value;
            balanceDescription = String.Concat("Balance: ", balance, " euros");
        }

        public void AddFee(decimal value)
        {
            totalFees += value;
            feeDescription = String.Concat("Total fees: ", totalFees, " euros");

        }
        public void ResetBalance()
        {

            recipientDescription = String.Concat("Transferred to recipient: ", balance, " euros");
            balance = 0;
        }


    }
}
