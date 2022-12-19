using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class MachineGun : Weapon
    {
        protected internal override int MagazineSize
        {
            get
            {
                return 20;
            }
        }
        public override void Shoot()
        {
            while (CurrentBullet > 0)
            {
                Console.WriteLine("Taaa  ");
                CurrentBullet--;
            }
            Console.WriteLine("The Bullets ran out");
        }
        public override double Range
        {
            get
            {
                return 16;
            }
        }
    }
}
