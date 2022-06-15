using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Calculos calc = new Calculos();
        int num1, num2;

        private void btnCMD_Click(object sender, EventArgs e)
        {
            
            int cmd = calc.maximcomundivisor(num1, num2);
            lblCMDResoult.Text = cmd.ToString();

        }

        private void btnMCM_Click(object sender, EventArgs e)
        {

            int mcm = calc.minimocomunmultiple(num1, num2);
            lblMCMResoult.Text = mcm.ToString();

        }

        private void btnCalculs_Click(object sender, EventArgs e)
        {

            List<int> calculus = calc.Calculus(num1, num2);

            if (calculus[3] < 300)
            {
                for (int i = 0; i < calculus.Count; i++)
                {
                    lboxCalculs.Items.Add(calculus[i].ToString());
                }
            }

        }

        private void btnRandomNumbers_Click(object sender, EventArgs e)
        {
            
            num1 = rnd.Next(0, 10);
            num2 = rnd.Next(0, 40);

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();

        }
    }
}
