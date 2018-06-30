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
    public partial class AddTagByte : Form
    {
        public AddTagByte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 選択されたノードのTagを格納
        /// </summary>
        public TagBase NodeName { get; set; }
        
        /// <summary>
        /// 追加するNameを格納
        /// </summary>
        public String AddName { get; set; }

        /// <summary>
        /// 追加するSizeを格納(空アリ)
        /// </summary>
        public int AddSize { get; set; }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTagByte_Load(object sender, EventArgs e)
        {
            switch (NodeName.TagType)
            {
                case TagType.ByteArray:
                    break;
                case TagType.IntArray:
                    break;
                case TagType.LongArray:
                    break;
                default:
                    textBox_Size.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// OKボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            TagAdder(NodeName.TagType);
        }

        /// <summary>
        /// Cancelボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TagAdder(TagType tagType)
        {
            if ((textBox_Name.Text == null) || (textBox_Name.TextLength == 0))
            {
                MessageBox.Show("Nameを入力してください\n", "OrangeNBTEditor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (tagType)
            {
                case TagType.ByteArray:
                    AddName = textBox_Name.Text;
                    try
                    {
                        AddSize = int.Parse(textBox_Size.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sizeは整数でなければいけません\n" + ex.Message, "OrangeNBTEditor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    this.DialogResult = DialogResult.OK;
                    break;
                case TagType.IntArray:
                    AddName = textBox_Name.Text;
                    try
                    {
                        AddSize = int.Parse(textBox_Size.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sizeは整数でなければいけません\n" + ex.Message, "OrangeNBTEditor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    this.DialogResult = DialogResult.OK;
                    break;
                case TagType.LongArray:
                    AddName = textBox_Name.Text;
                    try
                    {
                        AddSize = int.Parse(textBox_Size.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sizeは整数でなければいけません\n" + ex.Message, "OrangeNBTEditor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    this.DialogResult = DialogResult.OK;
                    break;
                default:
                    AddName = textBox_Name.Text;
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
