using JalaPractice2BE;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;



Shotgun Weapon1 = new Shotgun();
Weapon1.Name = "Winchester (ShotGun)";
Weapon1.Size = "250cm";
Weapon1.Color = "Black";
Weapon1.Weight = "3kg";
Weapon1.Range = 5;
Weapon1.Lantern = false;

MachineGun Weapon2 = new MachineGun();
Weapon2.Name = "M85 (MachineGun)";
Weapon2.Size = "400cm";
Weapon2.Color = "Brown";
Weapon2.Weight = "11kg";
Weapon2.Range = 16;
Weapon2.Lantern = true;

SniperRifle Weapon3 = new SniperRifle();
Weapon3.Name = "SAKO TRG 42 (SniperRifle)";
Weapon3.Size = "600cm";
Weapon3.Color = "Black";
Weapon3.Weight = "2.5 kg";
Weapon3.Range = 100;
Weapon3.Telescopic = true;

PracticeField Field1 = new PracticeField();

Console.WriteLine("---Select Weapon---");
Console.WriteLine($"1.- {Weapon1.Name}");
Console.WriteLine($"2.- {Weapon2.Name}");
Console.WriteLine($"3.- {Weapon3.Name}");

var option = Int32.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Field1.SelectedGun = Weapon1;
    break;
    case 2:
        Field1.SelectedGun = Weapon2;
    break;
    case 3:
        Field1.SelectedGun = Weapon3;
    break;

}

Console.WriteLine("---Select Distance Target ---");
Console.WriteLine("5  : 5mts");
Console.WriteLine("16 : 16mts");
Console.WriteLine("100: 100mts");
Field1.TargetDistance = Int32.Parse(Console.ReadLine()); ;

Console.WriteLine("---Shoot---");
Field1.SelectedGun.ShootWeapon();

var ReloadOption = Int32.Parse(Console.ReadLine());

if (ReloadOption == 1)
{
    Field1.SelectedGun.Reload();
}else if(ReloadOption == 2)
{
    Console.WriteLine("---Enter number of bullets---");
    Field1.SelectedGun.Reload(Int32.Parse(Console.ReadLine()));
}

Console.WriteLine("---Select an option 1) Shoot Again 2) Show Hit Status---");
var optionSec = Int32.Parse(Console.ReadLine());
if (optionSec == 1)
{
    Console.WriteLine("---Shoot---");
    Field1.SelectedGun.ShootWeapon();
}
else if(optionSec == 2)
{
    Field1.SelectedGun.getStatusHit(Field1.TargetDistance);
}








