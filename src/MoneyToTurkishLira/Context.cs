using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyToTurkishLira
{
    public class Context
    {
        public string Formula;
        public int Index;
        public Context(string _formula, int _index)
        {
            Formula = _formula;
            Index = _index;
        }
    }
}
