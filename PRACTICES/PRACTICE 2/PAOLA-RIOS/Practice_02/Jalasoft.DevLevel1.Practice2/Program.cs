// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice2;

Console.WriteLine("Hello, World!");
// Shotgun
Weapon shotGun1= new Shotgun();
shotGun1.Name = NameWeapons.Shotgun;
Console.WriteLine(shotGun1.Name);
int magazineSGun1 = shotGun1.MagazineSize;
Console.WriteLine("The Shotgun has size magazine : {0}", magazineSGun1);
shotGun1.Shoot(); 
shotGun1.ReLoadFull();
shotGun1.Shoot();
shotGun1.Shoot();
shotGun1.Shoot();

Console.WriteLine("====================================");

// Sniper Rifle
Weapon sniperRifle1= new SniperRifle();
sniperRifle1.Name=NameWeapons.SniperRifle;
Console.WriteLine(sniperRifle1.Name);
int magazineSniper= sniperRifle1.MagazineSize;
Console.WriteLine("The SniperRifle has size magazine: {0}", magazineSniper);
sniperRifle1.Shoot();
sniperRifle1.ReLoadFull();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();
sniperRifle1.Shoot();


Console.WriteLine("====================================");

// Machine gun
Weapon machineGun1 = new MachineGun();
machineGun1.Name = NameWeapons.MachineGun;
Console.WriteLine(machineGun1.Name);
int magazineMachineGun = machineGun1.MagazineSize;
Console.WriteLine("The SniperRifle has size magazine: {0}", magazineMachineGun);
machineGun1.Shoot();
machineGun1.ReLoadFull();
machineGun1.Shoot();


