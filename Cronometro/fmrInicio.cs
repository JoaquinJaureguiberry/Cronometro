using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class fmrInicio : Form
    {
        public bool boolb;
        private int i = 0;
        private int j = 0;
        private int n = 0;

        public fmrInicio()
        {
            InitializeComponent();

        }

        private void btRestablecer_Click(object sender, EventArgs e)
        {
            lblContador.Text = "0.0";
            i = 0;
            j = 0;
        }

        private void btCronometro_Click(object sender, EventArgs e)
        {
            boolb = false;
            btCronometro.Enabled = false;

            do
            {                              
                Application.DoEvents();
                n = Contador.Sumar(i);
                i = n;              

                if (n == 10)
                {
                    Thread.Sleep(100);
                    j = j + 1;
                    i = 0;
                    lblContador.Text = j + "." + i;
                    this.Refresh();
                }
                else
                {
                    Thread.Sleep(100);
                    lblContador.Text = j + "." + n;
                    this.Refresh();
                }
               
            } while (boolb == false);

        }

        private void btDetener_Click(object sender, EventArgs e)
        {

            boolb = true;
            btCronometro.Enabled = true;

        }

    }
}
