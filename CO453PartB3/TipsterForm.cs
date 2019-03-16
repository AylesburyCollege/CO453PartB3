using System;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class TipsterForm : Form
    {
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void QuitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculatePayment(object sender, EventArgs e)
        {
            BillForm bill = new BillForm();

            bill.Total = GetTotal();
            if(bill.Total > 0)
            {
                bill.NoPeople = Convert.ToInt16(peopleNumericUpDown.Value);
                bill.CalculatePayment();
                bill.Show();
            }
        }

        private decimal GetTotal()
        {
            string value = totalTextBox.Text;
            decimal total;

            try
            {
                total = Convert.ToDecimal(value);
                return total;
            }
            catch(Exception e)
            {
                MessageBox.Show("Please enter a number!", "Invalid Value");
                return 0;
            }
            
        }
    }
}
