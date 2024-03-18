namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainValueBox = new System.Windows.Forms.TextBox();
            this.decPointButton = new System.Windows.Forms.Button();
            this.numButton10 = new MainForm.NumButton();
            this.numButton9 = new MainForm.NumButton();
            this.numButton8 = new MainForm.NumButton();
            this.numButton7 = new MainForm.NumButton();
            this.numButton6 = new MainForm.NumButton();
            this.numButton5 = new MainForm.NumButton();
            this.numButton4 = new MainForm.NumButton();
            this.numButton3 = new MainForm.NumButton();
            this.numButton2 = new MainForm.NumButton();
            this.numButton1 = new MainForm.NumButton();
            this.SuspendLayout();
            // 
            // mainValueBox
            // 
            this.mainValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainValueBox.Location = new System.Drawing.Point(23, 34);
            this.mainValueBox.Name = "mainValueBox";
            this.mainValueBox.ReadOnly = true;
            this.mainValueBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainValueBox.Size = new System.Drawing.Size(287, 38);
            this.mainValueBox.TabIndex = 4;
            this.mainValueBox.Text = "0";
            // 
            // decPointButton
            // 
            this.decPointButton.Location = new System.Drawing.Point(155, 330);
            this.decPointButton.Name = "decPointButton";
            this.decPointButton.Size = new System.Drawing.Size(60, 60);
            this.decPointButton.TabIndex = 11;
            this.decPointButton.Text = ",";
            this.decPointButton.UseVisualStyleBackColor = true;
            this.decPointButton.Click += new System.EventHandler(this.DecimalPointClick);
            // 
            // numButton10
            // 
            this.numButton10.ButtonValue = 0D;
            this.numButton10.Location = new System.Drawing.Point(89, 330);
            this.numButton10.Name = "numButton10";
            this.numButton10.Size = new System.Drawing.Size(60, 60);
            this.numButton10.TabIndex = 10;
            this.numButton10.Text = "0";
            this.numButton10.UseVisualStyleBackColor = true;
            this.numButton10.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton9
            // 
            this.numButton9.ButtonValue = 9D;
            this.numButton9.Location = new System.Drawing.Point(155, 264);
            this.numButton9.Name = "numButton9";
            this.numButton9.Size = new System.Drawing.Size(60, 60);
            this.numButton9.TabIndex = 9;
            this.numButton9.Text = "9";
            this.numButton9.UseVisualStyleBackColor = true;
            this.numButton9.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton8
            // 
            this.numButton8.ButtonValue = 8D;
            this.numButton8.Location = new System.Drawing.Point(89, 264);
            this.numButton8.Name = "numButton8";
            this.numButton8.Size = new System.Drawing.Size(60, 60);
            this.numButton8.TabIndex = 8;
            this.numButton8.Text = "8";
            this.numButton8.UseVisualStyleBackColor = true;
            this.numButton8.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton7
            // 
            this.numButton7.ButtonValue = 7D;
            this.numButton7.Location = new System.Drawing.Point(23, 264);
            this.numButton7.Name = "numButton7";
            this.numButton7.Size = new System.Drawing.Size(60, 60);
            this.numButton7.TabIndex = 7;
            this.numButton7.Text = "7";
            this.numButton7.UseVisualStyleBackColor = true;
            this.numButton7.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton6
            // 
            this.numButton6.ButtonValue = 6D;
            this.numButton6.Location = new System.Drawing.Point(155, 198);
            this.numButton6.Name = "numButton6";
            this.numButton6.Size = new System.Drawing.Size(60, 60);
            this.numButton6.TabIndex = 6;
            this.numButton6.Text = "6";
            this.numButton6.UseVisualStyleBackColor = true;
            this.numButton6.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton5
            // 
            this.numButton5.ButtonValue = 5D;
            this.numButton5.Location = new System.Drawing.Point(89, 198);
            this.numButton5.Name = "numButton5";
            this.numButton5.Size = new System.Drawing.Size(60, 60);
            this.numButton5.TabIndex = 5;
            this.numButton5.Text = "5";
            this.numButton5.UseVisualStyleBackColor = true;
            this.numButton5.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton4
            // 
            this.numButton4.ButtonValue = 4D;
            this.numButton4.Location = new System.Drawing.Point(23, 198);
            this.numButton4.Name = "numButton4";
            this.numButton4.Size = new System.Drawing.Size(60, 60);
            this.numButton4.TabIndex = 4;
            this.numButton4.Text = "4";
            this.numButton4.UseVisualStyleBackColor = true;
            this.numButton4.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton3
            // 
            this.numButton3.ButtonValue = 3D;
            this.numButton3.Location = new System.Drawing.Point(155, 132);
            this.numButton3.Name = "numButton3";
            this.numButton3.Size = new System.Drawing.Size(60, 60);
            this.numButton3.TabIndex = 3;
            this.numButton3.Text = "3";
            this.numButton3.UseVisualStyleBackColor = true;
            this.numButton3.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton2
            // 
            this.numButton2.ButtonValue = 2D;
            this.numButton2.Location = new System.Drawing.Point(89, 132);
            this.numButton2.Name = "numButton2";
            this.numButton2.Size = new System.Drawing.Size(60, 60);
            this.numButton2.TabIndex = 2;
            this.numButton2.Text = "2";
            this.numButton2.UseVisualStyleBackColor = true;
            this.numButton2.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton1
            // 
            this.numButton1.ButtonValue = 1D;
            this.numButton1.Location = new System.Drawing.Point(23, 132);
            this.numButton1.Name = "numButton1";
            this.numButton1.Size = new System.Drawing.Size(60, 60);
            this.numButton1.TabIndex = 1;
            this.numButton1.Text = "1";
            this.numButton1.UseVisualStyleBackColor = true;
            this.numButton1.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 457);
            this.Controls.Add(this.decPointButton);
            this.Controls.Add(this.numButton10);
            this.Controls.Add(this.numButton9);
            this.Controls.Add(this.numButton8);
            this.Controls.Add(this.numButton7);
            this.Controls.Add(this.numButton6);
            this.Controls.Add(this.numButton5);
            this.Controls.Add(this.numButton4);
            this.Controls.Add(this.numButton3);
            this.Controls.Add(this.numButton2);
            this.Controls.Add(this.numButton1);
            this.Controls.Add(this.mainValueBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mainValueBox;
        private NumButton numButton1;
        private NumButton numButton2;
        private NumButton numButton3;
        private NumButton numButton6;
        private NumButton numButton5;
        private NumButton numButton4;
        private NumButton numButton9;
        private NumButton numButton8;
        private NumButton numButton7;
        private NumButton numButton10;
        private System.Windows.Forms.Button decPointButton;
    }
}

