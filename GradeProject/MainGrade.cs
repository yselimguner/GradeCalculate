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
    public partial class MainGrade : Form
    {
        public MainGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdBtnHigh.Checked==true)
            {
                this.Hide();
                HighSchoolGrade1 fr2 = new HighSchoolGrade1();
                fr2.Show();
            }
            else if(rdBtnHigh2.Checked==true)
            {
                this.Hide();
                HighSchoolGrade2 fr3 = new HighSchoolGrade2();
                fr3.Show();
            }
            else if(rdBtnUni1.Checked==true)
            {
                this.Hide();
                UniversityGrade1 fr4 = new UniversityGrade1();
                fr4.Show();
            }
            else if(rdBtnUni2.Checked==true)
            {
                this.Hide();
                UniversityGrade2 fr5 = new UniversityGrade2();
                fr5.Show();
            }
            
        }
    }
}
