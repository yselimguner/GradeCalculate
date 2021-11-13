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
    public partial class HighSchoolGrade1 : Form
    {
        public HighSchoolGrade1()
        {
            InitializeComponent();
        }

        private void btnCalHigh1_Click(object sender, EventArgs e)
        {
            double firstvalue = Convert.ToDouble(tbHigh11.Text);
            double secondvalue = Convert.ToDouble(tbHigh12.Text);
            double thirdvalue = Convert.ToDouble(tbHigh13.Text);

            double result1 = (firstvalue + secondvalue + thirdvalue) / 3;
            if (result1 > 0 && result1 < 45)
            {
                MessageBox.Show("Average point is "+result1+"."+" Your Grade is 1");
            }
            else if (result1 >= 45 && result1 < 55)
            {
                MessageBox.Show("Average point is " + result1 +"."+ " Your Grade is 2");
            }
            else if (result1 >= 55 && result1 < 70)
            {
                MessageBox.Show("Average point is " + result1 +"."+" Your Grade is 3");
            }
            else if (result1 >= 70 && result1 < 85)
            {
                MessageBox.Show("Average point is " + result1 +"."+" Your Grade is 4");
            }
            else if (result1 >= 85 && result1 < 100)
            {
                MessageBox.Show("Average point is " + result1 +"."+" Your Grade is 5");
            }
            else
            {
                MessageBox.Show("Please put in logical numbers.");
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGrade fr6 = new MainGrade();
            fr6.Show();
        }

        private void tbHigh11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHigh12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHigh13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
