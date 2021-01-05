using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace KoopaConverter.inc
{
    class DAOClass
    {
        private static String connectionString;
        private static SqlConnection connection;
        
       

        public static void Initialize()
        {
            connectionString = ConfigurationManager.
                ConnectionStrings["KoopaConverter.Properties.Settings.UnitsDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public static DataTable GetRow(String unit, double number)
        {
            String query = "SELECT * FROM astm WHERE " + unit + " = " + number;
            DataTable row = new DataTable();
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                
                
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();
                    
                    adapter.Fill(row);
                    

                }
                catch (IndexOutOfRangeException e)
                {

                    Console.WriteLine(e.Message);
                }
                connection.Close();
            }

            return row;
            
        }



        public static double[] RowCreator(String[] higher, String[] lower, double number)
        {
            String[] units = { "HLK", "HV136", "HB10", "HRA120", "HRB1o16", "HRC120", "HRD120", "HRF1o16",
            "HR15N", "HR30N", "HR45N", "HR15T", "HR30T", "HR45T", "HSc", "Nomm2"};
            int columnNum = Array.IndexOf(units, Main.unit);
            double[] da = new double[16];
            try
            {
                for (int i = 0; i < higher.Length; i++)
                {
                    if (higher[i] != "" && lower[i] != "")
                    {
                        if(i == 0) {
                            double[] point1 = { double.Parse(higher[0]),
                    double.Parse(higher[columnNum]) };
                            double[] point2 = { double.Parse(lower[0]),
                    double.Parse(lower[columnNum]) };
                            da[i] = LinearApprox(point1, point2, number, true);
                        }
                        else {
                            double[] point1 = { double.Parse(higher[0]),
                    double.Parse(higher[i]) };
                            double[] point2 = { double.Parse(lower[0]),
                    double.Parse(lower[i]) };
                            da[i] = LinearApprox(point1, point2, da[0], false);
                        }
                        

                        
                    }
                }
               
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return da;

        }

        public static double LinearApprox(double[] a, double[] b, double number, bool flag)
        {

            double x = 0;
            double slope = (a[1] - b[1]) / (a[0] - b[0]);
            if (flag)
            {
        
                x = Math.Abs(((number - b[1]) / slope) + b[0]);
            }
            else
            {
                x = Math.Abs((slope * (number - b[0])) + b[1]);
            }
            
            

            return x;

        }

        public static DataTable GetLower(double number, String unit)
        {
            String query = "select top 1 * from astm where " + unit + " <= " + number + 
                " order by " + unit +"  desc; ";

            
            DataTable row = new DataTable();
            using (SqlCommand command = new SqlCommand(query, connection))
            {



                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();

                    adapter.Fill(row);


                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                connection.Close();
            }

            return row;

        }

        public static DataTable GetHigher(double number, String unit)
        {
            String query = "select top 1 * from astm where " + unit + " >= " + number + " ; ";


            DataTable row = new DataTable();
            using (SqlCommand command = new SqlCommand(query, connection))
            {



                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();

                    adapter.Fill(row);


                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                connection.Close();
            }

            return row;

        }


    }


    }

   



