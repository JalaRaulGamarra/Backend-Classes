// See https://aka.ms/new-console-template for more information
using Wepons;

Console.WriteLine("Hello, World!");

Shotgun shotgun= new Shotgun();
shotgun.Name = "Devil";
shotgun.Fire();

SniperRifle sniperRifle= new SniperRifle();
sniperRifle.Name = "Hell Lady";
sniperRifle.Fire();

MachineGun machine= new MachineGun();
machine.Name = "Evil";
machine.Fire();
machine.Range();