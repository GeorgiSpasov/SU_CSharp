﻿using System;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            var originalAmount = this.numericUpDownAmount.Value;
            var convertedAmount = originalAmount;
            if (this.comboBoxCurrency.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 1.95583m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "USD")
            {
                convertedAmount = originalAmount / 1.80810m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "GBP")
            {
                convertedAmount = originalAmount / 2.54990m;
            }
            this.labelResult.Text = originalAmount + " лв. = " +
            Math.Round(convertedAmount, 2) + " " + this.comboBoxCurrency.SelectedItem;
        }
    }
}


