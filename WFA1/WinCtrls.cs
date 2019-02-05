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
    public partial class WinCtrls : Form
    {
        public WinCtrls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(new TreeNode("new node"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[treeView1.SelectedNode.Index].Nodes.Add("child node");
        }
    }
}
