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
    public partial class BillForm : Form
    {
        public decimal Total { get; set; }

        public int NoPeople { get; set; }

        public BillForm()
        {
            InitializeComponent();
        }

        public void CalculatePayment()
        {
            totalLabel.Text = Total.ToString("c");
            peopleLabel.Text = NoPeople.ToString();

            if((Total > 0) && (NoPeople > 0))
            {
                decimal payment = Total / NoPeople;
                paymentLlabel.Text = payment.ToString("c");
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
