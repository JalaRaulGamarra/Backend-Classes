using Jalasoft.DevLevel1.Practice2;

// Generating distance to random target
int seed = Environment.TickCount;
var random = new Random(seed);
int distanceTarget;

// ShotGun
Console.WriteLine("\n#################### SHOT GUN ####################");
Shotgun sgWeapon = new Shotgun("Linux", "Shot Gun", "Green", 50, false);
Console.WriteLine(" ____________________________________");
Console.WriteLine("|            DETAILS                 |");
Console.WriteLine("|                                    ");
Console.WriteLine("|    Brand = " + sgWeapon.Brand);
Console.WriteLine("|    Name = " + sgWeapon.Name);
Console.WriteLine("|    Color = " + sgWeapon.Color);
Console.WriteLine("|    Weigth = " + sgWeapon.Weight);
Console.WriteLine("|    Range = " + sgWeapon.Range);
Console.WriteLine("|    Lantern = " + sgWeapon.Lantern);
Console.WriteLine("|    Magazine Size = " + sgWeapon.MagazineSize);
Console.WriteLine("|____________________________________|");

distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 10);
sgWeapon.Shoot(distanceTarget);

Console.Clear();
Console.WriteLine("Press enter to continue to the next weapon");
Console.ReadKey();

// SniperRifle
Console.WriteLine("\n#################### SNIPER RIFLE ####################");
SniperRifle srWeapon = new SniperRifle("IOS", "Sniper Rifle", "Blue", 60, false);
Console.WriteLine(" ____________________________________");
Console.WriteLine("|            DETAILS                 |");
Console.WriteLine("|                                    ");
Console.WriteLine("|    Brand = " + srWeapon.Brand);
Console.WriteLine("|    Name = " + srWeapon.Name);
Console.WriteLine("|    Color = " + srWeapon.Color);
Console.WriteLine("|    Weigth = " + srWeapon.Weight);
Console.WriteLine("|    Range = " + srWeapon.Range);
Console.WriteLine("|    Telescopic Sight = " + srWeapon.TelescopicSight);
Console.WriteLine("|    Magazine Size = " + srWeapon.MagazineSize);
Console.WriteLine("|____________________________________|");

distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(50, 150);
srWeapon.Shoot(distanceTarget);

Console.Clear();
Console.WriteLine("Press enter to continue to the next weapon");
Console.ReadKey();

// MachineGun
Console.WriteLine("#################### MACHINE GUN ####################");
MachineGun mgWeapon = new MachineGun("Microsoft", "Machine Gun", "Black", 20, true);
Console.WriteLine(" ____________________________________");
Console.WriteLine("|            DETAILS                 |");
Console.WriteLine("|                                    ");
Console.WriteLine("|    Brand = " + mgWeapon.Brand);
Console.WriteLine("|    Name = " + mgWeapon.Name);
Console.WriteLine("|    Color = " + mgWeapon.Color);
Console.WriteLine("|    Weigth = " + mgWeapon.Weight);
Console.WriteLine("|    Range = " + mgWeapon.Range);
Console.WriteLine("|    Lantern = " + mgWeapon.Lantern);
Console.WriteLine("|    Magazine Size = " + mgWeapon.MagazineSize);
Console.WriteLine("|____________________________________|");

distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
distanceTarget = random.Next(1, 30);
mgWeapon.Shoot(distanceTarget);
