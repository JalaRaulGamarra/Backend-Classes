using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    internal static class InterfaceDrawer
    {
        private static int Length;
        private static string? Pattern;
        private static int Count=1;
        public static void Braker()
        {
            Length = 10;
            Pattern = " - =";
            Console.WriteLine("");
            Console.Write($"Test -> [{Count}]");
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Pattern);
            }
            Console.WriteLine("");
            Count++;
        }
    }
}
