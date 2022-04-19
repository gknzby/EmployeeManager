using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Users
{
    class ParttimeUser : User
    {
        public override bool UserMngAccess()
        {
            return false;
        }

        public override float GetSalary()
        {
            return BmoSalary/2.0f;
        }
    }
}
