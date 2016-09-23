using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace testlogin.BaseClass
{
    class DBConn
    {
        public static SqlConnection Login()
        {
            return new SqlConnection("server=(local);database=testlogin;uid=sa;pwd=sa");
        }

    }
}
