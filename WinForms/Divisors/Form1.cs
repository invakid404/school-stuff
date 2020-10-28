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

            // Used to store the complementary divisors
            var st = new Stack<int>();

            var hi = (int) Math.Sqrt(n);
            
            // Check for divisors less than the square root
            for (var i = 1; i < hi; ++i)
            {
                if (n % i != 0) continue;

                lstRes.Items.Add(i.ToString());
                st.Push(n / i);
            }

            // Handle square root separately
            if (n % hi == 0)
            {
                lstRes.Items.Add(hi.ToString());
                
                var other = n / hi;
                
                // If number is a perfect square, these will match
                // Make sure we don't repeat a divisor
                if (other != hi)
                {
                    lstRes.Items.Add(other.ToString());
                }
            }

            // Add the complementary divisors in reverse order
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