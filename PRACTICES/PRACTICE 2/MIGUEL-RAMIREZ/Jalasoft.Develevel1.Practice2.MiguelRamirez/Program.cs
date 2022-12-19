using Jalasoft.Develevel1.Practice2.MiguelRamirez;

Random random= new Random();



Shotgun shotgun = new Shotgun();
int shootingDistance = random.Next(1, 7);
while (!shotgun.NeedsReload)
{
    shotgun.Shoot();
    if (shotgun.IsWithinRange(shootingDistance))
    {
        Console.WriteLine("Hit the target ...");
    }
    else
    {
        Console.WriteLine("Out of range ...");
    }
}
//Recargamos el cargador (completo)
shotgun.ReloadingMagazine();
shotgun.CurrentBullets = 0;
//Recargamos el cargador (perzonalizado)
shotgun.ReloadingMagazine(2);




SniperRifle sniper = new SniperRifle();
shootingDistance = random.Next(1, 110);

while (!sniper.NeedsReload)
{
    sniper.Shoot();
    if (shotgun.IsWithinRange(shootingDistance))
    {
        Console.WriteLine("Hit the target ...");
    }
    else
    {
        Console.WriteLine("Out of range ...");
    }
}
//Recargamos el cargador (completo)
sniper.ReloadingMagazine();
sniper.CurrentBullets = 0;
//Recargamos el cargador (perzonalizado)
sniper.ReloadingMagazine(7);




MachineGun machinegun = new MachineGun();
shootingDistance = random.Next(1, 20);

while (!machinegun.NeedsReload)
{
    machinegun.Shoot();
    if (shotgun.IsWithinRange(shootingDistance))
    {
        Console.WriteLine("Hit the target ...");
    }
    else
    {
        Console.WriteLine("Out of range ...");
    }
}
//Recargamos el cargador (completo)
machinegun.ReloadingMagazine();
machinegun.CurrentBullets = 0;
//Recargamos el cargador (perzonalizado)
machinegun.ReloadingMagazine(20);