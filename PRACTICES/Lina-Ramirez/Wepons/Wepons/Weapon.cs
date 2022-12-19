using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wepons
{
    internal class Weapon
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int MagazineSize { get; set; }
        public string Color { get; set; }
        public int Range { get; set; }
        public int NeedsReload { get; set; }

        public int CurrentBullets { get; set; }
        public double Weight { get; set; }

        public void Recharge()
        {
            Random rnd = new Random();
            int bullets = rnd.Next(1, MagazineSize);
            Console.WriteLine($"{bullets} reloaded bullets");
        }

        public void ReLoadFull()
        {
            Load(MagazineSize);
        }
       
        public void Load(int bulletActual)
        {
            CurrentBullets = bulletActual;
        }
       

        public void ReLoad(int bulletReLoad)
        {
            if (bulletReLoad <= MagazineSize)
            {
                Load(bulletReLoad);
            }
            else
            {
                Console.WriteLine($"The capacity is:{0}", MagazineSize);
            }
                

        }        

    }
}
