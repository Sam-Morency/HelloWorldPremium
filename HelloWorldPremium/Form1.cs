using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldPremium
{
    public partial class frmHelloWorldPremium : Form
    {
        public frmHelloWorldPremium()
        {
            InitializeComponent();
        }

        private void frmHelloWorldPremium_Load(object sender, EventArgs e)
        {

        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
