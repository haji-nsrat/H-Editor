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
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            treeView1.Nodes.Clear();

            foreach (var item in Directory.GetDirectories(folderBrowserDialog1.SelectedPath))
            {
                DirectoryInfo id = new DirectoryInfo(item);
                var node = treeView1.Nodes.Add(id.Name, id.Name, 0, 0);
                node.Tag = id;
            }
            foreach (var item in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
            {
                FileInfo id = new FileInfo(item);
                var node = treeView1.Nodes.Add(id.Name, id.Name, 0, 0);
                node.Tag = id;
            }
            treeView1.Visible = true;
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
                    var node = e.Node.Nodes.Add(id.Name, id.Name, 0, 0);
                    node.Tag = id;
                }
                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo id = new FileInfo(item);
                    var node = e.Node.Nodes.Add(id.Name, id.Name, 0, 0);
                    node.Tag = id;
                }
            }
            else
            {
                textBox1.Visible = true;
                textBox1.Text = "testing on pc";
            }
        }
    }
}