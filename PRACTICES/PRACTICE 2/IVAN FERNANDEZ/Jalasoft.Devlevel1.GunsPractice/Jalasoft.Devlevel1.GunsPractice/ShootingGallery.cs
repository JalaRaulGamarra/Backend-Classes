using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.GunsPractice
{
    internal class ShootingGallery
    {
        SniperRifle sniperRifle;
        Shotgun shotgun;
        MachineGun machineGun;
        public ShootingGallery() {
            sniperRifle = new SniperRifle("brand1", "Lucia", "gray", 4.75);
            shotgun = new Shotgun("brand2", "shotgun1", "brown", 4.2);
            machineGun = new MachineGun("brand3", "machinegun1","black",5.00);
        }
        internal void SniperRifleShootingSimulation()
        {
            Console.WriteLine("-SniperRifle shooting:");
            sniperRifle.shootATarget(105);
            sniperRifle.rechargeSniperRifle();
            sniperRifle.reloadMagazine(10);
            sniperRifle.reloadMagazine(2);
            sniperRifle.rechargeSniperRifle();
            sniperRifle.shootATarget(105);
            sniperRifle.rechargeSniperRifle();
            sniperRifle.shootATarget(100);
            sniperRifle.rechargeSniperRifle();
            sniperRifle.reloadMagazine();
            Console.WriteLine("----------------------*----------------------");
        }
        internal void MachineGunShootingSimulation()
        {
            Console.WriteLine("-MachineGun Shooting:");
            machineGun.reloadMagazine(25);
            machineGun.reloadMagazine(10);
            machineGun.shootATarget(15);
            machineGun.shootATarget(20);
            machineGun.reloadMagazine();
            machineGun.shootATarget(20);
            Console.WriteLine("----------------------*----------------------");
        }
        internal void ShotGunShootingSimulation()
        {
            Console.WriteLine("-ShotGun shooting:");
            shotgun.reloadMagazine();
            shotgun.rechargeShotgun();
            shotgun.shootATarget(4);
            shotgun.rechargeShotgun();
            shotgun.shootATarget(10);
            shotgun.rechargeShotgun();
            shotgun.reloadMagazine();
            Console.WriteLine("----------------------*----------------------");
        }
    }
    
}
