using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.GunsPractice
{
    internal class Weapon
    {
        public string brand { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public bool needsReload { get; set; }
        public double weight { get; set; }
        public int currentBullets { get; set; }

        private protected int magazineSize;
        private protected int efectiveRange;
        
        public virtual void shootATarget(int objetiveDistance){
        }
        public virtual void reloadMagazine(){
        }
        public virtual void reloadMagazine(int numberOfBullets)
        {
        }
    }
}
