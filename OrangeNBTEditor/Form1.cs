using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrangeNBT;
using OrangeNBT.NBT;
using OrangeNBT.Helper;
using SpringEditor.NBT;

namespace SpringEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var file = @"C:\Users\owner\AppData\Roaming\.minecraft\saves\TFL-StoryMap\level.dat";
            var tag = OrangeNBT.NBT.IO.NBTFile.FromFile(file);
            var node = new TreeNode();
            NBTReader.AddTag(tag, node);
            node.Nodes[0].Text = System.IO.Path.GetFileName(file);
            treeView1.Nodes.Add(node.Nodes[0]);
            treeView1.Sort();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
