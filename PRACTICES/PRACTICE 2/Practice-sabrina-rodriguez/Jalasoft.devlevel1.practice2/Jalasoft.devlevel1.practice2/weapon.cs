using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.devlevel1.practice2
{
    internal class weapon
    {
        public int MagazineSize { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Range { get; set; }
        public bool NeedsReload { get; set; }
        public int CurrentBullets { get; set; }
        public decimal Weight { get; set; }



        //METODO PARA DISPARAR
        public virtual void Shoot()
        {
            if (this.CurrentBullets > 0)
            {
                this.CurrentBullets--;
                Console.WriteLine("PUM");
                
                Reload();

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

        //METODO PARA RECARGAR BALAS
        public void Reload()
        {
            this.CurrentBullets += 1;
        }

        //METODO PARA RECARGAR BALAS CUANDO SE QUEDA SIN. 
        public void ReloadWhenEmpty()
        {
            Console.WriteLine("¿Quieres recargar el arma? (S/N)");
            string answer = Console.ReadLine();
            if (answer == "S")
            {
                Console.WriteLine("¿Quieres recargar el cargador completo? (S/N)");
                string answer2 = Console.ReadLine();
                if (answer2 == "S")
                {
                    this.CurrentBullets = this.MagazineSize;
                }
                else
                {
                    Console.WriteLine("¿Cuántas balas quieres recargar?");
                    int answer3 = Convert.ToInt32(Console.ReadLine());
                    this.CurrentBullets += answer3;
                }
            }
            else
            {
                Console.WriteLine("No se ha recargado el arma");
            }
        }
    }
}
