using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Develevel1.Practice2.MiguelRamirez
{
    public class Weapon
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int MagazineSize { get; set; }

        public string Color { get; set; }
        public int Range { get; set; }

        public bool NeedsReload { get; set; }
        public int CurrentBullets { get; set; }

        public double Weigth { get; set; }
        public virtual void Shoot()
        {

            if (!NeedsReload && CurrentBullets > 0)
            {
                Console.WriteLine("Shooting ...");
                CurrentBullets--;
            }
            else
            {
                Console.WriteLine("No bullets in the Magazine...");
                NeedsReload = true;
            }
        }

        public void ReloadingMagazine()
        {
            Console.WriteLine("Reloading the magazine charging ...");
            NeedsReload = false;
            CurrentBullets = MagazineSize;
        }

        public void ReloadingMagazine(int bullets)
        {
            Console.WriteLine("Reloading the magazine charging ...");
            NeedsReload = false;
            CurrentBullets = bullets;
        }

        public bool IsWithinRange(int distance)
        {
            return distance <= Range;
        }
    }
}
