using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    interface IReviewable
    {
        void ReviewEssay(string reviewer, EssayStatus status);
    }
}
