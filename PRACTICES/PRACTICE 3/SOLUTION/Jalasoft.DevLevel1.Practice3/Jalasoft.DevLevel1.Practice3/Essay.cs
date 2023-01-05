using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jalasoft.DevLevel1.Practice3
{
    internal class Essay : Book
    {
        public Essay(string name)
        {
            Name = name;
            Available = true;
        }
    }
}
