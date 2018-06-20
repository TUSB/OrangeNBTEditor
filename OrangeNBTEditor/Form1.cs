using System;
using System.IO;
using System.Windows.Forms;
using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;

namespace SpringEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*string[] path = Environment.GetCommandLineArgs(); //なんかできない
            if (FileTypeChecker(path[0]))
            {
                DataImport(path[0]);
            }
            else
            {
                MessageBox.Show("拡張子がサポートされていないかファイルではありません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        /// <summary>
        ///     フォームのロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     TreeViewドラッグ&ドロップイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] pathArray = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            string path = pathArray[0];
            DataImport(path);
        }

        /// <summary>
        ///     TreeViewドラッグエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_DragEnter(object sender, DragEventArgs e) //DragAndDrop files
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        ///     ノード選択イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //ToolStripManagement();
        }

        /// <summary>
        ///     開くボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog  fdia = new OpenFileDialog();
            fdia.InitialDirectory = @"C:\Users\owner\AppData\Roaming\.minecraft\saves";
            fdia.Title = "データを選択してください";
            if (fdia.ShowDialog() == DialogResult.OK) DataImport(fdia.FileName);
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


        public bool FileTypeChecker(string path) //読み込まれたファイルの拡張子確認 (多分使わない関数だけど一応残しておく)
        {
            string[] allowArray = {"dat", "nbt"}; //許可拡張子列挙
            foreach (string extend in allowArray)
            {
                var dot = extend.Length;
                if (extend == path.Substring(path.Length - dot, dot)) return true;
            }

            return false;
        }


        public void ToolStripManagement(TagBase tag) //クリックされたノードの種類を検知しToolStripを操作
        {
            switch (tag.TagType)
            {
                case TagType.Compound:
                    ToolStripEnabled(true, true, false, true, false, true, true, true);
                    break;
                case TagType.List:
                    ToolStripEnabled(true, true, false, true, false, true, true, true);
                    break;
                case TagType.Byte:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.ByteArray:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.Double:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.Float:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.Int:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.IntArray:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.Long:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.LongArray:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.Short:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
                case TagType.String:
                    ToolStripEnabled(true, true, false, true, true, true, false, false);
                    break;
            }
        }

        public void ToolStripEnabled(bool cut, bool copy, bool paste, bool rename, bool editValue, bool delete,
            bool tags, bool findNext) //ToolStripのクリック可否を操作
        {
            CutSB.Enabled = cut ? true : false; // if (cut) -> <TRUE時の処理> : <FALSE時の処理>  If文を省略
            CopySB.Enabled = copy ? true : false;
            PasteSB.Enabled = paste ? true : false;
            AddByteTagSB.Enabled = editValue ? true : false;
            AddStringTagSB.Enabled = editValue ? true : false;
            AddIntTagSB.Enabled = editValue ? true : false;
            AddLongTagSB.Enabled = editValue ? true : false;
            AddFloatTagSB.Enabled = editValue ? true : false;
            AddDoubleTagSB.Enabled = editValue ? true : false;
            AddByteArraySB.Enabled = editValue ? true : false;
            AddIntArraySB.Enabled = editValue ? true : false;
            AddLongArraySB.Enabled = editValue ? true : false;
            AddStringArraySB.Enabled = editValue ? true : false;
            AddListTagSB.Enabled = editValue ? true : false;
            AddCompoundTagSB.Enabled = editValue ? true : false;
            FindNextSB.Enabled = findNext ? true : false;
        }


        /// <summary>
        ///     タグを再帰的に読み込んでTreeViewへ追加する
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
                    var compund = (TagCompound) tag;
                    foreach (var child in compund) addnode = AddTag(child, addnode);
                    value = compund.Count + " entries";
                    addnode.ImageIndex = 10;
                    break;
                case TagType.List:
                    var list = (TagList) tag;
                    foreach (TagBase child in list) addnode = AddTag(child, addnode);
                    value = list.Count + " entries";
                    addnode.ImageIndex = 9;
                    break;
                case TagType.Byte:
                    value = ((TagByte) tag).Value.ToString();
                    addnode.ImageIndex = 0;
                    break;
                case TagType.ByteArray:
                    value = ((TagByteArray) tag).Value.Length + "bytes";
                    addnode.ImageIndex = 6;
                    break;
                case TagType.Double:
                    value = ((TagDouble) tag).Value.ToString();
                    addnode.ImageIndex = 5;
                    break;
                case TagType.Float:
                    value = ((TagFloat) tag).Value.ToString();
                    addnode.ImageIndex = 4;
                    break;
                case TagType.Int:
                    value = ((TagInt) tag).Value.ToString();
                    addnode.ImageIndex = 2;
                    break;
                case TagType.IntArray:
                    value = ((TagIntArray) tag).Value.Length + "integers";
                    addnode.ImageIndex = 7;
                    break;
                case TagType.Long:
                    value = ((TagLong) tag).Value.ToString();
                    addnode.ImageIndex = 3;
                    break;
                case TagType.LongArray:
                    break;
                case TagType.Short:
                    value = ((TagShort) tag).Value.ToString();
                    addnode.ImageIndex = 1;
                    break;
                case TagType.String:
                    value = ((TagString) tag).Value;
                    addnode.ImageIndex = 8;
                    break;
            }

            if (!string.IsNullOrEmpty(tag.Name) && tag.Name.Length != 0) addnode.Text = $"{tag.Name}: {value}";

            node.Nodes.Add(addnode);
            return node;
        }
    }
}