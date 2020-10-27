using System;
using System.Windows.Forms;

namespace Euclid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtA.Text);
            var b = int.Parse(txtB.Text);

            txtRes.Text = GreatestCommonDivisor(a, b).ToString();
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }
    }
}