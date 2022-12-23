using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    public abstract class Weapon
    {
        protected int currentBullets;
        protected string name;
        protected int magazineSize;
        protected int range;
        protected int weight;
        protected int shootRange;

        public bool NeedsReload { 
            get 
            { 
                return currentBullets == 0;
            } 
        }

        public int ShootRange
        {
            get
            {
                return shootRange;
            }
        }

        public string Brand { get; set; }
        public string Name { 
            get 
            {
                return name;
            } 
        }
        public int MagazineSize {
            get 
            {
                return magazineSize;
            } 
        }

        public string Color { get; set; }
        public int Range {
            get
            {
                return range;
            }
        }
        public int Weight {
            get
            {
                return weight;
            }
        }

        public abstract void Shoot(int range);
        public void Reload()
        {
            this.currentBullets = magazineSize;
            Console.WriteLine("Magazine full");
        }

        public void Reload(int numberOfBullets)
        {
            this.currentBullets += numberOfBullets;
            Console.WriteLine($"{numberOfBullets} bullet loaded");
        }

        protected void HitsTarget(int range)
        {
            if (range <= this.shootRange)
            {
                Console.WriteLine("target hit");
            }
            else
            {
                Console.WriteLine("target not hit");
            }
        }
    }
}
