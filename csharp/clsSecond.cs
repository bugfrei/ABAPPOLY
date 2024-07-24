using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class clsSecond : clsBase
    {
        protected override void Init()
        {
            this.itemtype = "SECOND";
        }
        public clsSecond(int defaultValue) : base(defaultValue)
        {
          
        }
    }
}

