namespace CO453PartB3
{
    partial class MenuForm
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
            this.starterListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starters";
            // 
            // starterListBox
            // 
            this.starterListBox.FormattingEnabled = true;
            this.starterListBox.ItemHeight = 31;
            this.starterListBox.Items.AddRange(new object[] {
            "Chiltern Bread",
            "Swede Soup",
            "Pickled Herring"});
            this.starterListBox.Location = new System.Drawing.Point(34, 80);
            this.starterListBox.Name = "starterListBox";
            this.starterListBox.Size = new System.Drawing.Size(274, 97);
            this.starterListBox.TabIndex = 2;
            this.starterListBox.SelectedIndexChanged += new System.EventHandler(this.SelectStarter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(406, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 203);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QuitForm);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(42, 424);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(147, 31);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Total Cost:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainListBox);
            this.groupBox1.Location = new System.Drawing.Point(34, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // mainListBox
            // 
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 31;
            this.mainListBox.Items.AddRange(new object[] {
            "Roasted Cod",
            "Duck Leg"});
            this.mainListBox.Location = new System.Drawing.Point(14, 38);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(260, 97);
            this.mainListBox.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.starterListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.Text = "Posh Nosh Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox starterListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox mainListBox;
    }
}