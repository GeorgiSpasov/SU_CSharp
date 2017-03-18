using System;
using System.Windows.Forms;

namespace BGNtoEURForm
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()

        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.lblResult.Text = amountBGN + " BGN = " +             Math.Round(amountEUR, 2) + " EUR";
        }
    }
}
