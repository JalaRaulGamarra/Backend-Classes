using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.GunsPractice
{
    internal class SniperRifle : Weapon
    {
        private bool isCharged;
        public SniperRifle(string brand, string name, string color, double weight) {
            this.brand = brand;
            this.name = name;
            this.color = color;
            this.weight = weight;
            this.currentBullets = 0;
            efectiveRange = 100;    // distance
            magazineSize = 7;       
            needsReload = true;
            this.isCharged = false;
            
        }
        public override void shootATarget(int objetiveDistance){
            if (isCharged) {
                if (objetiveDistance <= efectiveRange) Console.WriteLine("PUM! The Target was hit!");
                else Console.WriteLine("PUM! The Target was not hit");
                isCharged=false;
            }
            else Console.WriteLine("The Sniper Rifle needs to be charged");
        }
        public void rechargeSniperRifle(){
            if(currentBullets > 0 || !needsReload){ 
                currentBullets--;
                isCharged=true;
                Console.WriteLine("The Sniper Rifle was charged");
            }
            else{
                needsReload= true;
                Console.WriteLine("The Sniper Rifle magazine needs to be reload");
            }
            if (currentBullets == 0) needsReload = true;
        }
        public override void reloadMagazine(){
            if (currentBullets == magazineSize) Console.WriteLine("The weapon is already fully loaded");
            else
            {
                currentBullets = magazineSize;
                needsReload= false;
                Console.WriteLine("The Sniper Rifle was fully loaded");
            }
        }
        public override void reloadMagazine(int numberOfBullets)
        {
            if (currentBullets == magazineSize) Console.WriteLine("The weapon is already fully loaded");
            else if((numberOfBullets +currentBullets) > magazineSize){
                Console.WriteLine("You cannot load more than the Sniper Rifle magazine supports");
            }
            else{
                currentBullets += numberOfBullets;
                Console.WriteLine("The Sniper Rifle was custom loaded");
            }
            if (currentBullets > 0) needsReload = false;
        }
    }
}
