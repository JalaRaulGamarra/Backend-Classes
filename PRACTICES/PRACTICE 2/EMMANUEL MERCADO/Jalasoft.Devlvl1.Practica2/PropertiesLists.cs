using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    public struct ShotGunProperties
    {
        public int MagazineCapacity { get; set; }
        public int Range { get; set; }
        public int CurrentBullets { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public double Weight { get; set; }
        public ShotGunProperties(string brand, string color, string name)
        {
            MagazineCapacity = 2;
            Range = 5;
            CurrentBullets = 0;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = 0.75;
        }
    }

    public struct SniperRifleProperties
    {
        public int MagazineCapacity { get; set; }
        public int Range { get; set; }
        public int CurrentBullets { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public double Weight { get; set; }
        public SniperRifleProperties(string brand, string color, string name)
        {
            MagazineCapacity = 7;
            Range = 100;
            CurrentBullets = 0;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = 3;
        }
    }

    public struct MachineGunProperties
    {
        public int MagazineCapacity { get; set; }
        public int Range { get; set; }
        public int CurrentBullets { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public double Weight { get; set; }
        public MachineGunProperties(string brand, string color, string name)
        {
            MagazineCapacity = 20;
            Range = 16;
            CurrentBullets = 0;
            Brand = brand;
            Name = name;
            Color = color;
            Weight = 5;
        }
    }
}
