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
            this.txtSeconden = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconden:";
            // 
            // txtSeconden
            // 
            this.txtSeconden.Location = new System.Drawing.Point(95, 13);
            this.txtSeconden.Name = "txtSeconden";
            this.txtSeconden.Size = new System.Drawing.Size(100, 20);
            this.txtSeconden.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(16, 49);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(179, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken tijd";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "uren : minuten : seconden";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(39, 128);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 182);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtSeconden);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequentie - Opdracht6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeconden;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplay;
    }
}

