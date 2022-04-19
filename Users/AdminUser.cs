using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Users
{
    class AdminUser : User
    {
        public override bool UserMngAccess()
        {
            return true;
        }

        public override float GetSalary()
        {
            return BmoSalary;
        }
    }
}
