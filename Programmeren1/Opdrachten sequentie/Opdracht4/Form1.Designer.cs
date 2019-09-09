namespace Opdracht4
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
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef prijs:";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(147, 22);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(18, 59);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(229, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken BTW";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BTW:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Totaal prijs:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(211, 115);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblPrijs.TabIndex = 6;
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(210, 143);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBtw.Size = new System.Drawing.Size(0, 13);
            this.lblBtw.TabIndex = 7;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(209, 172);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotaal.Size = new System.Drawing.Size(0, 13);
            this.lblTotaal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 208);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequentie - Opdracht 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblTotaal;
    }
}

