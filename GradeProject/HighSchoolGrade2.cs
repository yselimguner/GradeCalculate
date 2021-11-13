using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeProject
{
    public partial class HighSchoolGrade2 : Form
    {
        public HighSchoolGrade2()
        {
            InitializeComponent();
        }

        private void btnHigh2_Click(object sender, EventArgs e)
        {
            double firstvalue = Convert.ToDouble(tbHigh21.Text);
            
            double secondvalue = Convert.ToDouble(tbHigh22.Text);
            double firstpercent = Convert.ToDouble(tbHigh23.Text);
            if (firstpercent <= 100 && firstpercent > 0 == true)
            {

            }
            else
            {
                MessageBox.Show("Please enter value between 0 and 100");
            }
            double secondpercent = Convert.ToDouble(tbHigh24.Text);
            if (secondpercent <= 100 && secondpercent > 0 == true) 
            {

            }
            else
            {
                MessageBox.Show("Please enter value between 0 and 100");
            }
            double a = firstpercent + secondpercent;
            if (a == 100)
            {
                double result2 = (firstvalue * (firstpercent / 100)) + (secondvalue * (secondpercent / 100));
                if (result2 > 0 && result2 < 45)
                {
                    MessageBox.Show("Average point is " + result2 + "." + " Your Grade is 1");
                }
                else if (result2 >= 45 && result2 < 55)
                {
                    MessageBox.Show("Average point is " + result2 + "." + " Your Grade is 2");
                }
                else if (result2 >= 55 && result2 < 70)
                {
                    MessageBox.Show("Average point is " + result2 + "." + " Your Grade is 3");
                }
                else if (result2 >= 70 && result2 < 85)
                {
                    MessageBox.Show("Average point is " + result2 + "." + " Your Grade is 4");
                }
                else if (result2 >= 85 && result2 < 100)
                {
                    MessageBox.Show("Average point is " + result2 + "." + " Your Grade is 5");
                }
                else
                {
                    MessageBox.Show("Please put in logical numbers.");
                }
            }
            else
            {
                MessageBox.Show("Your Midterm and Final degree total must be 100");
            }

            

            


        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGrade fr6 = new MainGrade();
            fr6.Show();
        }

        private void tbHigh21_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHigh22_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHigh23_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHigh24_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
