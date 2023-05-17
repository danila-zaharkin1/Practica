using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control Control = new Control();
            Control.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сalculations Сalculations = new Сalculations();
            Сalculations.Show();
        }
    }
}
