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
            this.label1 = new System.Windows.Forms.Label();
            this.operationButton_div = new MainForm.OperationButton();
            this.operationButton_mul = new MainForm.OperationButton();
            this.operationButton_sub = new MainForm.OperationButton();
            this.operationButton_add = new MainForm.OperationButton();
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
            this.equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainValueBox
            // 
            this.mainValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainValueBox.Location = new System.Drawing.Point(23, 48);
            this.mainValueBox.Name = "mainValueBox";
            this.mainValueBox.ReadOnly = true;
            this.mainValueBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainValueBox.Size = new System.Drawing.Size(372, 38);
            this.mainValueBox.TabIndex = 0;
            this.mainValueBox.Text = "0";
            this.mainValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainValueBox_KeyDown);
            // 
            // decPointButton
            // 
            this.decPointButton.Location = new System.Drawing.Point(155, 330);
            this.decPointButton.Name = "decPointButton";
            this.decPointButton.Size = new System.Drawing.Size(60, 60);
            this.decPointButton.TabIndex = 11;
            this.decPointButton.Text = ",";
            this.decPointButton.UseVisualStyleBackColor = true;
            this.decPointButton.Click += new System.EventHandler(this.DecimalButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // operationButton_div
            // 
            this.operationButton_div.Location = new System.Drawing.Point(235, 330);
            this.operationButton_div.Name = "operationButton_div";
            this.operationButton_div.Operation = OperationType.div;
            this.operationButton_div.Size = new System.Drawing.Size(55, 60);
            this.operationButton_div.TabIndex = 16;
            this.operationButton_div.Text = "/";
            this.operationButton_div.UseVisualStyleBackColor = true;
            this.operationButton_div.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // operationButton_mul
            // 
            this.operationButton_mul.Location = new System.Drawing.Point(235, 264);
            this.operationButton_mul.Name = "operationButton_mul";
            this.operationButton_mul.Operation = OperationType.mul;
            this.operationButton_mul.Size = new System.Drawing.Size(55, 60);
            this.operationButton_mul.TabIndex = 15;
            this.operationButton_mul.Text = "*";
            this.operationButton_mul.UseVisualStyleBackColor = true;
            this.operationButton_mul.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // operationButton_sub
            // 
            this.operationButton_sub.Location = new System.Drawing.Point(235, 198);
            this.operationButton_sub.Name = "operationButton_sub";
            this.operationButton_sub.Operation = OperationType.sub;
            this.operationButton_sub.Size = new System.Drawing.Size(55, 60);
            this.operationButton_sub.TabIndex = 14;
            this.operationButton_sub.Text = "-";
            this.operationButton_sub.UseVisualStyleBackColor = true;
            this.operationButton_sub.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // operationButton_add
            // 
            this.operationButton_add.Location = new System.Drawing.Point(235, 132);
            this.operationButton_add.Name = "operationButton_add";
            this.operationButton_add.Operation = OperationType.add;
            this.operationButton_add.Size = new System.Drawing.Size(55, 60);
            this.operationButton_add.TabIndex = 13;
            this.operationButton_add.Text = "+";
            this.operationButton_add.UseVisualStyleBackColor = true;
            this.operationButton_add.Click += new System.EventHandler(this.OperationButtonClick);
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
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(296, 330);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(55, 60);
            this.equalButton.TabIndex = 17;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.EqualButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 457);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.operationButton_div);
            this.Controls.Add(this.operationButton_mul);
            this.Controls.Add(this.operationButton_sub);
            this.Controls.Add(this.operationButton_add);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private OperationButton operationButton_add;
        private OperationButton operationButton_sub;
        private OperationButton operationButton_div;
        private OperationButton operationButton_mul;
        private System.Windows.Forms.Button equalButton;
    }
}

