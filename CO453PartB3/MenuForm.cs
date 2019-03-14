using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class MenuForm : Form
    {
        decimal starterCost, mainCost, totalCost;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void QuitForm(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectStarter(object sender, EventArgs e)
        {
            switch (starterListBox.SelectedIndex)
            {
                case 0 : starterCost = 4.50m; break;
                case 1 : starterCost = 5.50m; break;
                case 2: starterCost = 3.50m; break;
            }

            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            totalCost = starterCost + mainCost;

            costLabel.Text = "Total Cost: " + totalCost.ToString("c");
        }
    }
}
