using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class MachineGun : Weapon
    {
        public MachineGun()
        {
            this.magazineSize = 20;
            this.shootRange = 16;
            this.currentBullets = magazineSize;
        }

        public override void Shoot(int range)
        {
            if (this.currentBullets > 0)
            {
                Console.WriteLine("Machine Gun shoots!");
                this.HitsTarget(range);
                this.currentBullets--;
            }
            else
            {
                Console.WriteLine("can't shoot!");
            }
        }
    }
}
