
namespace GradeProject
{
    partial class HighSchoolGrade1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.tbHigh13 = new System.Windows.Forms.TextBox();
            this.tbHigh12 = new System.Windows.Forms.TextBox();
            this.tbHigh11 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHigh11 = new System.Windows.Forms.Label();
            this.btnCalHigh1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset1);
            this.groupBox1.Controls.Add(this.tbHigh13);
            this.groupBox1.Controls.Add(this.tbHigh12);
            this.groupBox1.Controls.Add(this.tbHigh11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblHigh11);
            this.groupBox1.Controls.Add(this.btnCalHigh1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(68, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Calculate";
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(240, 172);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(63, 29);
            this.btnReset1.TabIndex = 5;
            this.btnReset1.Text = "Exit";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // tbHigh13
            // 
            this.tbHigh13.Location = new System.Drawing.Point(110, 114);
            this.tbHigh13.Name = "tbHigh13";
            this.tbHigh13.Size = new System.Drawing.Size(100, 29);
            this.tbHigh13.TabIndex = 3;
            this.tbHigh13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHigh13_KeyPress);
            // 
            // tbHigh12
            // 
            this.tbHigh12.Location = new System.Drawing.Point(110, 75);
            this.tbHigh12.Name = "tbHigh12";
            this.tbHigh12.Size = new System.Drawing.Size(100, 29);
            this.tbHigh12.TabIndex = 2;
            this.tbHigh12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHigh12_KeyPress);
            // 
            // tbHigh11
            // 
            this.tbHigh11.Location = new System.Drawing.Point(110, 36);
            this.tbHigh11.Name = "tbHigh11";
            this.tbHigh11.Size = new System.Drawing.Size(100, 29);
            this.tbHigh11.TabIndex = 1;
            this.tbHigh11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHigh11_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Point:";
            // 
            // lblHigh11
            // 
            this.lblHigh11.AutoSize = true;
            this.lblHigh11.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.lblHigh11.Location = new System.Drawing.Point(32, 39);
            this.lblHigh11.Name = "lblHigh11";
            this.lblHigh11.Size = new System.Drawing.Size(71, 19);
            this.lblHigh11.TabIndex = 1;
            this.lblHigh11.Text = "First Point:";
            // 
            // btnCalHigh1
            // 
            this.btnCalHigh1.Location = new System.Drawing.Point(110, 166);
            this.btnCalHigh1.Name = "btnCalHigh1";
            this.btnCalHigh1.Size = new System.Drawing.Size(86, 29);
            this.btnCalHigh1.TabIndex = 4;
            this.btnCalHigh1.Text = "Calculate";
            this.btnCalHigh1.UseVisualStyleBackColor = true;
            this.btnCalHigh1.Click += new System.EventHandler(this.btnCalHigh1_Click);
            // 
            // HighSchoolGrade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "HighSchoolGrade1";
            this.Text = "HighSchoolGrade1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbHigh13;
        private System.Windows.Forms.TextBox tbHigh12;
        private System.Windows.Forms.TextBox tbHigh11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHigh11;
        private System.Windows.Forms.Button btnCalHigh1;
        private System.Windows.Forms.Button btnReset1;
    }
}