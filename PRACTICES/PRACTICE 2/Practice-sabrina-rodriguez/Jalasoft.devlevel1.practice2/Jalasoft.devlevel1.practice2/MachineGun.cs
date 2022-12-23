using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.devlevel1.practice2
{
    internal class MachineGun : weapon
    {
        public MachineGun(string Name, string Brand, string Color, bool NeedsReload, int CurrentBullets, decimal Weight)
        {
            this.Name = Name;
            this.MagazineSize = 20;
            this.Brand = Brand;
            this.Color = Color;
            this.Range = 16;
            this.NeedsReload = NeedsReload;

            if (CurrentBullets > MagazineSize)
            {
                this.CurrentBullets = MagazineSize;
            }
            else
            {
                this.CurrentBullets = CurrentBullets;
            }

            this.Weight = Weight;
        }

        //metodo para disparar
        public override void Shoot()
        {
            if (this.CurrentBullets > 0)
            {
                this.CurrentBullets--;
                Console.WriteLine("PUM");

                if (this.CurrentBullets == 0)
                {
                    Console.WriteLine("Sin balas, hay que recargar");
                    //llamar al metodo de recarga
                    ReloadWhenEmpty();
                }
            }
            else
            {
                Console.WriteLine("No hay balas");
            }
        }
    }
}
