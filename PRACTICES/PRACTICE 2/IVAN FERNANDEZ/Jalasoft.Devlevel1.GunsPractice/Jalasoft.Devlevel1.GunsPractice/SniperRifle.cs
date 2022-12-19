using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.GunsPractice
{
    internal class SniperRifle : Weapon
    {

        public override void shootATarget(int objetiveDistance)
        {
            if (objetiveDistance <= 100) Console.WriteLine("The Target was hit!");
            else Console.WriteLine("The Target was not hit");
        }
    }
}
