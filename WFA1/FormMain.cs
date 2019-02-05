using System;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
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
            MessageBox.Show(Class1.HelloMsg(""));
            MessageBox.Show(Class1.HelloMsg("       "));
            MessageBox.Show(Class1.HelloMsg(null));

            Class1 c1 = new Class1() { MyProperty = 3 };
            Class1 c2 = new Class1 { MyProperty = 3 };
        }

        private void winCtrlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinCtrls frm = new WinCtrls();
            frm.ShowDialog();
        }
    }
}
