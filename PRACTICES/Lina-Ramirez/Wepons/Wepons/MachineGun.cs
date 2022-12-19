using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class MachineGun: Weapon
    {
        public MachineGun()
        {
            this.MagazineSize = 20;
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
        public void Range()
        {
            Random rnd = new Random();
            int distancia = rnd.Next(1, MagazineSize);

            if (distancia <= Range) 
            {
                Console.WriteLine($"The distance is {distancia}. Objective achieved");
            }
            else
            {
                Console.WriteLine($"The distance is {distancia}. Target missed");
            }

        }
    }
}
