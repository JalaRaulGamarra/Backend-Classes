using Jalasoft.Devlevel1.GunsPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("(*) Shooting Galery Practice (*)     by Ivan Fernandez\n");
        ShootingGallery shootingGallery = new ShootingGallery();
        shootingGallery.SniperRifleShootingSimulation();
        shootingGallery.MachineGunShootingSimulation();
        shootingGallery.ShotGunShootingSimulation(); 
    }
}