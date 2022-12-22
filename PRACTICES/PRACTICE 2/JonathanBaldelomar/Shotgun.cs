using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1SegundaPractica
{
    internal class Shotgun : Weapon
    {
        public bool Lantern { get; set; }
        public Shotgun()
        {
            this.Brand = "Winchester";
            this.Name = "Old betsy";
            this.MagazineSize = 2;
            this.Color = "brown";
            this.Range = 5;
            this.CurrentBullets = 2;
            this.Weight = 13;
            this.Lantern = true;
        }
    }
}