using Jalasoft.Devlvl1.Practica2;

string[] Brands = { "CS-Strike", "U.S. NAVY", "Africans" };
string[] Colors = {"Black", "Sylver", "Desert" , "Wood" };

ShotGunProperties ShootgunProps = new ShotGunProperties(Brands[0], Colors[1],"Shootygun");
ShootGun MyShotgun = new ShootGun(ShootgunProps);

Target MyTarget = new Target(5);
Target MyTarget2 = new Target(10);

MyShotgun.Reload();
MyShotgun.Shoot(MyTarget);
MyShotgun.Shoot(MyTarget);
MyShotgun.Recharge();
MyShotgun.Shoot(MyTarget2);