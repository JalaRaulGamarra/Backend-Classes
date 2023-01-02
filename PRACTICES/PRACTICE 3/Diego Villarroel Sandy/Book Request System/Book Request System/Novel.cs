using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Request_System
{
    public class Novel : Books
    {
        
        internal Novel()
        {
            this.status = true;
            this.type = "novel";
        }
       
    }
}
