using System;
using System.Windows.Forms;

namespace OragngeNBTEditor
{
    internal static class Program
    {
        /// <summary>
        ///     アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrangeNBTEditor.Forms.MainWindow());
        }
    }
}