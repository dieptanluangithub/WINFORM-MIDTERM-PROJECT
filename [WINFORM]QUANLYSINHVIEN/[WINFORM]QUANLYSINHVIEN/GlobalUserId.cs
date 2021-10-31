using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class GlobalUserId
    {
        public static int UserID { get; private set; }

        public static void SetGlobalUserId (int userID)
        {
            UserID = userID;
        }
    }
}
