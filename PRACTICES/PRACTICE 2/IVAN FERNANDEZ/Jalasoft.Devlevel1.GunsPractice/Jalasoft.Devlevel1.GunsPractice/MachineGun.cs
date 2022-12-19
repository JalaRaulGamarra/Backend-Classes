using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.GunsPractice
{
    internal class MachineGun : Weapon
    {
        public MachineGun(string brand, string name, string color, double weight)
        {
            this.brand = brand;
            this.name = name;
            this.color = color;
            this.weight = weight;
            this.currentBullets = 0;
            efectiveRange = 16;    // distance
            magazineSize = 20;
            needsReload = true;
        }
        public override void shootATarget(int objetiveDistance)
        {
            if (currentBullets > 0 || !needsReload)
            {
                while (currentBullets > 0)
                {
                    currentBullets--;
                }
                if (objetiveDistance <= efectiveRange) Console.WriteLine("PRUM! The Target was hit!");
                else Console.WriteLine("PRUM! The Target was not hit");
            }
            else{
                Console.WriteLine("The Machine Gun Magazine needs to reload");
                needsReload = true;
            }
            if (currentBullets == 0) needsReload = true;
        }
        public override void reloadMagazine()
        {
            if (currentBullets == magazineSize) Console.WriteLine("The weapon is already fully loaded");
            else
            {
                currentBullets = magazineSize;
                needsReload = false;
                Console.WriteLine("The Machine Gun was fully loaded");
            }
        }
        public override void reloadMagazine(int numberOfBullets)
        {
            if (currentBullets == magazineSize) Console.WriteLine("The weapon is already fully loaded");
            else if ((numberOfBullets + currentBullets) > magazineSize)
            {
                Console.WriteLine("You cannot load more than the Machine Gun magazine supports");
            }
            else
            {
                currentBullets += numberOfBullets;
                Console.WriteLine("The Machine gun was custom loaded");
            }
            if (currentBullets > 0) needsReload = false;
        }
    }
}

