using System;
using System.Windows.Forms;
using ClassLibrary1;

namespace WFA1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(Class1.HelloMsg("Joe"));
       }
    }
}
