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
        
       

        public static void initialize()
        {
            connectionString = ConfigurationManager.
                ConnectionStrings["KoopaConverter.Properties.Settings.UnitsDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public static DataTable getRow(String unit, double number)
        {
            String GETROW = "SELECT * FROM astm WHERE " + unit + " = " + number;
            DataTable row = new DataTable();
            using (SqlCommand command = new SqlCommand(GETROW, connection)) 
            {
                
                
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();
                    
                    adapter.Fill(row);
                    

                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(e.Message);
                }
                
            }

            return row;
            
        }


    }
}
