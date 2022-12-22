using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1SegundaPractica
{
    internal class Weapon
    {
        //Following information
        public string Brand { get; set; }
        public string Name { get; set; }
        public int MagazineSize { get; set; }
        public string Color { get; set; }
        public int Range { get; set; }
        public int CurrentBullets { get; set; }
        public int Weight { get; set; }


        public void Shoot(int targetDistance)
        {
            if(CurrentBullets > 0)
            {
                CurrentBullets--;
                if (this.Range >= targetDistance) Console.WriteLine("Shot done");
                else Console.WriteLine("You missed the shot");
            }
            else Console.WriteLine("You don't have enough bullets to shoot");
        }
        public void FullReload()
        {
            this.CurrentBullets = MagazineSize;
            Console.WriteLine("Full reload done");
        }
        public void CustomReload(int bullets)
        {
            if (this.MagazineSize == this.CurrentBullets) Console.WriteLine("The gun is full");
            else
            {
                if (bullets <= (this.MagazineSize - this.CurrentBullets))
                {
                    this.CurrentBullets += bullets;
                    Console.WriteLine("Reload done");
                }
                else Console.WriteLine("You can't reload so many bullets");
            }
        }
    }
}
