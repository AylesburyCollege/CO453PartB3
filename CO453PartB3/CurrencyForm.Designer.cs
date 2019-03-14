namespace CO453PartB3
{
    partial class CurrencyForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.poundLsabel = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.euroRadioButton = new System.Windows.Forms.RadioButton();
            this.dollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.yenRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(99, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(252, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Currency Convertor";
            // 
            // poundLsabel
            // 
            this.poundLsabel.AutoSize = true;
            this.poundLsabel.Location = new System.Drawing.Point(105, 128);
            this.poundLsabel.Name = "poundLsabel";
            this.poundLsabel.Size = new System.Drawing.Size(151, 31);
            this.poundLsabel.TabIndex = 1;
            this.poundLsabel.Text = "UK Pounds";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(284, 125);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(100, 38);
            this.poundsTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(284, 243);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 38);
            this.amountTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yenRadioButton);
            this.panel1.Controls.Add(this.dollarsRadioButton);
            this.panel1.Controls.Add(this.euroRadioButton);
            this.panel1.Location = new System.Drawing.Point(566, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 227);
            this.panel1.TabIndex = 5;
            // 
            // euroRadioButton
            // 
            this.euroRadioButton.AutoSize = true;
            this.euroRadioButton.Location = new System.Drawing.Point(41, 33);
            this.euroRadioButton.Name = "euroRadioButton";
            this.euroRadioButton.Size = new System.Drawing.Size(106, 35);
            this.euroRadioButton.TabIndex = 0;
            this.euroRadioButton.TabStop = true;
            this.euroRadioButton.Text = "Euros";
            this.euroRadioButton.UseVisualStyleBackColor = true;
            this.euroRadioButton.CheckedChanged += new System.EventHandler(this.CalculateEuros);
            // 
            // dollarsRadioButton
            // 
            this.dollarsRadioButton.AutoSize = true;
            this.dollarsRadioButton.Location = new System.Drawing.Point(41, 105);
            this.dollarsRadioButton.Name = "dollarsRadioButton";
            this.dollarsRadioButton.Size = new System.Drawing.Size(120, 35);
            this.dollarsRadioButton.TabIndex = 1;
            this.dollarsRadioButton.TabStop = true;
            this.dollarsRadioButton.Text = "Dollars";
            this.dollarsRadioButton.UseVisualStyleBackColor = true;
            // 
            // yenRadioButton
            // 
            this.yenRadioButton.AutoSize = true;
            this.yenRadioButton.Location = new System.Drawing.Point(41, 176);
            this.yenRadioButton.Name = "yenRadioButton";
            this.yenRadioButton.Size = new System.Drawing.Size(83, 35);
            this.yenRadioButton.TabIndex = 2;
            this.yenRadioButton.TabStop = true;
            this.yenRadioButton.Text = "Yen";
            this.yenRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.poundLsabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CurrencyForm";
            this.Text = "Derek\'s Currency Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label poundLsabel;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton yenRadioButton;
        private System.Windows.Forms.RadioButton dollarsRadioButton;
        private System.Windows.Forms.RadioButton euroRadioButton;
        private System.Windows.Forms.Button button1;
    }
}

