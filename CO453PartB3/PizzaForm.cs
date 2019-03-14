using System;
using System.Windows.Forms;

namespace CO453PartB3
{
    /// <summary>
    /// Author: Derek Peacock
    /// Started: 12/03/2019
    /// 
    /// The user can select different sizes of pizzas with
    /// diiferent additional toppings.  All pizzas have a
    /// tomatoe base.
    /// </summary>
    public partial class PizzaForm : Form
    {
        private decimal cost = 0;

        private CheckBox[] toppings = new CheckBox[4];
        public PizzaForm()
        {
            InitializeComponent();

            toppings[0] = checkBox1;
            toppings[1] = checkBox2;
            toppings[2] = checkBox3;
            toppings[3] = checkBox4;

            CalculateCost(null, null);
        }

        /// <summary>
        /// Whenever the choice of pizza base or toppings 
        /// are changed then the total cost is re-calculated
        /// </summary>
        private void CalculateCost(object sender, EventArgs e)
        {
            cost = 0;

            /*
            if(largeRadioButton.Checked)
            {
                cost += 5.00m;
            }
            else if(mediumRadioButton.Checked)
            {
                cost += 4.00m;
            }
            else // small
            {
                cost += 3.0m;
            }

            if(checkBox1.Checked)
            {
                cost += 2.50m;
            }

            if (checkBox2.Checked)
            {
                cost += 2.50m;
            }

            if (checkBox3.Checked)
            {
                cost += 2.50m;
            }

            if(checkBox4.Checked)
            {
                cost += 2.50m;
            }
            */

            foreach(CheckBox topping in toppings)
            {
                if(topping.Checked)
                {
                    cost += 2.50m;
                }
            }

            if (largeRadioButton.Checked)
            {
                cost += 5.00m;
            }
            else if (mediumRadioButton.Checked)
            {
                cost += 4.00m;
            }
            else
                cost += 3.00m;

            costLabel.Text = cost.ToString("c");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
