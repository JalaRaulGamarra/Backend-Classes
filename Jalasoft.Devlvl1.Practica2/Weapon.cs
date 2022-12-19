using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    protected class Weapon
    {
        protected int MagazineCapacity { get; set; }
        protected int Range { get; set; }
        protected int CurrentBullets { get; set; }
        protected bool NeedsToReload { get; set; }
        protected string? Brand { get; set; }
        protected string? Name { get; set; }
        protected string? Color { get; set; }
        protected double Weight { get; set; }

        protected virtual void Shoot(Target)
        {
            CurrentBullets--;

            Console.WriteLine("Weapon Shooted!...");
            if(Target.Distance <= Range)
            {
                Console.WriteLine("Target reached");
            }
            else
            {
                Console.WriteLine("Target missed");
            }

            if(CurrentBullets == 0)
            {
                NeedsToReload= true;
            }
        }

        protected void Reload()
        {
            CurrentBullets = MagazineCapacity;
            NeedsToReload = false;
            Console.WriteLine("Magazine filled");
        }

        protected void Reload(int numberOfBullets)
        {
            if(numberOfBullets <= MagazineCapacity - CurrentBullets)
            {
                CurrentBullets += numberOfBullets;
                Console.WriteLine("Bullets added!");
            }
            else
            {
                Console.WriteLine("You want to add too much bullets");
            }
        }
    }
}
