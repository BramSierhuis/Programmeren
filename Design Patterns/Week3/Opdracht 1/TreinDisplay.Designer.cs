namespace Opdracht_1
{
    partial class TreinDisplay
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHuidigStation = new System.Windows.Forms.Label();
            this.lblVolgendStation = new System.Windows.Forms.Label();
            this.lblAankomsttijd = new System.Windows.Forms.Label();
            this.lblAankomstSpoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidig station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volgend station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aankomsttijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aankomststspoor";
            // 
            // lblHuidigStation
            // 
            this.lblHuidigStation.AutoSize = true;
            this.lblHuidigStation.Location = new System.Drawing.Point(161, 13);
            this.lblHuidigStation.Name = "lblHuidigStation";
            this.lblHuidigStation.Size = new System.Drawing.Size(35, 13);
            this.lblHuidigStation.TabIndex = 4;
            this.lblHuidigStation.Text = "label5";
            // 
            // lblVolgendStation
            // 
            this.lblVolgendStation.AutoSize = true;
            this.lblVolgendStation.Location = new System.Drawing.Point(161, 47);
            this.lblVolgendStation.Name = "lblVolgendStation";
            this.lblVolgendStation.Size = new System.Drawing.Size(35, 13);
            this.lblVolgendStation.TabIndex = 5;
            this.lblVolgendStation.Text = "label6";
            // 
            // lblAankomsttijd
            // 
            this.lblAankomsttijd.AutoSize = true;
            this.lblAankomsttijd.Location = new System.Drawing.Point(161, 64);
            this.lblAankomsttijd.Name = "lblAankomsttijd";
            this.lblAankomsttijd.Size = new System.Drawing.Size(35, 13);
            this.lblAankomsttijd.TabIndex = 6;
            this.lblAankomsttijd.Text = "label5";
            // 
            // lblAankomstSpoor
            // 
            this.lblAankomstSpoor.AutoSize = true;
            this.lblAankomstSpoor.Location = new System.Drawing.Point(161, 81);
            this.lblAankomstSpoor.Name = "lblAankomstSpoor";
            this.lblAankomstSpoor.Size = new System.Drawing.Size(35, 13);
            this.lblAankomstSpoor.TabIndex = 7;
            this.lblAankomstSpoor.Text = "label5";
            // 
            // TreinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 112);
            this.Controls.Add(this.lblAankomstSpoor);
            this.Controls.Add(this.lblAankomsttijd);
            this.Controls.Add(this.lblVolgendStation);
            this.Controls.Add(this.lblHuidigStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TreinDisplay";
            this.Text = "TreinDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHuidigStation;
        private System.Windows.Forms.Label lblVolgendStation;
        private System.Windows.Forms.Label lblAankomsttijd;
        private System.Windows.Forms.Label lblAankomstSpoor;
    }
}