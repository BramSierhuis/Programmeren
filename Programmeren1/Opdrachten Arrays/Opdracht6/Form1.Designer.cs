namespace Opdracht6
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblVooraf = new System.Windows.Forms.Label();
            this.lblAchteraf = new System.Windows.Forms.Label();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVergelijk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inhoud tabel (vooraf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhoud tabel (achteraf)";
            // 
            // lblVooraf
            // 
            this.lblVooraf.AutoSize = true;
            this.lblVooraf.Location = new System.Drawing.Point(16, 43);
            this.lblVooraf.Name = "lblVooraf";
            this.lblVooraf.Size = new System.Drawing.Size(46, 17);
            this.lblVooraf.TabIndex = 2;
            this.lblVooraf.Text = "label3";
            // 
            // lblAchteraf
            // 
            this.lblAchteraf.AutoSize = true;
            this.lblAchteraf.Location = new System.Drawing.Point(217, 43);
            this.lblAchteraf.Name = "lblAchteraf";
            this.lblAchteraf.Size = new System.Drawing.Size(0, 17);
            this.lblAchteraf.TabIndex = 3;
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(217, 478);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(100, 22);
            this.txtGetal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vergelijkings getal";
            // 
            // btnVergelijk
            // 
            this.btnVergelijk.Location = new System.Drawing.Point(337, 478);
            this.btnVergelijk.Name = "btnVergelijk";
            this.btnVergelijk.Size = new System.Drawing.Size(125, 23);
            this.btnVergelijk.TabIndex = 6;
            this.btnVergelijk.Text = "Vergelijk";
            this.btnVergelijk.UseVisualStyleBackColor = true;
            this.btnVergelijk.Click += new System.EventHandler(this.btnVergelijk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 512);
            this.Controls.Add(this.btnVergelijk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.lblAchteraf);
            this.Controls.Add(this.lblVooraf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVooraf;
        private System.Windows.Forms.Label lblAchteraf;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVergelijk;
    }
}

