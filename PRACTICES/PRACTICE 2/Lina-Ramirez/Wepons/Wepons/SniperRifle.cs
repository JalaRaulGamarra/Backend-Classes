using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class SniperRifle: Weapon
    {
        public SniperRifle()
        {
            this.CurrentBullets = 7;
            this.Weight = Weight;
        }
        public virtual void Fire()
        {
            if (CurrentBullets > 0)
            {
                Console.WriteLine("");
                CurrentBullets--;
                Recharge();
            }
            else
                Console.WriteLine("Wait minute");
        }
    }
}
