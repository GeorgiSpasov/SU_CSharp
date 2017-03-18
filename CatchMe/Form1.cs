using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();

            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;

            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;

            this.buttonCatchMe.Location = new Point(

            rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void buttonCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Win!");
        }
    }
}
