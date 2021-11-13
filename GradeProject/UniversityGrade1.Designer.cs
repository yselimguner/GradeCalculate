
namespace GradeProject
{
    partial class UniversityGrade1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUni12 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUni11 = new System.Windows.Forms.Label();
            this.btnCalUni1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUni11 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUni12
            // 
            this.tbUni12.Location = new System.Drawing.Point(110, 99);
            this.tbUni12.Name = "tbUni12";
            this.tbUni12.Size = new System.Drawing.Size(100, 29);
            this.tbUni12.TabIndex = 2;
            this.tbUni12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUni12_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final Exam:";
            // 
            // lblUni11
            // 
            this.lblUni11.AutoSize = true;
            this.lblUni11.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.lblUni11.Location = new System.Drawing.Point(9, 70);
            this.lblUni11.Name = "lblUni11";
            this.lblUni11.Size = new System.Drawing.Size(95, 19);
            this.lblUni11.TabIndex = 1;
            this.lblUni11.Text = "Midterm Exam:";
            // 
            // btnCalUni1
            // 
            this.btnCalUni1.Location = new System.Drawing.Point(110, 161);
            this.btnCalUni1.Name = "btnCalUni1";
            this.btnCalUni1.Size = new System.Drawing.Size(86, 34);
            this.btnCalUni1.TabIndex = 3;
            this.btnCalUni1.Text = "Calculate";
            this.btnCalUni1.UseVisualStyleBackColor = true;
            this.btnCalUni1.Click += new System.EventHandler(this.btnCalUni1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUni12);
            this.groupBox1.Controls.Add(this.tbUni11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUni11);
            this.groupBox1.Controls.Add(this.btnCalUni1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(108, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Calculate";
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(250, 183);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(63, 29);
            this.btnReset3.TabIndex = 4;
            this.btnReset3.Text = "Exit";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOTICE: While calculating the grade, were taken \r\n30% of the midterm exam and 70%" +
    " of the final exam";
            // 
            // tbUni11
            // 
            this.tbUni11.Location = new System.Drawing.Point(110, 60);
            this.tbUni11.Name = "tbUni11";
            this.tbUni11.Size = new System.Drawing.Size(100, 29);
            this.tbUni11.TabIndex = 1;
            this.tbUni11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUni11_KeyPress);
            // 
            // UniversityGrade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "UniversityGrade1";
            this.Text = "UniversityGrade1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUni12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUni11;
        private System.Windows.Forms.Button btnCalUni1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUni11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset3;
    }
}