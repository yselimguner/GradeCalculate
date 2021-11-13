
namespace GradeProject
{
    partial class MainGrade
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnHigh2 = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rdBtnUni2 = new System.Windows.Forms.RadioButton();
            this.rdBtnUni1 = new System.Windows.Forms.RadioButton();
            this.rdBtnHigh = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnHigh2);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.rdBtnUni2);
            this.groupBox1.Controls.Add(this.rdBtnUni1);
            this.groupBox1.Controls.Add(this.rdBtnHigh);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(75, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Calculate";
            // 
            // rdBtnHigh2
            // 
            this.rdBtnHigh2.AutoSize = true;
            this.rdBtnHigh2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnHigh2.Location = new System.Drawing.Point(16, 64);
            this.rdBtnHigh2.Name = "rdBtnHigh2";
            this.rdBtnHigh2.Size = new System.Drawing.Size(141, 23);
            this.rdBtnHigh2.TabIndex = 2;
            this.rdBtnHigh2.TabStop = true;
            this.rdBtnHigh2.Text = "High School Grade 2";
            this.rdBtnHigh2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(123, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 57);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "GO  TO CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rdBtnUni2
            // 
            this.rdBtnUni2.AutoSize = true;
            this.rdBtnUni2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnUni2.Location = new System.Drawing.Point(197, 64);
            this.rdBtnUni2.Name = "rdBtnUni2";
            this.rdBtnUni2.Size = new System.Drawing.Size(133, 23);
            this.rdBtnUni2.TabIndex = 4;
            this.rdBtnUni2.TabStop = true;
            this.rdBtnUni2.Text = "University Grade 2";
            this.rdBtnUni2.UseVisualStyleBackColor = true;
            // 
            // rdBtnUni1
            // 
            this.rdBtnUni1.AutoSize = true;
            this.rdBtnUni1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnUni1.Location = new System.Drawing.Point(197, 40);
            this.rdBtnUni1.Name = "rdBtnUni1";
            this.rdBtnUni1.Size = new System.Drawing.Size(133, 23);
            this.rdBtnUni1.TabIndex = 3;
            this.rdBtnUni1.TabStop = true;
            this.rdBtnUni1.Text = "University Grade 1";
            this.rdBtnUni1.UseVisualStyleBackColor = true;
            // 
            // rdBtnHigh
            // 
            this.rdBtnHigh.AutoSize = true;
            this.rdBtnHigh.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnHigh.Location = new System.Drawing.Point(16, 40);
            this.rdBtnHigh.Name = "rdBtnHigh";
            this.rdBtnHigh.Size = new System.Drawing.Size(141, 23);
            this.rdBtnHigh.TabIndex = 1;
            this.rdBtnHigh.TabStop = true;
            this.rdBtnHigh.Text = "High School Grade 1";
            this.rdBtnHigh.UseVisualStyleBackColor = true;
            // 
            // MainGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainGrade";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnHigh2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rdBtnUni2;
        private System.Windows.Forms.RadioButton rdBtnUni1;
        private System.Windows.Forms.RadioButton rdBtnHigh;
    }
}

