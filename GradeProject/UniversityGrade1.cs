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
    public partial class UniversityGrade1 : Form
    {
        public UniversityGrade1()
        {
            InitializeComponent();
        }

        private void btnCalUni1_Click(object sender, EventArgs e)
        {
            double midterm = Convert.ToDouble(tbUni11.Text);
            double final = Convert.ToDouble(tbUni12.Text);
            double result3 = midterm * 0.3 + final * 0.7;
            if (result3 > 0 && result3 < 50)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is FF");
            }
            else if (result3 >= 50 && result3 < 55)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is FD");
            }
            else if (result3 >= 55 && result3 < 60)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is DD");
            }
            else if (result3 >= 60 && result3 < 65)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is DC");
            }
            else if (result3 >= 65 && result3 < 75)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is CC");
            }
            else if (result3 >= 75 && result3 < 80)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is CB");
            }
            else if (result3 >= 80 && result3 < 85)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is BB");
            }
            else if (result3 >= 85 && result3 < 90)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is BA");
            }
            else if (result3 >= 90 && result3 <= 100)
            {
                MessageBox.Show("Average point is " + result3 + "." + " Your Grade is AA");
            }
            else
            {
                MessageBox.Show("Please put in logical numbers.");
            }
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGrade fr6 = new MainGrade();
            fr6.Show();
        }

        private void tbUni11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUni12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
