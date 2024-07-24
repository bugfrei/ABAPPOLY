using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public class clsFirst : clsBase
    {
        protected override void Init()
        {
            this.itemtype = "FIRST";
        }
        public clsFirst(int defaultValue) : base(defaultValue)
        {
          
        }
    }
}

