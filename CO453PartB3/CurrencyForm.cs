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
    public partial class CurrencyForm : Form
    {
        private decimal pounds;

        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Check", MessageBoxButtons.YesNo);
            if(answer == DialogResult.Yes)
            {
                MessageBox.Show("Ok then!");
            }
            else
            {

            }
            Close();
        }

        private void CalculateEuros(object sender, EventArgs e)
        {
            pounds = Convert.ToDecimal(poundsTextBox.Text);
            decimal euros = pounds * 1.2m;
            amountTextBox.Text = euros.ToString("c");

        }
    }
}
