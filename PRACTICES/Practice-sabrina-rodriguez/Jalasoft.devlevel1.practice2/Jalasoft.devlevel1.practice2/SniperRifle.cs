using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.devlevel1.practice2
{
    internal class SniperRifle : weapon
    {
        public SniperRifle(string Name, string Brand, string Color, bool NeedsReload, int CurrentBullets, decimal Weight)
        {
            this.Name = Name;
            this.MagazineSize = 7;
            this.Brand = Brand;
            this.Color = Color;
            this.Range = 100;
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

        
        
    }
}
