using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Request_System
{
    public class Comic:Books
    {
        protected internal Comic(string name,string author,int libraryCode)
        {
            this.status = true;
            this.name = name;
            this.type = "comic";
            this.author = author;
            this.libraryCode = libraryCode;
        }
        
    }
}
