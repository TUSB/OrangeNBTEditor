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


namespace OrangeNBTEditor.Forms
{
    public partial class RenameForm : Form
    {
        public TagBase NBT { set; get; }

        public RenameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameForm_Load(object sender, EventArgs e)
        {
            if (NBT != null)
            {
                textBox1.Text = NBT.Name;
            }
        }

        /// <summary>
        /// 完了ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NBT.Rename(textBox1.Text);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 閉じるボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
