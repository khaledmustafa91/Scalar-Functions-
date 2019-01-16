using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class welcoming : Form
    {
        public welcoming()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void welcoming_Load(object sender, EventArgs e)
        {

        }

        private void welcoming_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void welcoing_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
