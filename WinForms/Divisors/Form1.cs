using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Clear();
            var n = int.Parse(txtNum.Text);

            var st = new Stack<int>();
            
            var hi = (int) Math.Sqrt(n);
            for (var i = 1; i <= hi; ++i)
            {
                if (n % i != 0) continue;
                
                lstRes.Items.Add(i.ToString());

                var other = n / i;
                if (i != other)
                {
                    st.Push(n / i);
                }
            }

            while (st.Count > 0)
            {
                lstRes.Items.Add(st.Pop().ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            lstRes.Items.Clear();
        }
    }
}