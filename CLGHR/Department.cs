using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLGHR
{
    class Department
    {
        public string Code = null;
        public string Name = null;
        public int Population = 0;

        public override string ToString()
        {
            return (!string.IsNullOrEmpty(this.Code) ? this.Code.Trim() + " - " : "") + this.Name + " (" + this.Population.ToString() + ")";
        }
    }
}
