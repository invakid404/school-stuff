using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var a = int.Parse(this.txtA.Text);
            var b = int.Parse(this.txtB.Text);
            var c = int.Parse(this.txtC.Text);
        
            if (a < b) Swap(ref a, ref b);
            if (b < c) Swap(ref b, ref c);
            if (a < b) Swap(ref a, ref b);

            this.lblResult.Text = a.ToString() + b.ToString() + c.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            this.lblResult.Text = "";
            this.txtA.Clear();
            this.txtB.Clear();
            this.txtC.Clear();
        }

        private void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }
}
