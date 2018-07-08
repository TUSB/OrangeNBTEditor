using OragngeNBTEditor.NBT;
using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;
using OrangeNBTEditor.Class;
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
    public partial class MainForm : Form
    {
        public MainForm()
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
            FileOpen(path);
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
            var node = e.Node;
            if (node != null)
            {
                var tag = (TagBase)node.Tag;

                switch (tag.TagType)
                {
                    case TagType.Compound:
                        break;
                    case TagType.List:
                        break;
                    default:
                        ValueEdit();
                        break;
                }
            }

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
            OpenFileDialog fdia = new OpenFileDialog
            {
                InitialDirectory = $@"C:\Users\{Environment.UserName}\AppData\Roaming\.minecraft\saves",
                Title = "データを選択してください"
            };
            if (fdia.ShowDialog() == DialogResult.OK)
            {
                Common.OpenFilePath = fdia.FileName;
                FileOpen(Common.OpenFilePath);
            }

        }

        /// <summary>
        /// 保存ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.Nodes.Count > 0)
                {
                    var tag = (TagCompound)treeView1.Nodes[0].Tag;
                    NBTFile.ToFile(Common.OpenFilePath, tag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ファイルの保存に失敗しました\n" + ex.Message, "OrangeNBTEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 名前を変更ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddByteTagSB_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            if (node != null)
            {
                var tag = (TagBase)node.Tag;

                using (var f = new RenameForm())
                {
                    f.NBT = tag;
                    f.StartPosition = FormStartPosition.CenterParent;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        treeView1.SelectedNode.Tag = f.NBT;
                        treeView1.SelectedNode.Text = GetNBTNode(f.NBT).Text;
                    }
                }
            }
        }

        /// <summary>
        /// 値を変更ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_ValueEdit_Click(object sender, EventArgs e)
        {
            ValueEdit();
        }

        /// <summary>
        /// TagByteボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagByte_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagShortボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagShort_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagIntボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagInt_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagLongボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagLong_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagFloatボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagFloat_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagDoubleボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagDouble_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagByteArrayボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagByteArray_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagIntArrayボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagIntArray_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagLongARrayボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagStringボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagString_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagKListボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagList_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// TagCompoundボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_AddTagCompound_Click(object sender, EventArgs e)
        {
            AddTag((TagBase)treeView1.SelectedNode.Tag);
        }

        /// <summary>
        /// NBTファイルを開く
        /// </summary>
        /// <param name="filePath"></param>
        public void FileOpen(string filePath)
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
            catch (Exception ex)
            {
                MessageBox.Show("サポートされているファイルではありません\n" + ex.Message, "OrangeNBTEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 値を変更
        /// </summary>
        public void ValueEdit()
        {
            var node = treeView1.SelectedNode;
            if (node != null)
            {
                var tag = (TagBase)node.Tag;

                switch (tag.TagType)
                {
                    case TagType.Compound:
                        break;
                    case TagType.List:
                        break;
                    case TagType.ByteArray:
                        using (var f = new HexEditorForm())
                        {
                            f.NBT = (TagByteArray)tag;
                            f.StartPosition = FormStartPosition.CenterParent;
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                treeView1.SelectedNode.Tag = f.NBT;
                                treeView1.SelectedNode.Text = GetNBTNode(f.NBT).Text;
                            }
                        }
                        break;
                    case TagType.IntArray:
                        break;
                    case TagType.LongArray:
                        break;
                    default:
                        using (var f = new ValueEditForm())
                        {
                            f.NBT = tag;
                            f.StartPosition = FormStartPosition.CenterParent;
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                treeView1.SelectedNode.Tag = f.NBT;
                                treeView1.SelectedNode.Text = GetNBTNode(f.NBT).Text;
                            }
                        }
                        break;
                }
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
            var addnode = new TreeNode()
            {
                Tag = tag
            };

            switch (tag.TagType)
            {
                case TagType.Compound:
                    var compund = (TagCompound)tag;
                    foreach (var child in compund)
                    {
                        addnode = AddTag(child, addnode);
                    }
                    break;
                case TagType.List:
                    var list = (TagList)tag;
                    foreach (TagBase child in list)
                    {
                        addnode = AddTag(child, addnode);
                    }
                    break;
            }

            var getnode = GetNBTNode(tag);

            addnode.Text += getnode.Text;
            addnode.ImageIndex = getnode.ImageIndex;
            addnode.SelectedImageIndex = getnode.ImageIndex;

            node.Nodes.Add(addnode);
            return node;
        }


        /// <summary>
        /// NBTタグからノードを取得する
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        private static TreeNode GetNBTNode(TagBase tag)
        {
            var node = new TreeNode()
            {
                Tag = tag,
                ImageIndex = GetImageIndex(tag)
            };

            if (!string.IsNullOrEmpty(tag.Name))
            {
                node.Text = $"{tag.Name}: ";
            }

            node.Text += NBTAccesser.GetValue(tag);
            node.SelectedImageIndex = node.ImageIndex;

            return node;
        }

        /// <summary>
        /// NBTTagからImageListのIndexを取得する
        /// </summary>
        /// <param name="tag">NBT</param>
        /// <returns></returns>
        private static int GetImageIndex(TagBase tag)
        {
            var index = 0;
            switch (tag.TagType)
            {
                case TagType.Compound:
                    index = 11;
                    break;
                case TagType.List:
                    index = 10;
                    break;
                case TagType.Byte:
                    index = 0;
                    break;
                case TagType.ByteArray:
                    index = 6;
                    break;
                case TagType.Double:
                    index = 5;
                    break;
                case TagType.Float:
                    index = 4;
                    break;
                case TagType.Int:
                    index = 2;
                    break;
                case TagType.IntArray:
                    index = 7;
                    break;
                case TagType.Long:
                    index = 3;
                    break;
                case TagType.LongArray:
                    index = 8;
                    break;
                case TagType.Short:
                    index = 1;
                    break;
                case TagType.String:
                    index = 9;
                    break;
            }

            return index;
        }

        /// <summary>
        /// タグ追加のFormを呼び出し、追加します
        /// </summary>
        /// <param name="selectedNodeType">TagBase</param>
        /// <returns></returns>
        public void AddTag(TagBase selectedNodeType)
        {
            var CreateTag = new OrangeNBTEditor.Forms.AddTagByte();
            CreateTag.NodeName = selectedNodeType;
            if (CreateTag.ShowDialog() == DialogResult.OK)
            {
                if (selectedNodeType.TagType == TagType.Compound)
                {
                    var tag = (TagCompound)treeView1.SelectedNode.Tag;
                    tag.Add(new TagCompound(CreateTag.AddName));

                    return;
                }
            }

            if (CreateTag.ShowDialog() == DialogResult.OK)
            {
                switch (CreateTag.NodeName.TagType)
                {
                    case TagType.ByteArray:
                        break;
                    case TagType.IntArray:
                        break;
                    case TagType.LongArray:
                        break;
                    case TagType.Byte:
                        break;
                    case TagType.Short:
                        break;
                    case TagType.Int:
                        break;
                    case TagType.Long:
                        break;
                    case TagType.Float:
                        break;
                    case TagType.Double:
                        break;
                    case TagType.String:
                        break;
                    case TagType.List:
                        break;
                    default:
                        break;
                }
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
