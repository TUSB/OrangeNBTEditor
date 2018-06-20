using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeNBTEditor.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// TreeViewドラッグ&ドロップイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] pathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = pathArray[0];
            DataImport(path);
        }

        /// <summary>
        /// TreeViewドラッグエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// ノードダブルクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        /// <summary>
        /// ノード選択イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        /// <summary>
        /// 開くボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFilesSB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdia = new OpenFileDialog();
            fdia.InitialDirectory = @"C:\Users\owner\AppData\Roaming\.minecraft\saves";
            fdia.Title = "データを選択してください";
            if (fdia.ShowDialog() == DialogResult.OK)
                DataImport(fdia.FileName);
        }

        /// <summary>
        /// 名前を変更ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddByteTagSB_Click(object sender, EventArgs e)
        {
            using (var f = new RenameWindow())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// 値を変更ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStringTagSB_Click(object sender, EventArgs e)
        {

        }

        public void DataImport(string filePath)
        {
            treeView1.Nodes.Clear();
            try
            {
                var tag = NBTFile.FromFile(filePath);
                var node = new TreeNode();
                AddTag(tag, node);
                node.Nodes[0].Text = Path.GetFileName(filePath) ?? throw new InvalidOperationException();
                treeView1.Nodes.Add(node.Nodes[0]);
                treeView1.Sort();
            }
            catch (Exception e)
            {
                MessageBox.Show("拡張子がサポートされていないかファイルではありません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// タグを再帰的に読み込んでTreeViewへ追加する
        /// </summary>
        /// <param name="tag">TagCompound</param>
        /// <param name="node">TreeNode</param>
        /// <returns></returns>
        public static TreeNode AddTag(TagBase tag, TreeNode node)
        {
            var addnode = new TreeNode();
            string value = "";

            switch (tag.TagType)
            {
                case TagType.Compound:
                    var compund = (TagCompound)tag;
                    foreach (var child in compund) addnode = AddTag(child, addnode);
                    value = compund.Count + " entries";
                    addnode.ImageIndex = 10;
                    break;
                case TagType.List:
                    var list = (TagList)tag;
                    foreach (TagBase child in list) addnode = AddTag(child, addnode);
                    value = list.Count + " entries";
                    addnode.ImageIndex = 9;
                    break;
                case TagType.Byte:
                    value = ((TagByte)tag).Value.ToString();
                    addnode.ImageIndex = 0;
                    break;
                case TagType.ByteArray:
                    value = ((TagByteArray)tag).Value.Length + "bytes";
                    addnode.ImageIndex = 6;
                    break;
                case TagType.Double:
                    value = ((TagDouble)tag).Value.ToString();
                    addnode.ImageIndex = 5;
                    break;
                case TagType.Float:
                    value = ((TagFloat)tag).Value.ToString();
                    addnode.ImageIndex = 4;
                    break;
                case TagType.Int:
                    value = ((TagInt)tag).Value.ToString();
                    addnode.ImageIndex = 2;
                    break;
                case TagType.IntArray:
                    value = ((TagIntArray)tag).Value.Length + "integers";
                    addnode.ImageIndex = 7;
                    break;
                case TagType.Long:
                    value = ((TagLong)tag).Value.ToString();
                    addnode.ImageIndex = 3;
                    break;
                case TagType.LongArray:
                    value = ((TagLongArray)tag).Value.Length + "longs";
                    break;
                case TagType.Short:
                    value = ((TagShort)tag).Value.ToString();
                    addnode.ImageIndex = 1;
                    break;
                case TagType.String:
                    value = ((TagString)tag).Value;
                    addnode.ImageIndex = 8;
                    break;
            }

            if (!string.IsNullOrEmpty(tag.Name))
            {
                addnode.Text = $"{tag.Name}: ";
            }

            addnode.Text += value;

            node.Nodes.Add(addnode);
            return node;
        }

        
        

        
    }
}
