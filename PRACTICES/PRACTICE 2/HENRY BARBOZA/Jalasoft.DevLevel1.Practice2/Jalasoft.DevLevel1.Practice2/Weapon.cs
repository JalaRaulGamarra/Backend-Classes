using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    public class Weapon
    {
        private protected int currentBullets { get; set; }
        private protected bool needsReload { get; set; }
        public int MagazineSize { get; private protected set; }
        public int Range { get; private protected set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }


        public virtual void Shoot(int distanceTarget)
        {
            // The weapon losses a bullet (-1);
        }

        public void Reloaded()
        {
            // SniperRifle and ShotGun
            Console.WriteLine("Recharge before firing []");
        }

        public int MagazineReloaded()
        {
            int option;
            Console.WriteLine("\nThe weapon is out of bullets, the magazine needs to be reloaded");
            Console.WriteLine("1. Full magazine");
            Console.WriteLine("2. Custom reload");
            Console.Write("Select an option: ");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        public virtual void FullReload()
        {
            // Fills the magazine with the max number of bullets
        }

        public void CustomReload(int bullets)
        {
            // Number of bullets difined by the user
            this.currentBullets += bullets;
        }
    }


}
