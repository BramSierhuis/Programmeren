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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnCtoK = new System.Windows.Forms.RadioButton();
            this.rBtnCtoF = new System.Windows.Forms.RadioButton();
            this.rBtnFtoC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graden";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnFtoC);
            this.groupBox1.Controls.Add(this.rBtnCtoF);
            this.groupBox1.Controls.Add(this.rBtnCtoK);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Omrekenen";
            // 
            // rBtnCtoK
            // 
            this.rBtnCtoK.AutoSize = true;
            this.rBtnCtoK.Location = new System.Drawing.Point(18, 21);
            this.rBtnCtoK.Name = "rBtnCtoK";
            this.rBtnCtoK.Size = new System.Drawing.Size(176, 21);
            this.rBtnCtoK.TabIndex = 0;
            this.rBtnCtoK.TabStop = true;
            this.rBtnCtoK.Text = "van Celcius naar Kelvin";
            this.rBtnCtoK.UseVisualStyleBackColor = true;
            // 
            // rBtnCtoF
            // 
            this.rBtnCtoF.AutoSize = true;
            this.rBtnCtoF.Location = new System.Drawing.Point(18, 49);
            this.rBtnCtoF.Name = "rBtnCtoF";
            this.rBtnCtoF.Size = new System.Drawing.Size(210, 21);
            this.rBtnCtoF.TabIndex = 1;
            this.rBtnCtoF.TabStop = true;
            this.rBtnCtoF.Text = "van Celcius naar Fahrenheid";
            this.rBtnCtoF.UseVisualStyleBackColor = true;
            // 
            // rBtnFtoC
            // 
            this.rBtnFtoC.AutoSize = true;
            this.rBtnFtoC.Location = new System.Drawing.Point(18, 77);
            this.rBtnFtoC.Name = "rBtnFtoC";
            this.rBtnFtoC.Size = new System.Drawing.Size(210, 21);
            this.rBtnFtoC.TabIndex = 2;
            this.rBtnFtoC.TabStop = true;
            this.rBtnFtoC.Text = "van Fahrenheid naar Celcius";
            this.rBtnFtoC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bereken nieuwe graden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nieuwe graden";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(171, 181);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(46, 17);
            this.lblUitkomst.TabIndex = 4;
            this.lblUitkomst.Text = "label3";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(174, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(87, 22);
            this.txtInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 216);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnFtoC;
        private System.Windows.Forms.RadioButton rBtnCtoF;
        private System.Windows.Forms.RadioButton rBtnCtoK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.TextBox txtInput;
    }
}

