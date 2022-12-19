using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class MachineGun:Weapons
    {
        public MachineGun()
        {
            CurrentBullets = 20;
            Magazinesize = 20;
            Range = 16;
            Weight = 80.5;
            Accesories = "Lantern";
            NeedsReload = false;
        }
        public override void Shoot(int distance)
        {
            Console.WriteLine("Shooting");
            if (distance > Range) Console.WriteLine("Missing shot");
            else Console.WriteLine("Hit");
            Console.WriteLine("Shoots all its bullets");
            NeedsReload = true;
            Console.WriteLine("que tipo de recarga elige");

            char opt = Convert.ToChar(Console.ReadLine());
            SelectReloadType(opt);
        }
    }
}
