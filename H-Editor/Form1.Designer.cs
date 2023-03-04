namespace H_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button_min = new Button();
            button_full = new Button();
            button_close = new Button();
            pictureBox_logo = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            closeFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            panel_files = new Panel();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            button1 = new Button();
            panel_text = new Panel();
            textBox1 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            menuStrip1.SuspendLayout();
            panel_files.SuspendLayout();
            panel_text.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(62, 62, 66);
            panel1.Controls.Add(button_min);
            panel1.Controls.Add(button_full);
            panel1.Controls.Add(button_close);
            panel1.Controls.Add(pictureBox_logo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 32);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button_min
            // 
            button_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_min.BackgroundImage = (Image)resources.GetObject("button_min.BackgroundImage");
            button_min.BackgroundImageLayout = ImageLayout.Center;
            button_min.FlatAppearance.BorderSize = 0;
            button_min.FlatStyle = FlatStyle.Flat;
            button_min.Location = new Point(889, 0);
            button_min.Name = "button_min";
            button_min.Padding = new Padding(5);
            button_min.Size = new Size(34, 32);
            button_min.TabIndex = 2;
            button_min.UseVisualStyleBackColor = true;
            button_min.Click += button_min_Click;
            // 
            // button_full
            // 
            button_full.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_full.BackgroundImage = (Image)resources.GetObject("button_full.BackgroundImage");
            button_full.BackgroundImageLayout = ImageLayout.Center;
            button_full.FlatAppearance.BorderSize = 0;
            button_full.FlatStyle = FlatStyle.Flat;
            button_full.Location = new Point(925, 0);
            button_full.Name = "button_full";
            button_full.Padding = new Padding(5);
            button_full.Size = new Size(34, 32);
            button_full.TabIndex = 2;
            button_full.UseVisualStyleBackColor = true;
            button_full.Click += button_full_Click;
            // 
            // button_close
            // 
            button_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_close.BackgroundImage = (Image)resources.GetObject("button_close.BackgroundImage");
            button_close.BackgroundImageLayout = ImageLayout.Center;
            button_close.FlatAppearance.BorderSize = 0;
            button_close.FlatStyle = FlatStyle.Flat;
            button_close.Location = new Point(961, 0);
            button_close.Name = "button_close";
            button_close.Padding = new Padding(5);
            button_close.Size = new Size(34, 32);
            button_close.TabIndex = 2;
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Image = (Image)resources.GetObject("pictureBox_logo.Image");
            pictureBox_logo.Location = new Point(8, 2);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(30, 28);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 1;
            pictureBox_logo.TabStop = false;
            pictureBox_logo.Click += pictureBox_logo_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(458, 7);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 1;
            label1.Text = "infinity editor";
            label1.MouseDown += panel1_MouseDown;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(62, 62, 66);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(37, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(84, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            fileToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            fileToolStripMenuItem.Checked = true;
            fileToolStripMenuItem.CheckState = CheckState.Checked;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator2, closeFolderToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            openToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(135, 22);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            newToolStripMenuItem.ForeColor = Color.White;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(135, 22);
            newToolStripMenuItem.Text = "new";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(135, 22);
            saveToolStripMenuItem.Text = "save";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = Color.FromArgb(62, 62, 66);
            toolStripSeparator2.ForeColor = Color.White;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(132, 6);
            // 
            // closeFolderToolStripMenuItem
            // 
            closeFolderToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            closeFolderToolStripMenuItem.ForeColor = Color.White;
            closeFolderToolStripMenuItem.Name = "closeFolderToolStripMenuItem";
            closeFolderToolStripMenuItem.Size = new Size(135, 22);
            closeFolderToolStripMenuItem.Text = "close folder";
            closeFolderToolStripMenuItem.Click += closeFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = Color.FromArgb(62, 62, 66);
            toolStripSeparator1.ForeColor = Color.Black;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(135, 22);
            exitToolStripMenuItem.Text = "exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.FromArgb(62, 62, 66);
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(93, 22);
            testToolStripMenuItem.Text = "test";
            // 
            // panel_files
            // 
            panel_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_files.BackColor = Color.FromArgb(45, 45, 48);
            panel_files.Controls.Add(treeView1);
            panel_files.Controls.Add(button1);
            panel_files.ForeColor = Color.White;
            panel_files.Location = new Point(0, 0);
            panel_files.Margin = new Padding(0);
            panel_files.Name = "panel_files";
            panel_files.Size = new Size(239, 667);
            panel_files.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.BackColor = Color.FromArgb(45, 45, 48);
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(239, 667);
            treeView1.StateImageList = imageList1;
            treeView1.TabIndex = 1;
            treeView1.Visible = false;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "open-folder.png");
            imageList1.Images.SetKeyName(2, "file.png");
            imageList1.Images.SetKeyName(3, "open-file.png");
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(32, 52);
            button1.Name = "button1";
            button1.Size = new Size(172, 30);
            button1.TabIndex = 0;
            button1.Text = "Open Folder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel_text
            // 
            panel_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_text.BackColor = Color.FromArgb(30, 30, 30);
            panel_text.Controls.Add(textBox1);
            panel_text.Controls.Add(panel_files);
            panel_text.Location = new Point(0, 32);
            panel_text.Name = "panel_text";
            panel_text.Size = new Size(998, 667);
            panel_text.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(238, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(761, 667);
            textBox1.TabIndex = 0;
            textBox1.Visible = false;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 62, 66);
            ClientSize = new Size(998, 698);
            ControlBox = false;
            Controls.Add(panel_text);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_files.ResumeLayout(false);
            panel_text.ResumeLayout(false);
            panel_text.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private PictureBox pictureBox_logo;
        private Panel panel_files;
        private Panel panel_text;
        private Button button1;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TreeView treeView1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeFolderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ImageList imageList1;
        private Button button_close;
        private Button button_min;
        private Button button_full;
        private ToolStripMenuItem testToolStripMenuItem;
    }
}