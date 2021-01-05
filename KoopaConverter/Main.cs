using KoopaConverter.inc;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KoopaConverter
{
    public partial class Main : Form
    {
        public static String unit;

        public Main()
        {
            InitializeComponent();

            DAOClass.Initialize();
        }


        private void convertBTN_Click(object sender, EventArgs e)
        {
            
            unit = "";
            switch (unitComboBox.Text)
            {
                case "HLK":
                    unit = "HLK";
                    break;
                case "HV 136° 10":
                    unit = "HV136";
                    break;
                case "HB 10 3000":
                    unit = "HB10";
                    break;
                case "HRA 120° 60":
                    unit = "HRA120";
                    break;
                case "HRB 1/16\" 100":
                    unit = "HRB1o16";
                    break;
                case "HRC 120° 150":
                    unit = "HRC120";
                    break;
                case "HRD 120° 100":
                    unit = "HRD120";
                    break;
                case "HRF 1/16\" 60":
                    unit = "HRF1o16";
                    break;
                case "HR15N 120° 15":
                    unit = "HR15N";
                    break;
                case "HR30N 120° 45":
                    unit = "HR30N";
                    break;
                case "HR45N 120° 45":
                    unit = "HR45N";
                    break;
                case "HR15T 1/16\" 15":
                    unit = "HR15T";
                    break;
                case "HR30T 1/16\" 30":
                    unit = "HR30T";
                    break;
                case "HR45T 1/16\" 45":
                    unit = "HR45T";
                    break;
                case "HSc":
                    unit = "HSc";
                    break;
                case "N/mm2":
                    unit = "Nomm2";
                    break;

            }


            DataTable x = new DataTable();
            x =   DAOClass.GetRow(unit, Double.Parse(this.numberEntry.Text));
            try {

                hlk.Text = x.Rows[0][0].ToString();
                hv136.Text = x.Rows[0][1].ToString();
                hb10.Text = x.Rows[0][2].ToString();
                hra120.Text = x.Rows[0][3].ToString();
                hrb1o16.Text = x.Rows[0][4].ToString();
                hrc120.Text = x.Rows[0][5].ToString();
                hrd120.Text = x.Rows[0][6].ToString();
                hrf1o16.Text = x.Rows[0][7].ToString();
                hr15n.Text = x.Rows[0][8].ToString();
                hr30n.Text = x.Rows[0][9].ToString();
                hr45n.Text = x.Rows[0][10].ToString();
                hr15t.Text = x.Rows[0][11].ToString();
                hr30t.Text = x.Rows[0][12].ToString();
                hr45t.Text = x.Rows[0][13].ToString();
                hsc.Text = x.Rows[0][14].ToString();
                nmm2.Text = x.Rows[0][15].ToString();

            }
            catch(IndexOutOfRangeException ex)
            {
                
                
                DataTable lower = DAOClass.GetLower(double.Parse(this.numberEntry.Text), unit);
                DataTable higher = DAOClass.GetHigher(double.Parse(this.numberEntry.Text), unit);
                var lowerArray = lower.Rows[0].ItemArray.Select(z => z.ToString()).ToArray();
                var higherArray = higher.Rows[0].ItemArray.Select(z => z.ToString()).ToArray();
                double[] da = DAOClass.RowCreator(higherArray, lowerArray, double.Parse(this.numberEntry.Text));

                hlk.Text = da[0].ToString();
                hv136.Text = da[1].ToString();
                hb10.Text = da[2].ToString();
                hra120.Text = da[3].ToString();
                hrb1o16.Text = da[4].ToString();
                hrc120.Text = da[5].ToString();
                hrd120.Text = da[6].ToString();
                hrf1o16.Text = da[7].ToString();
                hr15n.Text = da[8].ToString();
                hr30n.Text = da[9].ToString();
                hr45n.Text = da[10].ToString();
                hr15t.Text = da[11].ToString();
                hr30t.Text = da[12].ToString();
                hr45t.Text = da[13].ToString();
                hsc.Text = da[14].ToString();
                nmm2.Text = da[15].ToString();

            }

           


        }
    }

}


