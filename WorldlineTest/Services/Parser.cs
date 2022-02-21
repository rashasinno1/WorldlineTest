using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Interfaces;

namespace WorldlineTest.Services
{
    public class Parser
    {
        public static  List<IOperation> parseInput(string input)
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
        }
    }
}
