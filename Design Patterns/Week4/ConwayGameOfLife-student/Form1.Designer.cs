﻿namespace ConwayGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStandardLife = new System.Windows.Forms.Button();
            this.btnHighLife = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(12, 702);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(141, 37);
            this.btnResetGame.TabIndex = 0;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStandardLife
            // 
            this.btnStandardLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandardLife.Location = new System.Drawing.Point(1137, 702);
            this.btnStandardLife.Name = "btnStandardLife";
            this.btnStandardLife.Size = new System.Drawing.Size(172, 37);
            this.btnStandardLife.TabIndex = 1;
            this.btnStandardLife.Text = "Play StandardLife";
            this.btnStandardLife.UseVisualStyleBackColor = true;
            this.btnStandardLife.Click += new System.EventHandler(this.btnStandardLife_Click);
            // 
            // btnHighLife
            // 
            this.btnHighLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighLife.Location = new System.Drawing.Point(1315, 702);
            this.btnHighLife.Name = "btnHighLife";
            this.btnHighLife.Size = new System.Drawing.Size(172, 37);
            this.btnHighLife.TabIndex = 2;
            this.btnHighLife.Text = "Play HighLife";
            this.btnHighLife.UseVisualStyleBackColor = true;
            this.btnHighLife.Click += new System.EventHandler(this.btnHighLife_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 751);
            this.Controls.Add(this.btnHighLife);
            this.Controls.Add(this.btnStandardLife);
            this.Controls.Add(this.btnResetGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Conway\'s Game Of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnStandardLife;
        private System.Windows.Forms.Button btnHighLife;
    }
}

