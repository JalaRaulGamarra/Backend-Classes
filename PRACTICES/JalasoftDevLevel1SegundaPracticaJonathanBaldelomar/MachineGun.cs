using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1SegundaPractica
{
    internal class MachineGun : Weapon
    {
        public bool Lantern { get; set; }
        public MachineGun()
        {
            this.Brand = "M16";
            this.Name = "stutterer";
            this.MagazineSize = 20;
            this.Color = "black";
            this.Range = 16;
            this.CurrentBullets = 20;
            this.Weight = 13;
            this.Lantern = true;
        }
    }
}
