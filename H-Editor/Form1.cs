using Microsoft.VisualBasic.Devices;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace H_Editor
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            button1.Select();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Visible = false;
            richTextBox1.Visible = false;
            label_opened_folder.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_full_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            switch (panel_files.Visible)
            {
                case true:
                    richTextBox1.Location = new Point(0, 0);
                    richTextBox1.Size = new Size(panel_text.Width, panel_text.Height);
                    panel_files.Visible = false;
                    break;
                case false:
                    richTextBox1.Location = new Point(treeView1.Width + 2, 0);
                    richTextBox1.Size = new Size(panel_text.Width - treeView1.Width, panel_text.Height);
                    panel_files.Visible = true;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath == "") { return; }

            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            treeView1.Visible = true;

            string[] partsofpath = folderBrowserDialog1.SelectedPath.Split('\\');
            label_opened_folder.Text = partsofpath[partsofpath.Length - 1];

            foreach (var item in Directory.GetDirectories(folderBrowserDialog1.SelectedPath))
            {
                DirectoryInfo id = new DirectoryInfo(item);
                var node = treeView1.Nodes.Add(id.Name, id.Name, 0, 1);
                node.Tag = id;
            }
            foreach (var item in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
            {
                FileInfo id = new FileInfo(item);
                var node = treeView1.Nodes.Add(id.Name, id.Name, 2, 3);
                node.Tag = id;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.GetType() == null)
            {
                // return
            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                e.Node.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo id = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(id.Name, id.Name, 0, 1);
                    node.Tag = id;
                }
                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo id = new FileInfo(item);
                    var node = e.Node.Nodes.Add(id.Name, id.Name, 2, 3);
                    node.Tag = id;
                }
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                richTextBox1.Visible = true;
                var file_path = e.Node.Tag.ToString();
                if (File.Exists(file_path))
                {
                    richTextBox1.Text = File.ReadAllText(file_path);
                }
                else
                {
                    // file doesn't exists
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)65)
            {
                button_min_Click(sender, e);
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K && e.Control)
            {
                richTextBox1.ZoomFactor += 0.1f;
            }
            else if (e.KeyCode == Keys.L && e.Control)
            {
                richTextBox1.ZoomFactor -= 0.1f;
            }
        }
    }
}