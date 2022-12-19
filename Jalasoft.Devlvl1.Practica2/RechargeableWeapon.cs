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

        protected void Recharge()
        {
            CurrentBullets++;
            Console.WriteLine("Recharged!");
            NeedsRecharge= false;
        }
    }
}
