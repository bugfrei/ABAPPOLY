using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    public abstract class clsBase
    {
        protected string itemtype;
        protected int defaultValue;
        protected virtual void Init()
        {
            this.itemtype = "BASE";
        }

        public string getType() { return this.itemtype; }
        public int getDefaultValue() { return this.defaultValue; }
        public clsBase(int defaultValue)
        {
            this.defaultValue = defaultValue;
            Init();
        }

    }
}

