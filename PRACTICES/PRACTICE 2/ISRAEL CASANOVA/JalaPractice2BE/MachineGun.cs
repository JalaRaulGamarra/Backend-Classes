using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaPractice2BE
{
    internal class MachineGun: Weapon   
    {
        public bool Lantern;
        private protected int MaxNumberShots = 20;
        public MachineGun()
        {
            this.Magazine = 20;
        }
        public override void ShootWeapon()
        {
            var cant = this.Magazine;
            for (int i = cant; i >= 0; i--)
            {
                if (i != cant)
                {
                    Console.WriteLine($"Shooting... {this.Magazine} Bullets Left.....");
                }
                this.Magazine = this.Magazine - 1;
                this.CurrentBullets = this.Magazine;
            }

            if (this.Magazine != 0)
            {
                Console.WriteLine("---Gun is out of bullets use, 1) Full Reload or 2) Custom Reload---");
            }
        }
        public override void Reload()
        {
            this.Magazine = this.MaxNumberShots;
            Console.WriteLine("Full Reload Ready.... " + this.Magazine + " in Magazine");
        }
    }

    
}
