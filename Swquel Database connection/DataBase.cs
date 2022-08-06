using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swquel_Database_connection
{
    class DataBase
    {
        //public static string val2 ;
        public double[] GetInfo(string Col)
        {
            string connectionString = "Server=VIS-12\\TESTSQLSERVER;Database=SPCC;User Id=sa;Password=admin1234;";
            string comand = "select '{Col}' from Tbl_Reading where [LogTime] between '2017-07-06 14:30:26.000' and '2017-07-06 14:30:26.000' ";
            using (SqlConnection conn = new SqlConnection())
            {
                double[] val1 = { };
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand c1 = new SqlCommand(comand, conn);
                SqlDataReader reader = c1.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        
                        int x = 0;
                        val1[x] = reader.GetDouble(1);
                        x++;
                    }
                }
                reader.Close();

                conn.Close();
                return val1;
            }
        }
            

       
    }
}
