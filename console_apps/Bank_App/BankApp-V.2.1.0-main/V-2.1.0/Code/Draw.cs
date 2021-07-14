using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Draw
    {
        public decimal DrawAmount { get; private set; }
        public DateTime DrawTime { get; }

        public Draw (decimal drawAmount , DateTime drawTime)
        {
            this.DrawAmount = drawAmount;
            this.DrawTime = drawTime;
        }
    }
}
