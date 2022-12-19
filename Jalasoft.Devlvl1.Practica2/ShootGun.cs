using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    internal class ShootGun : RechargeableWeapon
    {
        protected bool Lantern { get; set; }
        public ShootGun() {


            NeedsToReload= true;
            NeedsRecharge = false;
            Lantern= false;
        }
    }
}
