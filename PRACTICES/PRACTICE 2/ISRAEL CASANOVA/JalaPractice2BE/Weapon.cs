using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaPractice2BE
{
    public class Weapon: PracticeField
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Range { get; set; }
        public string Weight { get; set; }


        private protected int Magazine;
        private protected int CurrentBullets;

        public virtual void ShootWeapon()
        {
        }

        public virtual void Reload()
        {
        }

        public void Reload(int bullets)
        {
            this.Magazine = bullets;
            Console.WriteLine("Custom Reload Ready.... " + this.Magazine + " in Magazine");
        }

        public void getStatusHit(int TargetDistance)
        {
            if (this.Range > TargetDistance || this.Range == TargetDistance)
            {
                Console.WriteLine("HIT!!!....Range: "+this.Range+" TargetDistance: "+TargetDistance);
            }
            else
            {
                Console.WriteLine("NO HIT!!!....Range: " + this.Range + " TargetDistance: " + TargetDistance);
            }
        }
    }
}
//