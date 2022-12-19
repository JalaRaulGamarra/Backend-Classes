using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    public class Weapon
    {
        public string Brand { get; set; }
        public NameWeapons Name { get; set; }
        protected internal virtual int MagazineSize { get; }
        public string Color { get; set; }
        public virtual double Range { get; }
        public bool NeedsReload { get; set; }
        public int CurrentBullet { get; set; }
      
        public double Weight { get; set; }
        public double Size { get; set; }

        public virtual void Shoot()
        {
            if (CurrentBullet > 0)
            {
                Console.WriteLine("Boooooommmmmm ");
                CurrentBullet--;
                Recharge();
            }
            else
                Console.WriteLine("Recharge because the weapon has no bullets  ");
        }
        public void ReLoadFull()
        {
            Load(MagazineSize);
            Console.WriteLine("Reaload completed");
        }
        public void ReLoad(int bulletReLoad)
        {
            if (bulletReLoad <= MagazineSize)
                Load(bulletReLoad);
            else
                Console.WriteLine("No loaded the capacity for this weapon is:{0}", MagazineSize);

        }
        public void Load(int bulletActual) 
        {
            CurrentBullet = bulletActual; 
        }
        public void Recharge()
        {
            if (CurrentBullet == 0)
                Console.WriteLine("The weapon doesn't have bullets");
           else
            Console.WriteLine("Weapon is recharging the weapon is ready to shoot again");
        }

    }
}
