// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice2;

Console.WriteLine("Hello, World!");
Shotgun shotgun = new Shotgun();
SniperRifle sniperRifle = new SniperRifle();
MachineGun machineGun = new MachineGun();

shotgun.Shoot(10);
shotgun.Shoot(8);
shotgun.Recharge();
shotgun.Shoot(5);
shotgun.Shoot(5);
shotgun.Reload();

sniperRifle.Shoot(200);
sniperRifle.Shoot(150);
sniperRifle.Recharge();
sniperRifle.Shoot(150);
sniperRifle.Shoot(100);
sniperRifle.Reload(1);
Console.WriteLine(sniperRifle.NeedsReload);

machineGun.Shoot(50);
machineGun.Shoot(40);
machineGun.Shoot(20);
machineGun.Shoot(10);
machineGun.Shoot(5);
machineGun.Shoot(5);
machineGun.Shoot(5);
machineGun.Shoot(5);
machineGun.Shoot(5);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);
machineGun.Shoot(18);