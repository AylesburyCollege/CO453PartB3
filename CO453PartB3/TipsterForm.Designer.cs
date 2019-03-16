namespace CO453PartB3
{
    partial class TipsterForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.peopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(430, 324);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(110, 37);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitApplication);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(279, 324);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(130, 37);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculatePayment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill Total (£)";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(145, 41);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(87, 32);
            this.totalTextBox.TabIndex = 4;
            this.totalTextBox.Text = "122.50";
            // 
            // peopleNumericUpDown
            // 
            this.peopleNumericUpDown.Location = new System.Drawing.Point(145, 119);
            this.peopleNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.peopleNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.peopleNumericUpDown.Name = "peopleNumericUpDown";
            this.peopleNumericUpDown.Size = new System.Drawing.Size(87, 32);
            this.peopleNumericUpDown.TabIndex = 5;
            this.peopleNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.peopleNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "No People";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::CO453PartB3.Properties.Resources.Artichoke;
            this.imagePictureBox.Location = new System.Drawing.Point(279, 12);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(261, 260);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.peopleNumericUpDown);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.imagePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TipsterForm";
            this.Text = "Tipster Bill Entry Form";
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.NumericUpDown peopleNumericUpDown;
        private System.Windows.Forms.Label label2;
    }
}