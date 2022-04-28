using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog() { Description = "Выберите свой путь" })
            {
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(browserDialog.SelectedPath);
                    fileTextBox.Text = browserDialog.SelectedPath;
                }
            }
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }
    }
}
