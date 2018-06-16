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
            string[] path = System.Environment.GetCommandLineArgs();
            if (FileTypeChecker(path[0]) == true)
            {
                DataImport(path[0]);
            }
            else
            {
                MessageBox.Show("拡張子がサポートされていないかファイルではありません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DataImport(string filePath)
        {
            treeView1.Nodes.Clear();
            var tag = OrangeNBT.NBT.IO.NBTFile.FromFile(filePath);
            var node = new TreeNode();
            NBTReader.AddTag(tag, node);
            node.Nodes[0].Text = System.IO.Path.GetFileName(filePath);
            treeView1.Nodes.Add(node.Nodes[0]);
            treeView1.Sort();
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] PathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = PathArray[0];
            if (FileTypeChecker(path) == true)
            {
                DataImport(path);
            }
            else
            {
                MessageBox.Show("拡張子がサポートされていないかファイルではありません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e) //DragAndDrop files
        {
            if ((e.Data.GetDataPresent(DataFormats.FileDrop)))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        

        public bool FileTypeChecker(string path) //読み込まれたファイルの拡張子確認
        {
            string[] allowArray = { "dat" }; //許可拡張子列挙
            foreach (string extend in allowArray)
            {
                int dot = extend.Length;
                if (extend == path.Substring(path.Length - dot, dot))
                {
                    return true;
                }
            }
            return false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdia = new OpenFileDialog();
            fdia.InitialDirectory = @"C:\Users\owner\AppData\Roaming\.minecraft\saves";
            fdia.Filter = "DATファイル(*.dat)|*.dat";
            fdia.Title = "データを選択してください";
            if (fdia.ShowDialog() == DialogResult.OK)
            {
                DataImport(fdia.FileName);
            }
        }

    }
}
