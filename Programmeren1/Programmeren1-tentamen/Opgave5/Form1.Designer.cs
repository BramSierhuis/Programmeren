namespace Opgave5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBtnTweede = new System.Windows.Forms.RadioButton();
            this.rBtnEerste = new System.Windows.Forms.RadioButton();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtRailrunner = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Railrunner:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prijs:";
            // 
            // rBtnTweede
            // 
            this.rBtnTweede.AutoSize = true;
            this.rBtnTweede.Checked = true;
            this.rBtnTweede.Location = new System.Drawing.Point(118, 13);
            this.rBtnTweede.Name = "rBtnTweede";
            this.rBtnTweede.Size = new System.Drawing.Size(89, 21);
            this.rBtnTweede.TabIndex = 4;
            this.rBtnTweede.TabStop = true;
            this.rBtnTweede.Text = "2e klasse";
            this.rBtnTweede.UseVisualStyleBackColor = true;
            // 
            // rBtnEerste
            // 
            this.rBtnEerste.AutoSize = true;
            this.rBtnEerste.Location = new System.Drawing.Point(242, 13);
            this.rBtnEerste.Name = "rBtnEerste";
            this.rBtnEerste.Size = new System.Drawing.Size(89, 21);
            this.rBtnEerste.TabIndex = 5;
            this.rBtnEerste.TabStop = true;
            this.rBtnEerste.Text = "1e klasse";
            this.rBtnEerste.UseVisualStyleBackColor = true;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(118, 49);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(100, 22);
            this.txtAantal.TabIndex = 6;
            this.txtAantal.Text = "0";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(118, 122);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtRailrunner
            // 
            this.txtRailrunner.Location = new System.Drawing.Point(118, 78);
            this.txtRailrunner.Name = "txtRailrunner";
            this.txtRailrunner.Size = new System.Drawing.Size(100, 22);
            this.txtRailrunner.TabIndex = 8;
            this.txtRailrunner.Text = "0";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Enabled = false;
            this.txtPrijs.Location = new System.Drawing.Point(118, 152);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 22);
            this.txtPrijs.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 199);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtRailrunner);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.rBtnEerste);
            this.Controls.Add(this.rBtnTweede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NS Dagkaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBtnTweede;
        private System.Windows.Forms.RadioButton rBtnEerste;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtRailrunner;
        private System.Windows.Forms.TextBox txtPrijs;
    }
}

