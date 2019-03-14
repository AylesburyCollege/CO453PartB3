namespace CO453PartB3
{
    partial class MonkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyForm));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.xyLabel = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.monkeyPictureBox = new System.Windows.Forms.PictureBox();
            this.resultsGroupBox.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(181, 479);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(437, 479);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(130, 56);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopGame);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(707, 479);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 56);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.MoveMonkey);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.xyLabel);
            this.resultsGroupBox.Controls.Add(this.missesLabel);
            this.resultsGroupBox.Controls.Add(this.hitsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(748, 23);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(200, 438);
            this.resultsGroupBox.TabIndex = 4;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // xyLabel
            // 
            this.xyLabel.AutoSize = true;
            this.xyLabel.Location = new System.Drawing.Point(33, 216);
            this.xyLabel.Name = "xyLabel";
            this.xyLabel.Size = new System.Drawing.Size(67, 31);
            this.xyLabel.TabIndex = 2;
            this.xyLabel.Text = "(x,y)";
            // 
            // missesLabel
            // 
            this.missesLabel.AutoSize = true;
            this.missesLabel.Location = new System.Drawing.Point(30, 142);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(70, 31);
            this.missesLabel.TabIndex = 1;
            this.missesLabel.Text = "Miss";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(30, 83);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(62, 31);
            this.hitsLabel.TabIndex = 0;
            this.hitsLabel.Text = "Hits";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.monkeyPictureBox);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(718, 449);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Click += new System.EventHandler(this.MissMonkey);
            // 
            // monkeyPictureBox
            // 
            this.monkeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox.Image")));
            this.monkeyPictureBox.Location = new System.Drawing.Point(309, 174);
            this.monkeyPictureBox.Name = "monkeyPictureBox";
            this.monkeyPictureBox.Size = new System.Drawing.Size(100, 100);
            this.monkeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox.TabIndex = 1;
            this.monkeyPictureBox.TabStop = false;
            this.monkeyPictureBox.Click += new System.EventHandler(this.HitMonkey);
            this.monkeyPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetXY);
            // 
            // MonkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 553);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MonkeyForm";
            this.Text = "Derek\'s Monkey Form";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox monkeyPictureBox;
        private System.Windows.Forms.Label xyLabel;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label hitsLabel;
    }
}