using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class SniperRifle: Weapon
    {
        protected internal override int MagazineSize
        {
            get
            {
                return 7;
            }
        }
        public override double Range
        {
            get
            {
                return 100;
            }
        }
    }
}
