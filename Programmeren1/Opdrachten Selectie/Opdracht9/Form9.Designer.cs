namespace Opdracht9
{
    partial class Form9
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
            this.sport = new System.Windows.Forms.Label();
            this.rBtnFootball = new System.Windows.Forms.RadioButton();
            this.rBtnHandball = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sport
            // 
            this.sport.AutoSize = true;
            this.sport.Location = new System.Drawing.Point(13, 13);
            this.sport.Name = "sport";
            this.sport.Size = new System.Drawing.Size(32, 13);
            this.sport.TabIndex = 0;
            this.sport.Text = "Sport";
            // 
            // rBtnFootball
            // 
            this.rBtnFootball.AutoSize = true;
            this.rBtnFootball.Checked = true;
            this.rBtnFootball.Location = new System.Drawing.Point(167, 13);
            this.rBtnFootball.Name = "rBtnFootball";
            this.rBtnFootball.Size = new System.Drawing.Size(62, 17);
            this.rBtnFootball.TabIndex = 1;
            this.rBtnFootball.TabStop = true;
            this.rBtnFootball.Text = "Football";
            this.rBtnFootball.UseVisualStyleBackColor = true;
            // 
            // rBtnHandball
            // 
            this.rBtnHandball.AutoSize = true;
            this.rBtnHandball.Location = new System.Drawing.Point(167, 37);
            this.rBtnHandball.Name = "rBtnHandball";
            this.rBtnHandball.Size = new System.Drawing.Size(67, 17);
            this.rBtnHandball.TabIndex = 2;
            this.rBtnHandball.TabStop = true;
            this.rBtnHandball.Text = "Handball";
            this.rBtnHandball.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Membership duration";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(167, 78);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(167, 105);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(251, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Fee";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fee to be paid";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(167, 185);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(25, 13);
            this.lblFee.TabIndex = 9;
            this.lblFee.Text = "€-,--";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 219);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnHandball);
            this.Controls.Add(this.rBtnFootball);
            this.Controls.Add(this.sport);
            this.Name = "Form9";
            this.Text = "Opdracht 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sport;
        private System.Windows.Forms.RadioButton rBtnFootball;
        private System.Windows.Forms.RadioButton rBtnHandball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFee;
    }
}

