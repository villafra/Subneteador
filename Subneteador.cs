using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subneteador
{
    public partial class Subneteador : Form
    {
        public Subneteador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subneter subneter = new Subneter(textBox1.Text);
            List<int> list = new List<int>();
            list.Add(45);
            list.Add(32);
            list.Add(99);
            list.Add(23);
            subneter.Subnetear(subneter, list);
        }
    }
}
