using OragngeNBTEditor.NBT;
using OrangeNBT.NBT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeNBTEditor.Forms
{
    public partial class ValueEditForm : Form
    {
        public TagBase NBT { set; get; }

        public ValueEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueEditForm_Load(object sender, EventArgs e)
        {
            if (NBT != null)
            {
                switch (NBT.TagType)
                {
                    case TagType.String:
                        textBox1.Multiline = true;
                        this.Height = 200;
                        break;
                }
                textBox1.Text = NBTAccesser.GetValue(NBT);
            }
        }

        /// <summary>
        /// 完了ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (NBTAccesser.SetValue(NBT, textBox1.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("値の編集に失敗しました", "OrangeNBTEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// キャンセルボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
