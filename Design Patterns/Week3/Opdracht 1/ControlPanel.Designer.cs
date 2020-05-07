namespace Opdracht_1
{
    partial class ControlPanel
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
            this.btnVolgendStation = new System.Windows.Forms.Button();
            this.btnNieuwDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolgendStation
            // 
            this.btnVolgendStation.Location = new System.Drawing.Point(84, 37);
            this.btnVolgendStation.Name = "btnVolgendStation";
            this.btnVolgendStation.Size = new System.Drawing.Size(107, 44);
            this.btnVolgendStation.TabIndex = 0;
            this.btnVolgendStation.Text = "Volgend Station";
            this.btnVolgendStation.UseVisualStyleBackColor = true;
            this.btnVolgendStation.Click += new System.EventHandler(this.btnVolgendStation_Click);
            // 
            // btnNieuwDisplay
            // 
            this.btnNieuwDisplay.Location = new System.Drawing.Point(84, 87);
            this.btnNieuwDisplay.Name = "btnNieuwDisplay";
            this.btnNieuwDisplay.Size = new System.Drawing.Size(107, 23);
            this.btnNieuwDisplay.TabIndex = 1;
            this.btnNieuwDisplay.Text = "Nieuw display";
            this.btnNieuwDisplay.UseVisualStyleBackColor = true;
            this.btnNieuwDisplay.Click += new System.EventHandler(this.btnNieuwDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 167);
            this.Controls.Add(this.btnNieuwDisplay);
            this.Controls.Add(this.btnVolgendStation);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolgendStation;
        private System.Windows.Forms.Button btnNieuwDisplay;
    }
}

