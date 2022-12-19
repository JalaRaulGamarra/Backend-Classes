using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class SniperRifle : Weapon
    {
        public bool TelescopicSight { get; set; }

        public SniperRifle(string brand, string name, string color, int weight, bool telescopicSight)
        {
            this.currentBullets = 7;
            this.needsReload = true;
            this.MagazineSize = 7;
            this.Range = 100;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = weight;
            TelescopicSight = telescopicSight;
        }

        public override void Shoot(int distanceTarget)
        {
            Console.WriteLine("      ___________");
            Console.WriteLine("PUM! |___________|>");

            if (this.Range >= distanceTarget)
            {
                Console.WriteLine("Target hit by bullet (" + " Distance target = " + distanceTarget + ")");
            }
            else
            {
                Console.WriteLine("Target missed by bullet (" + " Distance target = " + distanceTarget + ")");
            }

            this.currentBullets--;

            if (this.currentBullets > 0)
            {
                this.Reloaded();
            }
            else if (this.currentBullets == 0)
            {
                int option;
                int bullets;

                option = this.MagazineReloaded();

                if (option == 1)
                {
                    this.FullReload();
                }
                else
                {
                    Console.Write("Enter the number of bullets to reload (1-7): ");
                    bullets = Convert.ToInt32(Console.ReadLine());
                    this.CustomReload(bullets);
                }
            }
        }

        public override void FullReload()
        {
            this.currentBullets = 7;
        }
    }
}
