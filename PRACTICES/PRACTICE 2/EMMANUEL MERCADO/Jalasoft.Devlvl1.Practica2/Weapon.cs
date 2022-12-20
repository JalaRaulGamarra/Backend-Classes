using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    public class Weapon
    {
        protected int MagazineCapacity { get; set; }
        protected int Range { get; set; }
        protected int CurrentBullets { get; set; }
        protected bool NeedsToReload { get; set; }
        protected string? Brand { get; set; }
        protected string? Name { get; set; }
        protected string? Color { get; set; }
        protected double Weight { get; set; }

        public virtual void Shoot(Target target)
        {
            CurrentBullets--;

            Console.WriteLine("Weapon Shooted!...");
            if(target.Distance <= Range)
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

        public void Reload()
        {
            CurrentBullets = MagazineCapacity;
            NeedsToReload = false;
            Console.WriteLine("Magazine filled");
        }

        public void Reload(int numberOfBullets)
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
