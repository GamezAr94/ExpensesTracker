using ExpensesTracker.Common.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker
{
    class MemberViewModel
    {
        public static Member ActiveMember { get; set; }
        static MemberViewModel()
        {

        }
    }
}
