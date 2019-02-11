using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MakeRoom : Form
    {

        public MakeRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chanel = this.textBox1.Text;

            Hide();
            MultiPlayForm multiPlayForm = new MultiPlayForm(chanel);
            multiPlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            multiPlayForm.Show();
        }

        void childForm_Closed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

    }
}
