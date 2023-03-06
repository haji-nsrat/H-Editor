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
            label_file_name.Visible = false;
            button_close_file.Visible = false;
            button_save_file.Visible = false;

            button_new_file.Visible = false;
            button_new_folder.Visible = false;
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

            treeView1.ImageList = imageList1;
            treeView1.Visible = true;
            button_new_file.Visible = true;
            button_new_folder.Visible = true;
            button_refresh_tree.Visible = true;

            add_and_refresh_dir();
        }
        private void add_and_refresh_dir()
        {
            treeView1.Nodes.Clear();

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
                    label_file_name.Visible = true;
                    button_close_file.Visible = true;
                    button_save_file.Visible = true;

                    string[] partsofpath = file_path.Split('\\');
                    label_file_name.Text = partsofpath[partsofpath.Length - 1];


                    richTextBox1.Text = File.ReadAllText(file_path);
                    button_save_file.Text = "save";
                }
                Cursor.Current = Cursors.Default;
            }
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
            else if (e.KeyCode == Keys.S && e.Control)
            {
                button_save_file_Click(sender, e);
            }
        }

        // create
        private string is_it_file_or_folder = "";
        private void button_new_folder_Click(object sender, EventArgs e)
        {
            textBox_new.Visible = true;
            button_close_box.Visible = true;
            button_new_file.Visible = false;
            button_new_folder.Visible = false;
            button_refresh_tree.Visible = false;
            is_it_file_or_folder = "folder";
        }

        private void button_new_file_Click(object sender, EventArgs e)
        {
            textBox_new.Visible = true;
            button_close_box.Visible = true;
            button_new_file.Visible = false;
            button_new_folder.Visible = false;
            button_refresh_tree.Visible = false;
            is_it_file_or_folder = "file";
        }


        private void textBox_new_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ff_name = textBox_new.Text;

                if (is_it_file_or_folder == "folder")
                {
                    string path = folderBrowserDialog1.SelectedPath + "\\" + ff_name;

                    bool exists = System.IO.Directory.Exists(path);

                    if (!exists)
                        System.IO.Directory.CreateDirectory(path);
                }
                else
                {
                    string path = folderBrowserDialog1.SelectedPath + "\\" + ff_name;
                    if (!System.IO.File.Exists(path))
                        System.IO.File.Create(path).Close();
                }
                textBox_new.Text = "";
                textBox_new.Visible = false;
                button_close_box.Visible = false;
                button_new_file.Visible = true;
                button_new_folder.Visible = true;
                button_refresh_tree.Visible = true;
                add_and_refresh_dir();
            }

        }

        private void button_close_box_Click(object sender, EventArgs e)
        {
            textBox_new.Text = "";
            textBox_new.Visible = false;
            button_close_box.Visible = false;
            button_new_file.Visible = true;
            button_new_folder.Visible = true;
            button_refresh_tree.Visible = true;
            add_and_refresh_dir();
        }

        private void button_close_file_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            label_file_name.Visible = false;
            button_close_file.Visible = false;
            button_save_file.Visible = false;
        }

        private void button_save_file_Click(object sender, EventArgs e)
        {
            string file_path = folderBrowserDialog1.SelectedPath + "\\" + label_file_name.Text;
            File.WriteAllText(file_path, richTextBox1.Text);
            button_save_file.Text = "save";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button_save_file.Text = "save *";
        }

        private void button_refresh_tree_Click(object sender, EventArgs e)
        {
            add_and_refresh_dir();
        }
    }
}