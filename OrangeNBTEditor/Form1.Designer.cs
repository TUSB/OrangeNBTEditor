namespace SpringEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFilesSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutSB = new System.Windows.Forms.ToolStripButton();
            this.CopySB = new System.Windows.Forms.ToolStripButton();
            this.PasteSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RenameTagSB = new System.Windows.Forms.ToolStripButton();
            this.EditTagValueSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteTagSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddByteTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddStringTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddIntTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddLongTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddFloatTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddDoubleTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddByteArraySB = new System.Windows.Forms.ToolStripButton();
            this.AddIntArraySB = new System.Windows.Forms.ToolStripButton();
            this.AddLongArraySB = new System.Windows.Forms.ToolStripButton();
            this.AddStringArraySB = new System.Windows.Forms.ToolStripButton();
            this.AddListTagSB = new System.Windows.Forms.ToolStripButton();
            this.AddCompoundTagSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FindNextSB = new System.Windows.Forms.ToolStripButton();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.クリアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(695, 494);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
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
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 1;
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
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFilesSB,
            this.toolStripSeparator1,
            this.CutSB,
            this.CopySB,
            this.PasteSB,
            this.toolStripSeparator2,
            this.RenameTagSB,
            this.EditTagValueSB,
            this.DeleteTagSB,
            this.toolStripSeparator3,
            this.AddByteTagSB,
            this.AddStringTagSB,
            this.AddIntTagSB,
            this.AddLongTagSB,
            this.AddFloatTagSB,
            this.AddDoubleTagSB,
            this.AddByteArraySB,
            this.AddIntArraySB,
            this.AddLongArraySB,
            this.AddStringArraySB,
            this.AddListTagSB,
            this.AddCompoundTagSB,
            this.toolStripSeparator4,
            this.FindNextSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // OpenFilesSB
            // 
            this.OpenFilesSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFilesSB.Image = ((System.Drawing.Image)(resources.GetObject("OpenFilesSB.Image")));
            this.OpenFilesSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFilesSB.Name = "OpenFilesSB";
            this.OpenFilesSB.Size = new System.Drawing.Size(23, 22);
            this.OpenFilesSB.Text = "開く";
            this.OpenFilesSB.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CutSB
            // 
            this.CutSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutSB.Enabled = false;
            this.CutSB.Image = ((System.Drawing.Image)(resources.GetObject("CutSB.Image")));
            this.CutSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutSB.Name = "CutSB";
            this.CutSB.Size = new System.Drawing.Size(23, 22);
            this.CutSB.Text = "カット";
            // 
            // CopySB
            // 
            this.CopySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopySB.Enabled = false;
            this.CopySB.Image = ((System.Drawing.Image)(resources.GetObject("CopySB.Image")));
            this.CopySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopySB.Name = "CopySB";
            this.CopySB.Size = new System.Drawing.Size(23, 22);
            this.CopySB.Text = "コピー";
            // 
            // PasteSB
            // 
            this.PasteSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteSB.Enabled = false;
            this.PasteSB.Image = ((System.Drawing.Image)(resources.GetObject("PasteSB.Image")));
            this.PasteSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteSB.Name = "PasteSB";
            this.PasteSB.Size = new System.Drawing.Size(23, 22);
            this.PasteSB.Text = "ペースト";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RenameTagSB
            // 
            this.RenameTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RenameTagSB.Enabled = false;
            this.RenameTagSB.Image = ((System.Drawing.Image)(resources.GetObject("RenameTagSB.Image")));
            this.RenameTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RenameTagSB.Name = "RenameTagSB";
            this.RenameTagSB.Size = new System.Drawing.Size(23, 22);
            this.RenameTagSB.Text = "Rename Tag";
            // 
            // EditTagValueSB
            // 
            this.EditTagValueSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTagValueSB.Enabled = false;
            this.EditTagValueSB.Image = ((System.Drawing.Image)(resources.GetObject("EditTagValueSB.Image")));
            this.EditTagValueSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTagValueSB.Name = "EditTagValueSB";
            this.EditTagValueSB.Size = new System.Drawing.Size(23, 22);
            this.EditTagValueSB.Text = "Edit Tag Value";
            // 
            // DeleteTagSB
            // 
            this.DeleteTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTagSB.Enabled = false;
            this.DeleteTagSB.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTagSB.Image")));
            this.DeleteTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTagSB.Name = "DeleteTagSB";
            this.DeleteTagSB.Size = new System.Drawing.Size(23, 22);
            this.DeleteTagSB.Text = "Delete Tag";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AddByteTagSB
            // 
            this.AddByteTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddByteTagSB.Enabled = false;
            this.AddByteTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddByteTagSB.Image")));
            this.AddByteTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddByteTagSB.Name = "AddByteTagSB";
            this.AddByteTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddByteTagSB.Text = "Add Byte Tag";
            // 
            // AddStringTagSB
            // 
            this.AddStringTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStringTagSB.Enabled = false;
            this.AddStringTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddStringTagSB.Image")));
            this.AddStringTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStringTagSB.Name = "AddStringTagSB";
            this.AddStringTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddStringTagSB.Text = "Add Short Tag";
            // 
            // AddIntTagSB
            // 
            this.AddIntTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddIntTagSB.Enabled = false;
            this.AddIntTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddIntTagSB.Image")));
            this.AddIntTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddIntTagSB.Name = "AddIntTagSB";
            this.AddIntTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddIntTagSB.Text = "Add Int Tag";
            // 
            // AddLongTagSB
            // 
            this.AddLongTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLongTagSB.Enabled = false;
            this.AddLongTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddLongTagSB.Image")));
            this.AddLongTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLongTagSB.Name = "AddLongTagSB";
            this.AddLongTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddLongTagSB.Text = "Add Long Tag";
            // 
            // AddFloatTagSB
            // 
            this.AddFloatTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddFloatTagSB.Enabled = false;
            this.AddFloatTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddFloatTagSB.Image")));
            this.AddFloatTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFloatTagSB.Name = "AddFloatTagSB";
            this.AddFloatTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddFloatTagSB.Text = "Add Float Tag";
            // 
            // AddDoubleTagSB
            // 
            this.AddDoubleTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddDoubleTagSB.Enabled = false;
            this.AddDoubleTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddDoubleTagSB.Image")));
            this.AddDoubleTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDoubleTagSB.Name = "AddDoubleTagSB";
            this.AddDoubleTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddDoubleTagSB.Text = "Add Double Tag";
            // 
            // AddByteArraySB
            // 
            this.AddByteArraySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddByteArraySB.Enabled = false;
            this.AddByteArraySB.Image = ((System.Drawing.Image)(resources.GetObject("AddByteArraySB.Image")));
            this.AddByteArraySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddByteArraySB.Name = "AddByteArraySB";
            this.AddByteArraySB.Size = new System.Drawing.Size(23, 22);
            this.AddByteArraySB.Text = "Add Byte Array Tag";
            // 
            // AddIntArraySB
            // 
            this.AddIntArraySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddIntArraySB.Enabled = false;
            this.AddIntArraySB.Image = ((System.Drawing.Image)(resources.GetObject("AddIntArraySB.Image")));
            this.AddIntArraySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddIntArraySB.Name = "AddIntArraySB";
            this.AddIntArraySB.Size = new System.Drawing.Size(23, 22);
            this.AddIntArraySB.Text = "Add Int Array Tag";
            // 
            // AddLongArraySB
            // 
            this.AddLongArraySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLongArraySB.Enabled = false;
            this.AddLongArraySB.Image = ((System.Drawing.Image)(resources.GetObject("AddLongArraySB.Image")));
            this.AddLongArraySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLongArraySB.Name = "AddLongArraySB";
            this.AddLongArraySB.Size = new System.Drawing.Size(23, 22);
            this.AddLongArraySB.Text = "Add Long Array Tag";
            // 
            // AddStringArraySB
            // 
            this.AddStringArraySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStringArraySB.Enabled = false;
            this.AddStringArraySB.Image = ((System.Drawing.Image)(resources.GetObject("AddStringArraySB.Image")));
            this.AddStringArraySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStringArraySB.Name = "AddStringArraySB";
            this.AddStringArraySB.Size = new System.Drawing.Size(23, 22);
            this.AddStringArraySB.Text = "Add String Array Tag";
            // 
            // AddListTagSB
            // 
            this.AddListTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddListTagSB.Enabled = false;
            this.AddListTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddListTagSB.Image")));
            this.AddListTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddListTagSB.Name = "AddListTagSB";
            this.AddListTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddListTagSB.Text = "Add List Tag";
            // 
            // AddCompoundTagSB
            // 
            this.AddCompoundTagSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCompoundTagSB.Enabled = false;
            this.AddCompoundTagSB.Image = ((System.Drawing.Image)(resources.GetObject("AddCompoundTagSB.Image")));
            this.AddCompoundTagSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCompoundTagSB.Name = "AddCompoundTagSB";
            this.AddCompoundTagSB.Size = new System.Drawing.Size(23, 22);
            this.AddCompoundTagSB.Text = "Add Compound Tag";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // FindNextSB
            // 
            this.FindNextSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindNextSB.Image = ((System.Drawing.Image)(resources.GetObject("FindNextSB.Image")));
            this.FindNextSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindNextSB.Name = "FindNextSB";
            this.FindNextSB.Size = new System.Drawing.Size(23, 22);
            this.FindNextSB.Text = "Find / Find Next";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // クリアToolStripMenuItem
            // 
            this.クリアToolStripMenuItem.Name = "クリアToolStripMenuItem";
            this.クリアToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.クリアToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.クリアToolStripMenuItem.Text = "クリア";
            // 
            // カットToolStripMenuItem
            // 
            this.カットToolStripMenuItem.Name = "カットToolStripMenuItem";
            this.カットToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.カットToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.カットToolStripMenuItem.Text = "カット";
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.コピーToolStripMenuItem.Text = "コピー";
            // 
            // ペーストToolStripMenuItem
            // 
            this.ペーストToolStripMenuItem.Name = "ペーストToolStripMenuItem";
            this.ペーストToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ペーストToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ペーストToolStripMenuItem.Text = "ペースト";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // リネイムToolStripMenuItem
            // 
            this.リネイムToolStripMenuItem.Name = "リネイムToolStripMenuItem";
            this.リネイムToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.リネイムToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.リネイムToolStripMenuItem.Text = "リネイム";
            // 
            // 値の編集ToolStripMenuItem
            // 
            this.値の編集ToolStripMenuItem.Name = "値の編集ToolStripMenuItem";
            this.値の編集ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.値の編集ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.値の編集ToolStripMenuItem.Text = "値の編集";
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.検索ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.検索ToolStripMenuItem1.Text = "検索";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // チャンク検索ToolStripMenuItem
            // 
            this.チャンク検索ToolStripMenuItem.Name = "チャンク検索ToolStripMenuItem";
            this.チャンク検索ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.チャンク検索ToolStripMenuItem.Text = "チャンク検索";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 546);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OrangeNBTEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFilesSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CutSB;
        private System.Windows.Forms.ToolStripButton CopySB;
        private System.Windows.Forms.ToolStripButton PasteSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RenameTagSB;
        private System.Windows.Forms.ToolStripButton EditTagValueSB;
        private System.Windows.Forms.ToolStripButton DeleteTagSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton AddByteTagSB;
        private System.Windows.Forms.ToolStripButton AddStringTagSB;
        private System.Windows.Forms.ToolStripButton AddIntTagSB;
        private System.Windows.Forms.ToolStripButton AddLongTagSB;
        private System.Windows.Forms.ToolStripButton AddFloatTagSB;
        private System.Windows.Forms.ToolStripButton AddDoubleTagSB;
        private System.Windows.Forms.ToolStripButton AddByteArraySB;
        private System.Windows.Forms.ToolStripButton AddIntArraySB;
        private System.Windows.Forms.ToolStripButton AddLongArraySB;
        private System.Windows.Forms.ToolStripButton AddStringArraySB;
        private System.Windows.Forms.ToolStripButton AddListTagSB;
        private System.Windows.Forms.ToolStripButton AddCompoundTagSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton FindNextSB;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem クリアToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

