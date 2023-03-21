using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            Conversor convert = new Conversor();
            lbBitcoin.Text = "Bitcoin: "+convert.Conversao(txtBitcoin.Text, txtReal.Text);
            lbEuro.Text = "Euro: "+convert.Conversao(txtEuro.Text, txtReal.Text);
            lbDolar.Text = "Dolar: "+convert.Conversao(txtDolar.Text, txtReal.Text);

        }
    }
}
