namespace OrangeNBTEditor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_OpenDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Cut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Rename = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ValueEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_AddTagByte = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagShort = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagInt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagLong = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagFloat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagDouble = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagByteArray = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagIntArray = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagString = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagList = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_AddTagCompound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_FindNext = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.クリアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ペーストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.リネイムToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.値の編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.チャンク検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_OpenFile,
            this.toolStrip_OpenDirectory,
            this.toolStrip_Save,
            this.toolStrip_Update,
            this.toolStripSeparator2,
            this.toolStrip_Cut,
            this.toolStrip_Copy,
            this.toolStrip_Paste,
            this.toolStripSeparator3,
            this.toolStrip_Rename,
            this.toolStrip_ValueEdit,
            this.toolStrip_Remove,
            this.toolStripSeparator1,
            this.toolStrip_AddTagByte,
            this.toolStrip_AddTagShort,
            this.toolStrip_AddTagInt,
            this.toolStrip_AddTagLong,
            this.toolStrip_AddTagFloat,
            this.toolStrip_AddTagDouble,
            this.toolStrip_AddTagByteArray,
            this.toolStrip_AddTagIntArray,
            this.toolStrip_AddTagString,
            this.toolStrip_AddTagList,
            this.toolStrip_AddTagCompound,
            this.toolStripSeparator4,
            this.toolStrip_FindNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_OpenFile
            // 
            this.toolStrip_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_OpenFile.Image")));
            this.toolStrip_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_OpenFile.Name = "toolStrip_OpenFile";
            this.toolStrip_OpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_OpenFile.Text = "ファイルを開く";
            this.toolStrip_OpenFile.Click += new System.EventHandler(this.OpenFilesSB_Click);
            // 
            // toolStrip_OpenDirectory
            // 
            this.toolStrip_OpenDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_OpenDirectory.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_OpenDirectory.Image")));
            this.toolStrip_OpenDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_OpenDirectory.Name = "toolStrip_OpenDirectory";
            this.toolStrip_OpenDirectory.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_OpenDirectory.Text = "フォルダを開く";
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Save.Image")));
            this.toolStrip_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Save.Text = "保存";
            this.toolStrip_Save.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip_Update
            // 
            this.toolStrip_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Update.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Update.Image")));
            this.toolStrip_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Update.Name = "toolStrip_Update";
            this.toolStrip_Update.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Update.Text = "更新";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Cut
            // 
            this.toolStrip_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Cut.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Cut.Image")));
            this.toolStrip_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Cut.Name = "toolStrip_Cut";
            this.toolStrip_Cut.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Cut.Text = "カット";
            // 
            // toolStrip_Copy
            // 
            this.toolStrip_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Copy.Image")));
            this.toolStrip_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Copy.Name = "toolStrip_Copy";
            this.toolStrip_Copy.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Copy.Text = "コピー";
            // 
            // toolStrip_Paste
            // 
            this.toolStrip_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Paste.Image")));
            this.toolStrip_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Paste.Name = "toolStrip_Paste";
            this.toolStrip_Paste.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Paste.Text = "ペースト";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Rename
            // 
            this.toolStrip_Rename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Rename.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Rename.Image")));
            this.toolStrip_Rename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Rename.Name = "toolStrip_Rename";
            this.toolStrip_Rename.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Rename.Text = "名前を変更";
            this.toolStrip_Rename.Click += new System.EventHandler(this.AddByteTagSB_Click);
            // 
            // toolStrip_ValueEdit
            // 
            this.toolStrip_ValueEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_ValueEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_ValueEdit.Image")));
            this.toolStrip_ValueEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_ValueEdit.Name = "toolStrip_ValueEdit";
            this.toolStrip_ValueEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_ValueEdit.Text = "値を変更";
            this.toolStrip_ValueEdit.Click += new System.EventHandler(this.toolStrip_ValueEdit_Click);
            // 
            // toolStrip_Remove
            // 
            this.toolStrip_Remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Remove.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Remove.Image")));
            this.toolStrip_Remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Remove.Name = "toolStrip_Remove";
            this.toolStrip_Remove.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Remove.Text = "削除";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_AddTagByte
            // 
            this.toolStrip_AddTagByte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagByte.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagByte.Image")));
            this.toolStrip_AddTagByte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagByte.Name = "toolStrip_AddTagByte";
            this.toolStrip_AddTagByte.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagByte.Text = "Byte Tagを追加";
            // 
            // toolStrip_AddTagShort
            // 
            this.toolStrip_AddTagShort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagShort.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagShort.Image")));
            this.toolStrip_AddTagShort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagShort.Name = "toolStrip_AddTagShort";
            this.toolStrip_AddTagShort.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagShort.Text = "Short Tagを追加";
            // 
            // toolStrip_AddTagInt
            // 
            this.toolStrip_AddTagInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagInt.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagInt.Image")));
            this.toolStrip_AddTagInt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagInt.Name = "toolStrip_AddTagInt";
            this.toolStrip_AddTagInt.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagInt.Text = "Int Tagを追加";
            // 
            // toolStrip_AddTagLong
            // 
            this.toolStrip_AddTagLong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagLong.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagLong.Image")));
            this.toolStrip_AddTagLong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagLong.Name = "toolStrip_AddTagLong";
            this.toolStrip_AddTagLong.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagLong.Text = "Long Tagを追加";
            // 
            // toolStrip_AddTagFloat
            // 
            this.toolStrip_AddTagFloat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagFloat.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagFloat.Image")));
            this.toolStrip_AddTagFloat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagFloat.Name = "toolStrip_AddTagFloat";
            this.toolStrip_AddTagFloat.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagFloat.Text = "Float Tagを追加";
            // 
            // toolStrip_AddTagDouble
            // 
            this.toolStrip_AddTagDouble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagDouble.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagDouble.Image")));
            this.toolStrip_AddTagDouble.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagDouble.Name = "toolStrip_AddTagDouble";
            this.toolStrip_AddTagDouble.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagDouble.Text = "Double Tagを追加";
            // 
            // toolStrip_AddTagByteArray
            // 
            this.toolStrip_AddTagByteArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagByteArray.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagByteArray.Image")));
            this.toolStrip_AddTagByteArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagByteArray.Name = "toolStrip_AddTagByteArray";
            this.toolStrip_AddTagByteArray.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagByteArray.Text = "ByteArray Tagを追加";
            // 
            // toolStrip_AddTagIntArray
            // 
            this.toolStrip_AddTagIntArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagIntArray.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagIntArray.Image")));
            this.toolStrip_AddTagIntArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagIntArray.Name = "toolStrip_AddTagIntArray";
            this.toolStrip_AddTagIntArray.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagIntArray.Text = "IntArray Tagを追加";
            // 
            // toolStrip_AddTagString
            // 
            this.toolStrip_AddTagString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagString.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagString.Image")));
            this.toolStrip_AddTagString.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagString.Name = "toolStrip_AddTagString";
            this.toolStrip_AddTagString.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagString.Text = "String Tagを追加";
            // 
            // toolStrip_AddTagList
            // 
            this.toolStrip_AddTagList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagList.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagList.Image")));
            this.toolStrip_AddTagList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagList.Name = "toolStrip_AddTagList";
            this.toolStrip_AddTagList.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagList.Text = "List Tagを追加";
            // 
            // toolStrip_AddTagCompound
            // 
            this.toolStrip_AddTagCompound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_AddTagCompound.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AddTagCompound.Image")));
            this.toolStrip_AddTagCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AddTagCompound.Name = "toolStrip_AddTagCompound";
            this.toolStrip_AddTagCompound.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_AddTagCompound.Text = "Compound Tagを追加";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_FindNext
            // 
            this.toolStrip_FindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_FindNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_FindNext.Image")));
            this.toolStrip_FindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_FindNext.Name = "toolStrip_FindNext";
            this.toolStrip_FindNext.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_FindNext.Text = "検索 / 次を検索";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(570, 292);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop_1);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document-attribute-b.png");
            this.imageList1.Images.SetKeyName(1, "document-attribute-s.png");
            this.imageList1.Images.SetKeyName(2, "document-attribute-i.png");
            this.imageList1.Images.SetKeyName(3, "document-attribute-l.png");
            this.imageList1.Images.SetKeyName(4, "document-attribute-f.png");
            this.imageList1.Images.SetKeyName(5, "document-attribute-d.png");
            this.imageList1.Images.SetKeyName(6, "edit-code.png");
            this.imageList1.Images.SetKeyName(7, "edit-code-i.png");
            this.imageList1.Images.SetKeyName(8, "edit-small-caps.png");
            this.imageList1.Images.SetKeyName(9, "edit-list.png");
            this.imageList1.Images.SetKeyName(10, "box.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.検索ToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.toolStripSeparator5,
            this.保存ToolStripMenuItem,
            this.クリアToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(134, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // クリアToolStripMenuItem
            // 
            this.クリアToolStripMenuItem.Name = "クリアToolStripMenuItem";
            this.クリアToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.クリアToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.クリアToolStripMenuItem.Text = "クリア";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カットToolStripMenuItem,
            this.コピーToolStripMenuItem,
            this.ペーストToolStripMenuItem,
            this.toolStripSeparator6,
            this.リネイムToolStripMenuItem,
            this.値の編集ToolStripMenuItem,
            this.削除ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // カットToolStripMenuItem
            // 
            this.カットToolStripMenuItem.Name = "カットToolStripMenuItem";
            this.カットToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.カットToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.カットToolStripMenuItem.Text = "カット";
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.コピーToolStripMenuItem.Text = "コピー";
            // 
            // ペーストToolStripMenuItem
            // 
            this.ペーストToolStripMenuItem.Name = "ペーストToolStripMenuItem";
            this.ペーストToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ペーストToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ペーストToolStripMenuItem.Text = "ペースト";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
            // 
            // リネイムToolStripMenuItem
            // 
            this.リネイムToolStripMenuItem.Name = "リネイムToolStripMenuItem";
            this.リネイムToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.リネイムToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.リネイムToolStripMenuItem.Text = "リネイム";
            // 
            // 値の編集ToolStripMenuItem
            // 
            this.値の編集ToolStripMenuItem.Name = "値の編集ToolStripMenuItem";
            this.値の編集ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.値の編集ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.値の編集ToolStripMenuItem.Text = "値の編集";
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            // 
            // 検索ToolStripMenuItem
            // 
            this.検索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.検索ToolStripMenuItem1,
            this.toolStripSeparator7,
            this.チャンク検索ToolStripMenuItem});
            this.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            this.検索ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.検索ToolStripMenuItem.Text = "検索(&F)";
            // 
            // 検索ToolStripMenuItem1
            // 
            this.検索ToolStripMenuItem1.Name = "検索ToolStripMenuItem1";
            this.検索ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.検索ToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.検索ToolStripMenuItem1.Text = "検索";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(134, 6);
            // 
            // チャンク検索ToolStripMenuItem
            // 
            this.チャンク検索ToolStripMenuItem.Name = "チャンク検索ToolStripMenuItem";
            this.チャンク検索ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.チャンク検索ToolStripMenuItem.Text = "チャンク検索";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 343);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "OrangeNBTEditor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_OpenFile;
        private System.Windows.Forms.ToolStripButton toolStrip_OpenDirectory;
        private System.Windows.Forms.ToolStripButton toolStrip_Save;
        private System.Windows.Forms.ToolStripButton toolStrip_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_Cut;
        private System.Windows.Forms.ToolStripButton toolStrip_Copy;
        private System.Windows.Forms.ToolStripButton toolStrip_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStrip_Rename;
        private System.Windows.Forms.ToolStripButton toolStrip_ValueEdit;
        private System.Windows.Forms.ToolStripButton toolStrip_Remove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagByte;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagShort;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagInt;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagLong;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagFloat;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagDouble;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagByteArray;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagIntArray;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagString;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagList;
        private System.Windows.Forms.ToolStripButton toolStrip_AddTagCompound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStrip_FindNext;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem クリアToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カットToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ペーストToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem リネイムToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 値の編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem チャンク検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}