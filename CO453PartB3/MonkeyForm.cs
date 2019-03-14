using System;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class MonkeyForm : Form
    {
        private int x;
        private int y;

        private int hits, misses;

        private Random generator = new Random();

        public MonkeyForm()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Move the monkey PictureBox to a random position
        /// on the panel each timer tick event
        /// </summary>
        private void MoveMonkey(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - 100);
            y = generator.Next(gamePanel.Height - 100);

            monkeyPictureBox.Left = x;
            monkeyPictureBox.Top = y;

            Refresh();
        }

        private void StartGame(object sender, EventArgs e)
        {
            gameTimer.Start();

            hits = 0;
            misses = 0;

            DisplayResults();
        }

        private void StopGame(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        /// <summary>
        /// Get the x and y coordinates of the mouse when down
        /// on the PictureBox
        /// </summary>
        private void GetXY(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            xyLabel.Text = String.Format("XY = ({0},{1})",x,y);
        }


        /// <summary>
        /// If the game panel is clicked on then the player has missed
        /// the monkey (Panel.Click)
        /// </summary>
        private void MissMonkey(object sender, EventArgs e)
        {
            if(gameTimer.Enabled)
            {
                misses++;
                DisplayResults();
            }
        }

        /// <summary>
        /// If the Picture box is clicked then the monkey has been
        /// hit (Panel.Click)
        /// </summary>
        private void HitMonkey(object sender, EventArgs e)
        {
            if(gameTimer.Enabled)
            {
                hits++;
                DisplayResults();
            }
        }

        private void DisplayResults()
        {
            hitsLabel.Text = hits.ToString("Hits = 0");
            missesLabel.Text = misses.ToString("Miss = 0");
        }
    }
}
