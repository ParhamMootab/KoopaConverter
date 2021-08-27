using KoopaConverter.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoopaConverter2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void hv_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).ReadOnly = false;
            ((TextBox)sender).BackColor = Color.White;
            FocusChange((TextBox)sender, true);


        }

        private void hra_TextChanged(object sender, EventArgs e)
        {

            string hardness = ((TextBox)sender).Tag.ToString();
            string inputNum = ((TextBox)sender).Text.ToString();
            Clear();
            if (inputNum != "")
            {
                double.TryParse(inputNum, out double number);
                rowInTable temp = Calculator.FindRow(number, hardness);
                if (temp != null)
                {
                    DisplayValues(temp);
                }
                else
                {
                    temp = Calculator.GetUnassignedValue(number, hardness);
                    if (temp != null)
                    {
                        ToggleEvent(true);
                        DisplayValues(temp);
                        CheckNull();
                        ((TextBox)sender).Text = inputNum;
                        ((TextBox)sender).SelectionStart = hardness.Length - 1;
                        ((TextBox)sender).SelectionLength = 0;

                        ToggleEvent(false);
                    }
                    else
                    {
                        ToggleEvent(true);
                        CheckNull();
                        ((TextBox)sender).Text = inputNum;
                        ((TextBox)sender).SelectionStart = hardness.Length - 1;
                        ((TextBox)sender).SelectionLength = 0;

                        ToggleEvent(false);
                    }
                }


            }
        }
        private void hv_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ReadOnly = true;
            ((TextBox)sender).BackColor = Color.FromArgb(225, 226, 225);
            Clear();
            FocusChange((TextBox)sender, false);
        }

        private void DisplayValues(rowInTable temp)
        {


            hra.Text = String.Format("{0:N2}", temp.HRA120);
            hrb.Text = String.Format("{0:N2}", temp.HRB1o16);
            hrc.Text = String.Format("{0:N2}", temp.HRC120);
            hrd.Text = String.Format("{0:N2}", temp.HRD120);
            hrf.Text = String.Format("{0:N2}", temp.HRF1o16);
            hr15.Text = String.Format("{0:N2}", temp.HR15N);
            hr30.Text = String.Format("{0:N2}", temp.HR30N);
            hr45.Text = String.Format("{0:N2}", temp.HR45N);
            hr15T.Text = String.Format("{0:N2}", temp.HR15T);
            hr30T.Text = String.Format("{0:N2}", temp.HR30T);
            hr45T.Text = String.Format("{0:N2}", temp.HR45T);
            hv.Text = String.Format("{0:N2}", temp.HV136);
            hb.Text = String.Format("{0:N2}", temp.HB10);
            hld.Text = String.Format("{0:N2}", temp.HLD);
            mpa.Text = String.Format("{0:N2}", temp.Nomm2);
            hsc.Text = String.Format("{0:N2}", temp.HSc);

        }

        private void ToggleEvent(bool flag)
        {
            TextBox[] txtBoxes = { hra, hrb, hrc, hrd, hr15, hr30, hr45,
                    hr15T, hr30T, hr45T, hrf, hld, hsc, mpa, hv, hb };
            if (flag)
            {

                foreach (TextBox textBox in txtBoxes)
                {
                    textBox.TextChanged -= new EventHandler(hra_TextChanged);
                }
            }
            else
            {
                foreach (TextBox textBox in txtBoxes)
                {
                    textBox.TextChanged += new EventHandler(hra_TextChanged);
                }
            }
        }
        private void FocusChange(TextBox clickedTextBox, bool flag)
        {
            customPanel[] panels = { customPanel10, customPanel11, customPanel12, customPanel13, customPanel14, customPanel15, customPanel16, customPanel17, customPanel18, customPanel19, customPanel2, customPanel4, customPanel5, customPanel6, customPanel7, customPanel8 };

            foreach (customPanel panel in panels)
            {
                if (flag)
                {
                    if (clickedTextBox.Tag.ToString().Equals(panel.Tag.ToString()))
                    {
                        panel.IsFocused = true;
                    }
                }
                else
                {
                    panel.IsFocused = false;
                }
            }
        }
        private void CheckNull()
        {
            TextBox[] txtBoxes = { hra, hrb, hrc, hrd, hr15, hr30, hr45,
                    hr15T, hr30T, hr45T, hrf, hld, hsc, mpa, hv, hb };
            string undefined = "---";


            foreach (TextBox textBox in txtBoxes)
            {
                textBox.Text = textBox.Text == "" ? undefined : textBox.Text;
            }
        }
        private void Clear()
        {
            hra.Text = "";
            hrb.Text = "";
            hrc.Text = "";
            hrd.Text = "";
            hrf.Text = "";
            hr15.Text = "";
            hr30.Text = "";
            hr45.Text = "";
            hr15T.Text = "";
            hr30T.Text = "";
            hr45T.Text = "";
            hv.Text = "";
            hb.Text = "";
            hld.Text = "";
            mpa.Text = "";
            hsc.Text = "";
        }

    }
}



