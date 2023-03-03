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
            helpToolStripMenuItem = new ToolStripMenuItem();
            panel_files = new Panel();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            button1 = new Button();
            panel_text = new Panel();
            textBox1 = new TextBox();
            label_name = new Label();
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
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button_close);
            panel1.Controls.Add(pictureBox_logo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 32);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button_close
            // 
            button_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_close.BackgroundImage = (Image)resources.GetObject("button_close.BackgroundImage");
            button_close.BackgroundImageLayout = ImageLayout.Center;
            button_close.Location = new Point(763, 0);
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
            label1.Location = new Point(376, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Editor";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(37, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(128, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator2, closeFolderToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(135, 22);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(135, 22);
            newToolStripMenuItem.Text = "new";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(135, 22);
            saveToolStripMenuItem.Text = "save";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(132, 6);
            // 
            // closeFolderToolStripMenuItem
            // 
            closeFolderToolStripMenuItem.Name = "closeFolderToolStripMenuItem";
            closeFolderToolStripMenuItem.Size = new Size(135, 22);
            closeFolderToolStripMenuItem.Text = "close folder";
            closeFolderToolStripMenuItem.Click += closeFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(135, 22);
            exitToolStripMenuItem.Text = "exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // panel_files
            // 
            panel_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_files.BackColor = SystemColors.ControlLight;
            panel_files.Controls.Add(treeView1);
            panel_files.Controls.Add(button1);
            panel_files.Location = new Point(0, 0);
            panel_files.Margin = new Padding(0);
            panel_files.Name = "panel_files";
            panel_files.Size = new Size(239, 469);
            panel_files.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.BackColor = SystemColors.ControlLight;
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(239, 469);
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
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Control;
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
            panel_text.BackColor = Color.Gainsboro;
            panel_text.Controls.Add(textBox1);
            panel_text.Controls.Add(panel_files);
            panel_text.Controls.Add(label_name);
            panel_text.Location = new Point(0, 32);
            panel_text.Name = "panel_text";
            panel_text.Size = new Size(800, 469);
            panel_text.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(238, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(563, 469);
            textBox1.TabIndex = 0;
            textBox1.Visible = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = Color.Gainsboro;
            label_name.Font = new Font("Monospac821 BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_name.ForeColor = Color.Black;
            label_name.Location = new Point(287, 65);
            label_name.Name = "label_name";
            label_name.Size = new Size(90, 75);
            label_name.TabIndex = 2;
            label_name.Text = "Loop\r\nEditor\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(panel_text);
            Controls.Add(panel1);
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
        private ToolStripMenuItem helpToolStripMenuItem;
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
        private Label label_name;
    }
}