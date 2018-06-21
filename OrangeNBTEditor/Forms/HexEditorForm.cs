using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrangeNBT.NBT;

namespace OrangeNBTEditor.Forms
{
    public partial class HexEditorForm : Form
    {
        public TagByteArray NBT { set; get; }

        public HexEditorForm()
        {
            InitializeComponent();
        }

        private void HexEditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.hexBox1.ByteProvider = new Be.Windows.Forms.DynamicByteProvider(NBT.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show("バイナリデータを読み込めませんでした\n" + ex.Message, "OrangeNBTEditor",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
