using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControlTest
{
    public partial class UserControl1 : UserControl
    {
        public Form1 form1;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.button1.Enabled = false;
            this.Dispose();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
