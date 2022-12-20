using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica2
{
    public class Target
    {
        public int Distance { get; set; }
        public bool Reached { get; set; }
        public Target(int distance) {
            Distance = distance;
            Reached = false;
        }
    }
}
