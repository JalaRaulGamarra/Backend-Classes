using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    public class Shotgun : Weapon, IRechargeableWeapon
    {
        private byte recharged = 1;
        public bool HasLantern { get; set; }
        public Shotgun()
        {
            this.magazineSize = 2;
            this.shootRange= 5;
            this.currentBullets= magazineSize;
        }

        public void Recharge()
        {
            Console.WriteLine("Recharge Shotgun");
            this.recharged = 1;
        }

        public override void Shoot(int range)
        {
            if (this.currentBullets > 0 && this.recharged == 1)
            {
                Console.WriteLine("Shotgun Shoots!");
                this.HitsTarget(range);
                this.currentBullets--;
                this.recharged = 0;
            }
            else
            {
                Console.WriteLine("can't shoot!");
            }
        }
    }
}
