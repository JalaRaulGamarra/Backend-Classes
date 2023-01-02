using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Book_Request_System
{
    public class Essay : Books
    {
        public Essay(string name, string author, int libraryCode)
        {
            this.status = true;
            this.name = name;
            this.type = "essay";
            this.author = author;
            this.libraryCode = libraryCode;
        }
        public bool Status = true;
        
    }
}
