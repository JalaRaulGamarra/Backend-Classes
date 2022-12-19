using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Weapons
    {
        public Weapons(){ }

        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        private protected int Magazinesize;
        private protected int Range;
        private protected bool NeedsReload;
        public int CurrentBullets { get; set; }
        private protected double Weight;
        private protected string Accesories;

        virtual public void Shoot(int distance)
        {
            CurrentBullets--;
            Console.WriteLine("Shooting");
            if (distance > Range) Console.WriteLine("Missing shot");
            else Console.WriteLine("Hit");
            Recharge();
            if (CurrentBullets > 0) 
            {
                NeedsReload = false;
            }
            
            else 
            NeedsReload= true;
            {
                Console.WriteLine("que tipo de recarga elige");

                char opt = Convert.ToChar(Console.ReadLine());
                
                SelectReloadType(opt); 
                    
            }



        }
        public void Recharge()
        {
            Console.WriteLine("Recharging");
            Console.WriteLine("Recharged");
        }
        public void SelectReloadType(char opt)
        {
            if (opt == 'a')
            {
                CurrentBullets = Magazinesize;
                Console.WriteLine("weapon reloaded");
            }
            else
            { 
                Console.WriteLine("how many bullets will you reload");

                int nob = Convert.ToInt32(Console.ReadLine());
                ManualReloading(nob);
                Console.WriteLine($"it reload {nob} bullets ");
            } 
                
        }
        public void ManualReloading(int nob) { CurrentBullets += nob; }


    }
}
