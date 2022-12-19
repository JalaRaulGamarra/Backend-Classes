using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class ChargerSniperRifle
    {
        public int NumberOfBullet { get; set; }

        public int MaxNumberOfBulletSniperRifle = 7;

        public ChargerSniperRifle (int numberbullet, int maxNumberOfBullet)
        {
            NumberOfBullet = numberbullet;

            MaxNumberOfBulletSniperRifle = maxNumberOfBullet;

        }
        public void ChargerFull()
        {
            if (MaxNumberOfBulletSniperRifle == NumberOfBullet)
            {
                Console.WriteLine("Charger full");
            }
        }
    }
}
