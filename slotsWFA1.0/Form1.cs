using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotsWFA1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void spinKnapp_Click(object sender, EventArgs e)
        {
            randomOutput random = new randomOutput();
            int r1 = random.randomNumber(3 +1);
            int r2 = random.randomNumber(3 +1);
            textRuta.Text = (r1).ToString();
            textRuta2.Text = (r2).ToString();
            if (r1 == r2) { vinstLåda.Text = "VINSTo?`!"; }
            else { vinstLåda.Text = "Loss"; }
        }
    }
}
