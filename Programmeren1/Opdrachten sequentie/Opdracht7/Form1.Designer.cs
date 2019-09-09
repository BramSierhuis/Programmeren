namespace Opdracht7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeginKM = new System.Windows.Forms.TextBox();
            this.txtEindKM = new System.Windows.Forms.TextBox();
            this.txtPrijsPerKM = new System.Windows.Forms.TextBox();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnBedragen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExBtw = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblIncBtw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin KM";
            // 
            // txtBeginKM
            // 
            this.txtBeginKM.Location = new System.Drawing.Point(101, 13);
            this.txtBeginKM.Name = "txtBeginKM";
            this.txtBeginKM.Size = new System.Drawing.Size(100, 20);
            this.txtBeginKM.TabIndex = 1;
            // 
            // txtEindKM
            // 
            this.txtEindKM.Location = new System.Drawing.Point(101, 40);
            this.txtEindKM.Name = "txtEindKM";
            this.txtEindKM.Size = new System.Drawing.Size(100, 20);
            this.txtEindKM.TabIndex = 2;
            // 
            // txtPrijsPerKM
            // 
            this.txtPrijsPerKM.Location = new System.Drawing.Point(101, 67);
            this.txtPrijsPerKM.Name = "txtPrijsPerKM";
            this.txtPrijsPerKM.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerKM.TabIndex = 3;
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(219, 11);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 4;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnBedragen
            // 
            this.btnBedragen.Location = new System.Drawing.Point(219, 65);
            this.btnBedragen.Name = "btnBedragen";
            this.btnBedragen.Size = new System.Drawing.Size(75, 23);
            this.btnBedragen.TabIndex = 5;
            this.btnBedragen.Text = "Bedragen";
            this.btnBedragen.UseVisualStyleBackColor = true;
            this.btnBedragen.Click += new System.EventHandler(this.btnBedragen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eind KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prijs per KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prijs excl. BTW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BTW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prijs incl. BTW";
            // 
            // lblExBtw
            // 
            this.lblExBtw.AutoSize = true;
            this.lblExBtw.Location = new System.Drawing.Point(20, 179);
            this.lblExBtw.Name = "lblExBtw";
            this.lblExBtw.Size = new System.Drawing.Size(35, 13);
            this.lblExBtw.TabIndex = 11;
            this.lblExBtw.Text = "label7";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(101, 179);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(35, 13);
            this.lblBtw.TabIndex = 12;
            this.lblBtw.Text = "label8";
            // 
            // lblIncBtw
            // 
            this.lblIncBtw.AutoSize = true;
            this.lblIncBtw.Location = new System.Drawing.Point(219, 179);
            this.lblIncBtw.Name = "lblIncBtw";
            this.lblIncBtw.Size = new System.Drawing.Size(35, 13);
            this.lblIncBtw.TabIndex = 13;
            this.lblIncBtw.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncBtw);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblExBtw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBedragen);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.txtPrijsPerKM);
            this.Controls.Add(this.txtEindKM);
            this.Controls.Add(this.txtBeginKM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequentie - Opdracht7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeginKM;
        private System.Windows.Forms.TextBox txtEindKM;
        private System.Windows.Forms.TextBox txtPrijsPerKM;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnBedragen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExBtw;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblIncBtw;
    }
}

