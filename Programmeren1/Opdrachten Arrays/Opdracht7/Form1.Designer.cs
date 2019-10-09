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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btnGooien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Aantal keer 1 ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 34);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Aantal keer 2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(13, 55);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(92, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Aantal keer 3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(13, 76);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(92, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Aantal keer 4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(13, 97);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(92, 17);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Aantal keer 5";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(13, 118);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(92, 17);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Aantal keer 6";
            // 
            // btnGooien
            // 
            this.btnGooien.Location = new System.Drawing.Point(16, 148);
            this.btnGooien.Name = "btnGooien";
            this.btnGooien.Size = new System.Drawing.Size(213, 23);
            this.btnGooien.TabIndex = 6;
            this.btnGooien.Text = "Gooien!";
            this.btnGooien.UseVisualStyleBackColor = true;
            this.btnGooien.Click += new System.EventHandler(this.btnGooien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 180);
            this.Controls.Add(this.btnGooien);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Opdracht7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btnGooien;
    }
}

