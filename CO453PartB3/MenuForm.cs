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
    /// <summary>
    /// 
    /// </summary>
    public partial class MenuForm : Form
    {
        decimal starterCost, mainCost, desertCost, totalCost;

        public MenuForm()
        {
            InitializeComponent();
            //desertComboBox.SelectedIndex = 0;
        }

        private void SelectDesert(object sender, EventArgs e)
        {
            switch (desertComboBox.SelectedIndex)
            {
                case 0 : desertCost = 6.00m; break;
                case 1 : desertCost = 5.00m; break;
            }

            CalculateTotalCost();
        }

        private void SelectMain(object sender, EventArgs e)
        {
            switch(mainListBox.SelectedIndex)
            {
                case 0: mainCost = 15.00m; break;
                case 1: mainCost = 16.00m; break;
            }

            CalculateTotalCost();
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
            totalCost = starterCost + mainCost + desertCost;

            costLabel.Text = "Total Cost: " + totalCost.ToString("c");
        }
    }
}
