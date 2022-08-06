using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Swquel_Database_connection
{



    public class DataAccess
    {

        public static double sd = 0;
        public static double avg;
        public static double cp;
        public static double cpu;
        public static double cpl;
        public static double cpk;
        public static List<double> l1 = new List<double>();
        


        public dynamic GetSd()
        {
            
            double sum = 0;
            //int sum= 0;
            //float mean = 0;
            double apslon =0;
            int n = l1.Count;
            foreach ( var j  in l1)
            {
                double a = j - avg;
                apslon = (float)Math.Pow(a, 2);
                sum = sum + apslon;
            }
            apslon = sum / n;
            double Sd = Math.Sqrt(apslon);
            sd = Sd;
            string Sds = Sd.ToString();
            return Sds;
            
        }




        public dynamic GetCp(double usl, double lsl)
        {
            double Cp = 0;
            string display2;
            double temp;

            temp = Math.Abs(usl - lsl);
            Cp = temp / 6 * sd;
            display2 = Convert.ToString(Cp);
            cp = Cp;
            return display2;
        }




        public dynamic GetCpu(double USL)
        {
            double Avg = avg;
            double Cpu = USL - Avg / 3 * sd;
            cpu = Cpu;
            string output = Convert.ToString(Cpu);
            return output;

        }




        public dynamic GetCpl( double LSL)
        {
            double Avg = avg;
            double Cpl = Avg - LSL / 3 * sd;
            cpl = Cpl;
            string op = Convert.ToString(Cpl);
            return op;
        }




        public dynamic GetCpk()
        {
            double CPk = Math.Min(cpu, cpl);
            cpk = CPk;
            string op = Convert.ToString(CPk);
            return op;
        }


        public dynamic GetAvgAlt()
        {
            double sum = 0;
            for (int i=0; i< l1.Count;i++)
            {
                sum += l1[i];
            }

            int num = l1.Count;

            double AvgAlt = sum / num;
            avg = AvgAlt;
            var AvgAlts = Convert.ToString(AvgAlt);
            return AvgAlts;
        }


        


        public List<string> GetInfo(string Number,string Number1,string Col)
        {
            string connectionString = "Server=VIS-12\\TESTSQLSERVER;Database=SPCC;User Id=sa;Password=admin1234;";
            string comand = $"select {Col} from Tbl_Reading where LogTime between '{Number}' and '{Number1}'";
            using (SqlConnection conn = new SqlConnection())
            {

                List<string> valueslist = new List<string>();
                double[] values = new double[50];
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand c1 = new SqlCommand(comand, conn);
                SqlDataReader reader = c1.ExecuteReader();
                if (reader.HasRows) 
                {
                    int x = 0;
                    while (reader.Read())
                    {
                        
                        string v = Convert.ToString(reader.GetValue(0));
                        valueslist.Add(v);
                        v = "";
                        x++;
                    }
                }
                reader.Close();
                int y = valueslist.Count;
                l1.Clear();
                for (int a=0; a<y;a++ )
                {
                    l1.Add(Convert.ToDouble(valueslist[a]));
                }
                conn.Close();
                return valueslist;
                
            }
        }


        public List<dynamic> CheckLowerLimits(string lsl)
        {
            List<dynamic> vals = new List<dynamic>();
            //double Usl = Convert.ToDouble(usl);
            double Lsl = Convert.ToDouble(lsl);
            int x = l1.Count;
            for (int i =0;i<x;i++)
            {
                if (l1[i] < Lsl)
                {
                    vals.Add(l1[i]);
                }

                else
                    continue;
            }

            return vals;
        }




        public List<dynamic> CheckUpperLimits(string usl)
        {
            List<dynamic> valslow = new List<dynamic>();
            double Usl = Convert.ToDouble(usl);
            int x = l1.Count;
            for (int i = 0; i<x;i++)
            {
                if (l1[i] > Usl)
                {
                    valslow.Add(l1[i]);
                }
                else
                    continue;
            }

            return valslow;    
        }
            

    
    }
}