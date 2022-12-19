using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    internal class MachineGun : Weapon
    {
        protected bool Lantern { get; set; }
        public MachineGun(MachineGunProperties props)
        {

            MagazineCapacity = props.MagazineCapacity;
            Range = props.Range;
            CurrentBullets = props.CurrentBullets;
            Brand = props.Brand;
            Name = props.Name;
            Color = props.Color;
            Weight = props.Weight;

            NeedsToReload = true;
            Lantern = false;
        }
    }
}
