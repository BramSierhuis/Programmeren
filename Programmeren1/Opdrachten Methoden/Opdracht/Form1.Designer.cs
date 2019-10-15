namespace Opdracht
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
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitkomst";
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(16, 44);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(246, 33);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Bereken getal by Reference (REF)";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(16, 84);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(246, 31);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Bereken getal by Reference (OUT)";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(16, 122);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(246, 29);
            this.btnVal.TabIndex = 4;
            this.btnVal.Text = "Bereken getal by Value";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(170, 7);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(92, 22);
            this.txtGetal.TabIndex = 5;
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(170, 171);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(46, 17);
            this.lblUitkomst.TabIndex = 6;
            this.lblUitkomst.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 201);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
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
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label lblUitkomst;
    }
}

