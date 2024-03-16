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
            this.numButton1 = new MainForm.NumButton();
            this.numButton2 = new MainForm.NumButton();
            this.numButton3 = new MainForm.NumButton();
            this.SuspendLayout();
            // 
            // mainValueBox
            // 
            this.mainValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainValueBox.Location = new System.Drawing.Point(23, 34);
            this.mainValueBox.Name = "mainValueBox";
            this.mainValueBox.Size = new System.Drawing.Size(330, 38);
            this.mainValueBox.TabIndex = 4;
            // 
            // numButton1
            // 
            this.numButton1.ButtonValue = 1F;
            this.numButton1.Location = new System.Drawing.Point(23, 132);
            this.numButton1.Name = "numButton1";
            this.numButton1.Size = new System.Drawing.Size(60, 60);
            this.numButton1.TabIndex = 5;
            this.numButton1.Text = "1";
            this.numButton1.UseVisualStyleBackColor = true;
            this.numButton1.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton2
            // 
            this.numButton2.ButtonValue = 2F;
            this.numButton2.Location = new System.Drawing.Point(89, 132);
            this.numButton2.Name = "numButton2";
            this.numButton2.Size = new System.Drawing.Size(60, 60);
            this.numButton2.TabIndex = 6;
            this.numButton2.Text = "2";
            this.numButton2.UseVisualStyleBackColor = true;
            this.numButton2.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // numButton3
            // 
            this.numButton3.ButtonValue = 3F;
            this.numButton3.Location = new System.Drawing.Point(155, 132);
            this.numButton3.Name = "numButton3";
            this.numButton3.Size = new System.Drawing.Size(60, 60);
            this.numButton3.TabIndex = 7;
            this.numButton3.Text = "3";
            this.numButton3.UseVisualStyleBackColor = true;
            this.numButton3.Click += new System.EventHandler(this.ValueButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 457);
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
    }
}

