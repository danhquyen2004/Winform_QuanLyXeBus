using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus
{
    internal class UserRole
    {
        private static UserRole instance;
        public int role;

        public static UserRole Instance
        {
            get { if (instance == null) instance = new UserRole(); return UserRole.instance; }
            private set => instance = value;
        }
    }
}
