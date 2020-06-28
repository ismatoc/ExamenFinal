using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.db
{
    public class ConnectionManager
    {
        private readonly SqlConnection conn = new SqlConnection(); 

        public SqlConnection GetConnection()
        {
            try
            {
                conn.ConnectionString = "Server=LAPTOP-LNF73SF9;Database=Solid;Trusted_Connection=true";
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}
