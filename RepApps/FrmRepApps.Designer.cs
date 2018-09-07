namespace RepApps
{
    partial class FrmRepApps
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
            this.BtnArea = new System.Windows.Forms.Button();
            this.BtnFahrenheitCelsius = new System.Windows.Forms.Button();
            this.BtnForSum = new System.Windows.Forms.Button();
            this.BtnNestFor = new System.Windows.Forms.Button();
            this.TxtAnswers = new System.Windows.Forms.TextBox();
            this.BtnSteamCharge = new System.Windows.Forms.Button();
            this.BtnGallonsLiters = new System.Windows.Forms.Button();
            this.BtnMileKm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArea
            // 
            this.BtnArea.Location = new System.Drawing.Point(28, 12);
            this.BtnArea.Name = "BtnArea";
            this.BtnArea.Size = new System.Drawing.Size(98, 30);
            this.BtnArea.TabIndex = 0;
            this.BtnArea.Text = "Area of Circle";
            this.BtnArea.UseVisualStyleBackColor = true;
            this.BtnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // BtnFahrenheitCelsius
            // 
            this.BtnFahrenheitCelsius.Location = new System.Drawing.Point(28, 71);
            this.BtnFahrenheitCelsius.Name = "BtnFahrenheitCelsius";
            this.BtnFahrenheitCelsius.Size = new System.Drawing.Size(98, 37);
            this.BtnFahrenheitCelsius.TabIndex = 1;
            this.BtnFahrenheitCelsius.Text = "Celsius to Fahrenheit";
            this.BtnFahrenheitCelsius.UseVisualStyleBackColor = true;
            this.BtnFahrenheitCelsius.Click += new System.EventHandler(this.BtnFahrenheitCelsius_Click);
            // 
            // BtnForSum
            // 
            this.BtnForSum.Location = new System.Drawing.Point(27, 135);
            this.BtnForSum.Name = "BtnForSum";
            this.BtnForSum.Size = new System.Drawing.Size(99, 29);
            this.BtnForSum.TabIndex = 2;
            this.BtnForSum.Text = "Series Sum";
            this.BtnForSum.UseVisualStyleBackColor = true;
            this.BtnForSum.Click += new System.EventHandler(this.BtnForSum_Click);
            // 
            // BtnNestFor
            // 
            this.BtnNestFor.Location = new System.Drawing.Point(28, 193);
            this.BtnNestFor.Name = "BtnNestFor";
            this.BtnNestFor.Size = new System.Drawing.Size(100, 29);
            this.BtnNestFor.TabIndex = 3;
            this.BtnNestFor.Text = "Combination";
            this.BtnNestFor.UseVisualStyleBackColor = true;
            this.BtnNestFor.Click += new System.EventHandler(this.BtnNestFor_Click);
            // 
            // TxtAnswers
            // 
            this.TxtAnswers.Location = new System.Drawing.Point(179, 20);
            this.TxtAnswers.Multiline = true;
            this.TxtAnswers.Name = "TxtAnswers";
            this.TxtAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAnswers.Size = new System.Drawing.Size(157, 201);
            this.TxtAnswers.TabIndex = 4;
            // 
            // BtnSteamCharge
            // 
            this.BtnSteamCharge.Location = new System.Drawing.Point(26, 246);
            this.BtnSteamCharge.Name = "BtnSteamCharge";
            this.BtnSteamCharge.Size = new System.Drawing.Size(100, 29);
            this.BtnSteamCharge.TabIndex = 5;
            this.BtnSteamCharge.Text = "Steam/Charge";
            this.BtnSteamCharge.UseVisualStyleBackColor = true;
            this.BtnSteamCharge.Click += new System.EventHandler(this.BtnSteamCharge_Click);
            // 
            // BtnGallonsLiters
            // 
            this.BtnGallonsLiters.Location = new System.Drawing.Point(26, 299);
            this.BtnGallonsLiters.Name = "BtnGallonsLiters";
            this.BtnGallonsLiters.Size = new System.Drawing.Size(99, 33);
            this.BtnGallonsLiters.TabIndex = 6;
            this.BtnGallonsLiters.Text = "Gallons to liters";
            this.BtnGallonsLiters.UseVisualStyleBackColor = true;
            this.BtnGallonsLiters.Click += new System.EventHandler(this.BtnGallonsLiters_Click);
            // 
            // BtnMileKm
            // 
            this.BtnMileKm.Location = new System.Drawing.Point(179, 246);
            this.BtnMileKm.Name = "BtnMileKm";
            this.BtnMileKm.Size = new System.Drawing.Size(118, 26);
            this.BtnMileKm.TabIndex = 7;
            this.BtnMileKm.Text = "Miles to Kms";
            this.BtnMileKm.UseVisualStyleBackColor = true;
            this.BtnMileKm.Click += new System.EventHandler(this.BtnMileKm_Click);
            // 
            // FrmRepApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 355);
            this.Controls.Add(this.BtnMileKm);
            this.Controls.Add(this.BtnGallonsLiters);
            this.Controls.Add(this.BtnSteamCharge);
            this.Controls.Add(this.TxtAnswers);
            this.Controls.Add(this.BtnNestFor);
            this.Controls.Add(this.BtnForSum);
            this.Controls.Add(this.BtnFahrenheitCelsius);
            this.Controls.Add(this.BtnArea);
            this.Name = "FrmRepApps";
            this.Text = "Repetition Applications";
            this.Load += new System.EventHandler(this.FrmRepApps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArea;
        private System.Windows.Forms.Button BtnFahrenheitCelsius;
        private System.Windows.Forms.Button BtnForSum;
        private System.Windows.Forms.Button BtnNestFor;
        private System.Windows.Forms.TextBox TxtAnswers;
        private System.Windows.Forms.Button BtnSteamCharge;
        private System.Windows.Forms.Button BtnGallonsLiters;
        private System.Windows.Forms.Button BtnMileKm;
    }
}

