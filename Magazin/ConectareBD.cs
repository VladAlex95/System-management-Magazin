using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Management_magazin
{
    class ConectareDB
    {
        private SqlConnection connection = new SqlConnection("Persist Security Info = False; Integrated Security = true; Initial Catalog = magazindb; Server=.\\SQLEXPRESS");
        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
