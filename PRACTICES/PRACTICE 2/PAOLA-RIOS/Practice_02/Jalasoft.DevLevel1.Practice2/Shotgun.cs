using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class Shotgun: Weapon
    {
        protected internal override int MagazineSize 
        {
            get
            {
                return 2;
            }
        }
        public override double Range
        {
            get
            {
                return 5;
            }
        }




    }
}
