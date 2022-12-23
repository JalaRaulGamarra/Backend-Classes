using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class ChargerMachineGun
    {
        public int NumberOfBullet { get; set; }

        public int MaxNumberOfBulletMachineGun = 20;

        public ChargerMachineGun(int numberbullet, int maxNumberOfBullet)
        {
            NumberOfBullet = numberbullet;

            MaxNumberOfBulletMachineGun = maxNumberOfBullet;

        }
        public void ChargerFull()
        {
            if (MaxNumberOfBulletMachineGun == NumberOfBullet)
            {
                Console.WriteLine("Charger full");
            }
        }
    }
}
