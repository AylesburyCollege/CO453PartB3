namespace CO453PartB3
{
    partial class PizzaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(584, 465);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(166, 69);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.smallRadioButton);
            this.groupBox1.Controls.Add(this.mediumRadioButton);
            this.groupBox1.Controls.Add(this.largeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(54, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Type";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(29, 224);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(102, 35);
            this.smallRadioButton.TabIndex = 2;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(29, 143);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(130, 35);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(29, 64);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(104, 35);
            this.largeRadioButton.TabIndex = 0;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(358, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 353);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Topping";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(48, 289);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(249, 35);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Chicken and Feta";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(48, 210);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 35);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Margerita";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(48, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(159, 35);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Pepperoni";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(272, 35);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ham and Pineapple";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CalculateCost);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.costLabel);
            this.groupBox3.Location = new System.Drawing.Point(54, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pizza Cost";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(45, 54);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(86, 31);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "label1";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PizzaForm";
            this.Text = "Derek\'s Pizza Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label costLabel;
    }
}