using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaPractice2BE
{
    internal class SniperRifle : Weapon
    {
        public bool Telescopic { get; set; }
        private protected int MaxNumberShots = 7;
        public SniperRifle()
        {
            this.Magazine = 7;
        }
        public override void ShootWeapon()
        {
            var cant = this.Magazine;
            for (int i = cant; i >= 0; i--)
            {
                if (i != cant)
                {
                    Console.WriteLine($"Shooting... {this.Magazine} Bullets Left.....");
                    if (i != 0) Console.WriteLine("Recharging....");
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
            Console.WriteLine("Full Reload Ready.... "+this.Magazine+" in Magazine");
        }
    }
}
