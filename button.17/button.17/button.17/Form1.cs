using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trRed_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = trRed.Value;
            g = trGreen.Value;
            b = trBlue.Value;
            
            label1.Text = r.ToString();

            this.BackColor=System.Drawing.Color.FromArgb(r,g,b);

        }

        private void trGreen_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = trRed.Value;
            g = trGreen.Value;
            b = trBlue.Value;

            label2.Text = g.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g,b);
        }

        private void trBlue_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = trRed.Value;
            g = trGreen.Value;
            b = trBlue.Value;

            label3.Text = b.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
