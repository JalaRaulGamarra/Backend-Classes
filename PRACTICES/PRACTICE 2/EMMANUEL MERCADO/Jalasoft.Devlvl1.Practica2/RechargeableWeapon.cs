using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    internal class RechargeableWeapon : Weapon
    {
        protected bool NeedsRecharge { get; set; }

        public void Recharge()
        {
            CurrentBullets++;
            Console.WriteLine("Recharged!");
            NeedsRecharge= false;
        }

        public override void Shoot(Target target)
        {
            if (!NeedsRecharge)
            {
                CurrentBullets--;

                Console.WriteLine("Weapon Shooted!...");
                if (target.Distance <= Range)
                {
                    Console.WriteLine("Target reached");
                }
                else
                {
                    Console.WriteLine("Target missed");
                }

                if (CurrentBullets == 0)
                {
                    NeedsToReload = true;
                }
                NeedsRecharge = true;
            }
            else
            {
                Console.WriteLine("You have to recharge your weapon");
            }
        }
    }
}
