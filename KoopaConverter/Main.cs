using KoopaConverter.inc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoopaConverter
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
            DAOClass.initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unitsDBDataSet.ASTM' table. You can move, or remove it, as needed.
            

            
                DataTable x = DAOClass.getRow("HRF1o16", 115.1);
                
            for(int i = 0; i<x.Rows.Count; i++)
            {
                for(int j = 0; j<x.Columns.Count; j++)
                {
                    
                    Console.WriteLine(x.Rows[i][j]);
                }
            }

        }

      
    }
}
