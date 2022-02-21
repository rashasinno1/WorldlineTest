using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldlineTest.Models;

namespace WorldlineTest.Interfaces
{
    public interface IOperation
    {
        public string Apply(Account account);
        
    }
}
