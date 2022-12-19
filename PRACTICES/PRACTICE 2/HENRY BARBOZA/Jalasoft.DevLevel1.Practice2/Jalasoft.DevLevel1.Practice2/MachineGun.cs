using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class MachineGun : Weapon
    {
        public bool Lantern { get; set; }

        public MachineGun(string brand, string name, string color, int weight, bool lantern)
        {
            this.currentBullets = 20;
            this.needsReload = false;
            this.MagazineSize = 20;
            this.Range = 16;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = weight;
            Lantern = lantern;
        }

        public override void Shoot(int distanceTarget)
        {
            Console.WriteLine("      _____");
            Console.WriteLine("PUM! |_____|>");

            if (this.Range >= distanceTarget)
            {
                Console.WriteLine("Target hit by bullet (" + " Distance target = " + distanceTarget + ")");
            }
            else
            {
                Console.WriteLine("Target missed by bullet (" + " Distance target = " + distanceTarget + ")");
            }

            this.currentBullets--;

            if (this.currentBullets == 0)
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
                    Console.Write("Enter the number of bullets to reload (1-20): ");
                    bullets = Convert.ToInt32(Console.ReadLine());
                    this.CustomReload(bullets);
                }
            }

        }

        public override void FullReload()
        {
            this.currentBullets = 20;
        }
    }
}
