using System;
using System.Windows.Forms;

namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = decimal.Parse(this.txtBox1.Text);
                var num2 = decimal.Parse(this.txtBox2.Text);
                var sum = num1 + num2;
                txtSum.Text = sum.ToString();
            }
            catch (Exception)
            {
                txtSum.Text = "Error";
            }

        }
    }
}
