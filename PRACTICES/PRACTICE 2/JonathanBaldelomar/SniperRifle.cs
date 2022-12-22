using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1SegundaPractica
{
    internal class SniperRifle : Weapon
    {
        public bool TelescopicSight { get; set; }
        public SniperRifle()
        {
            this.Brand = "patito";
            this.Name = "sniper rifle";
            this.MagazineSize = 7;
            this.Color = "red";
            this.Range = 100;
            this.CurrentBullets = 7;
            this.Weight = 13;
            this.TelescopicSight = true;
        }
    }
}
