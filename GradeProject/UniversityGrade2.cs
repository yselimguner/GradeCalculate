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
    public partial class UniversityGrade2 : Form
    {
        public UniversityGrade2()
        {
            InitializeComponent();
        }

        private void btnUni2_Click(object sender, EventArgs e)
        {
            double firstvalue2 = Convert.ToDouble(tbUni21.Text);
            double secondvalue2 = Convert.ToDouble(tbUni22.Text);
            double firstpercent2 = Convert.ToDouble(tbUni23.Text);
            double secondpercent2 = Convert.ToDouble(tbUni24.Text);
            double a = firstpercent2 + secondpercent2;
            if (firstpercent2+secondpercent2==100)
            {
                double result4 = (firstvalue2 * (firstpercent2 / 100)) + (secondvalue2 * (secondpercent2 / 100));
                if (result4 > 0 && result4 < 50)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is FF");
                }
                else if (result4 >= 50 && result4 < 55)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is FD");
                }
                else if (result4 >= 55 && result4 < 60)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is DD");
                }
                else if (result4 >= 60 && result4 < 65)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is DC");
                }
                else if (result4 >= 65 && result4 < 75)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is CC");
                }
                else if (result4 >= 75 && result4 < 80)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is CB");
                }
                else if (result4 >= 80 && result4 < 85)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is BB");
                }
                else if (result4 >= 85 && result4 < 90)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is BA");
                }
                else if (result4 >= 90 && result4 <= 100)
                {
                    MessageBox.Show("Average point is " + result4 + "." + " Your Grade is AA");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGrade fr6 = new MainGrade();
            fr6.Show();
        }

        private void tbUni21_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUni22_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUni23_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUni24_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
