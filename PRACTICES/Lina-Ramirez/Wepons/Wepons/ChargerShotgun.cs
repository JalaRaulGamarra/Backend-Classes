using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class ChargerShotgun
    {
        public int NumberOfBullet { get; set; }

        public int MaxNumberOfBulletShotgun = 2;

        public ChargerShotgun(int numberbullet, int maxNumberOfBullet)
        {
            NumberOfBullet = numberbullet;

            MaxNumberOfBulletShotgun = maxNumberOfBullet;

        }
        public void ChargerFull()
        {
            if (MaxNumberOfBulletShotgun == NumberOfBullet)
            {
                Console.WriteLine("Charger full");
            }
        }
    }
}
