using System;
using System.Windows.Forms;

namespace Max3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtA.Text);
            var b = int.Parse(txtB.Text);
            var c = int.Parse(txtC.Text);

            if (a < b) Swap(ref a, ref b);
            if (b < c) Swap(ref b, ref c);
            if (a < b) Swap(ref a, ref b);

            lblResult.Text = $@"{a}{b}{c}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            lblResult.Text = "";
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}