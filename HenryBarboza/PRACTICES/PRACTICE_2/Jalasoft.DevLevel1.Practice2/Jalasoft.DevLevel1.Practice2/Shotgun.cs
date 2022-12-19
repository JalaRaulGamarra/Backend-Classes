using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class Shotgun : Weapon
    {
        public bool Lantern { get; set; }

        public Shotgun(string brand, string name, string color, int weight, bool lantern)
        {
            this.currentBullets = 2;
            this.needsReload = true;
            this.MagazineSize = 2;
            this.Range = 5;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = weight;
            Lantern = lantern;
        }

        public override void Shoot(int distanceTarget)
        {
            Console.WriteLine("       ___");
            Console.WriteLine("PUM!  |___|>");

            if (this.Range >= distanceTarget)
            {
                Console.WriteLine("Target hit by bullet (" + " Distance target = " + distanceTarget+")");
            } else 
            {
                Console.WriteLine("Target missed by bullet (" + " Distance target = " + distanceTarget + ")");
            }

            this.currentBullets--;

            if (this.currentBullets > 0) 
            { 
                this.Reloaded();
            }
            else if(this.currentBullets == 0)
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
                    Console.Write("Enter the number of bullets to reload (1-2): ");
                    bullets = Convert.ToInt32(Console.ReadLine());
                    this.CustomReload(bullets);
                }
            }
        }

        public override void FullReload()
        {
            this.currentBullets = 2;
        }
    }
}
