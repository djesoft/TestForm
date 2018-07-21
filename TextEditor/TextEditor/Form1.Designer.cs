namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu1 = new System.Windows.Forms.MenuStrip();
            this.File1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteModesToolMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteBeforeMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteAfterMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteOverMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NumberOfLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberOfCharacters = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Menu1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File1,
            this.Edit1,
            this.viewToolStripMenuItem,
            this.OptionsMenu1});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(800, 24);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "menuStrip1";
            // 
            // File1
            // 
            this.File1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenu1,
            this.OpenMenu1,
            this.toolStripSeparator2,
            this.SaveMenu1,
            this.SaveAsMenu1,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.ExitMenu1});
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(37, 20);
            this.File1.Text = "&File";
            // 
            // NewMenu1
            // 
            this.NewMenu1.Image = ((System.Drawing.Image)(resources.GetObject("NewMenu1.Image")));
            this.NewMenu1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewMenu1.Name = "NewMenu1";
            this.NewMenu1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenu1.Size = new System.Drawing.Size(180, 22);
            this.NewMenu1.Text = "&New";
            this.NewMenu1.Click += new System.EventHandler(this.NewMenu1_Click);
            // 
            // OpenMenu1
            // 
            this.OpenMenu1.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenu1.Image")));
            this.OpenMenu1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenMenu1.Name = "OpenMenu1";
            this.OpenMenu1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenu1.Size = new System.Drawing.Size(180, 22);
            this.OpenMenu1.Text = "&Open";
            this.OpenMenu1.Click += new System.EventHandler(this.OpenMenu1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveMenu1
            // 
            this.SaveMenu1.Enabled = false;
            this.SaveMenu1.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenu1.Image")));
            this.SaveMenu1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMenu1.Name = "SaveMenu1";
            this.SaveMenu1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenu1.Size = new System.Drawing.Size(180, 22);
            this.SaveMenu1.Text = "&Save";
            this.SaveMenu1.Click += new System.EventHandler(this.SaveMenu1_Click);
            // 
            // SaveAsMenu1
            // 
            this.SaveAsMenu1.Name = "SaveAsMenu1";
            this.SaveAsMenu1.Size = new System.Drawing.Size(180, 22);
            this.SaveAsMenu1.Text = "Save &As";
            this.SaveAsMenu1.Click += new System.EventHandler(this.SaveAsMenu1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitMenu1
            // 
            this.ExitMenu1.Name = "ExitMenu1";
            this.ExitMenu1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMenu1.Size = new System.Drawing.Size(180, 22);
            this.ExitMenu1.Text = "E&xit";
            this.ExitMenu1.Click += new System.EventHandler(this.ExitMenu1_Click);
            // 
            // Edit1
            // 
            this.Edit1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo1,
            this.Redo1,
            this.toolStripSeparator5,
            this.Cut1,
            this.Copy1,
            this.Paste1,
            this.toolStripSeparator6,
            this.SelectAll1});
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(39, 20);
            this.Edit1.Text = "&Edit";
            this.Edit1.DropDownOpening += new System.EventHandler(this.Edit1_DropDownOpening);
            // 
            // Undo1
            // 
            this.Undo1.Name = "Undo1";
            this.Undo1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Undo1.Size = new System.Drawing.Size(180, 22);
            this.Undo1.Text = "&Undo";
            this.Undo1.Click += new System.EventHandler(this.Undo1_Click);
            // 
            // Redo1
            // 
            this.Redo1.Name = "Redo1";
            this.Redo1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Redo1.Size = new System.Drawing.Size(180, 22);
            this.Redo1.Text = "&Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // Cut1
            // 
            this.Cut1.Image = ((System.Drawing.Image)(resources.GetObject("Cut1.Image")));
            this.Cut1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut1.Name = "Cut1";
            this.Cut1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut1.Size = new System.Drawing.Size(180, 22);
            this.Cut1.Text = "Cu&t";
            this.Cut1.Click += new System.EventHandler(this.Cut1_Click);
            // 
            // Copy1
            // 
            this.Copy1.Image = ((System.Drawing.Image)(resources.GetObject("Copy1.Image")));
            this.Copy1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy1.Name = "Copy1";
            this.Copy1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy1.Size = new System.Drawing.Size(180, 22);
            this.Copy1.Text = "&Copy";
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // Paste1
            // 
            this.Paste1.Image = ((System.Drawing.Image)(resources.GetObject("Paste1.Image")));
            this.Paste1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste1.Name = "Paste1";
            this.Paste1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste1.Size = new System.Drawing.Size(180, 22);
            this.Paste1.Text = "&Paste";
            this.Paste1.Click += new System.EventHandler(this.Paste1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // SelectAll1
            // 
            this.SelectAll1.Name = "SelectAll1";
            this.SelectAll1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll1.Size = new System.Drawing.Size(180, 22);
            this.SelectAll1.Text = "Select &All";
            this.SelectAll1.Click += new System.EventHandler(this.SelectAll1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarMenu1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // ToolbarMenu1
            // 
            this.ToolbarMenu1.Checked = true;
            this.ToolbarMenu1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolbarMenu1.Name = "ToolbarMenu1";
            this.ToolbarMenu1.Size = new System.Drawing.Size(180, 22);
            this.ToolbarMenu1.Text = "Toolbar";
            this.ToolbarMenu1.Click += new System.EventHandler(this.ToolbarMenu1_Click);
            // 
            // OptionsMenu1
            // 
            this.OptionsMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.PasteModesToolMenu1});
            this.OptionsMenu1.Name = "OptionsMenu1";
            this.OptionsMenu1.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu1.Text = "&Options";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // PasteModesToolMenu1
            // 
            this.PasteModesToolMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteBeforeMenu1,
            this.PasteAfterMenu1,
            this.PasteOverMenu1});
            this.PasteModesToolMenu1.Name = "PasteModesToolMenu1";
            this.PasteModesToolMenu1.Size = new System.Drawing.Size(180, 22);
            this.PasteModesToolMenu1.Text = "Paste Modes";
            this.PasteModesToolMenu1.DropDownOpening += new System.EventHandler(this.PasteModesToolMenu1_DropDownOpening);
            // 
            // PasteBeforeMenu1
            // 
            this.PasteBeforeMenu1.Name = "PasteBeforeMenu1";
            this.PasteBeforeMenu1.Size = new System.Drawing.Size(189, 22);
            this.PasteBeforeMenu1.Text = "Paste before selection";
            this.PasteBeforeMenu1.Click += new System.EventHandler(this.PasteBeforeMenu1_Click);
            // 
            // PasteAfterMenu1
            // 
            this.PasteAfterMenu1.Name = "PasteAfterMenu1";
            this.PasteAfterMenu1.Size = new System.Drawing.Size(189, 22);
            this.PasteAfterMenu1.Text = "Paste after selection";
            this.PasteAfterMenu1.Click += new System.EventHandler(this.PasteAfterMenu1_Click);
            // 
            // PasteOverMenu1
            // 
            this.PasteOverMenu1.Name = "PasteOverMenu1";
            this.PasteOverMenu1.Size = new System.Drawing.Size(189, 22);
            this.PasteOverMenu1.Text = "Paste over selection";
            this.PasteOverMenu1.Click += new System.EventHandler(this.PasteOverMenu1_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "Text files|*.txt";
            this.OpenFileDialog1.Title = "Open text file";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.DefaultExt = "txt";
            this.SaveFileDialog1.Filter = "Text Files|*.txt";
            this.SaveFileDialog1.Title = "Save text file";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.StatusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 426);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.MouseEnter += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_MouseEnter);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberOfLines,
            this.NumberOfCharacters});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 0);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.ShowItemToolTips = true;
            this.StatusStrip1.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip1.TabIndex = 2;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // NumberOfLines
            // 
            this.NumberOfLines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NumberOfLines.Name = "NumberOfLines";
            this.NumberOfLines.Size = new System.Drawing.Size(43, 17);
            this.NumberOfLines.Text = "0 Lines";
            this.NumberOfLines.ToolTipText = "Number of lines seperated by carriage return / line feed";
            // 
            // NumberOfCharacters
            // 
            this.NumberOfCharacters.Name = "NumberOfCharacters";
            this.NumberOfCharacters.Size = new System.Drawing.Size(72, 17);
            this.NumberOfCharacters.Text = "0 Characters";
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.HideSelection = false;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.MaxLength = 0;
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(800, 379);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.ModifiedChanged += new System.EventHandler(this.TextBox1_ModifiedChanged);
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            this.TextBox1.MouseEnter += new System.EventHandler(this.TextBox1_MouseEnter);
            this.TextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.PasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(199, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "&New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewMenu1_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenMenu1_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Enabled = false;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveMenu1_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // CutToolStripButton
            // 
            this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStripButton.Enabled = false;
            this.CutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripButton.Image")));
            this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripButton.Name = "CutToolStripButton";
            this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CutToolStripButton.Text = "C&ut";
            this.CutToolStripButton.Click += new System.EventHandler(this.Cut1_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Enabled = false;
            this.CopyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripButton.Image")));
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "&Copy";
            this.CopyToolStripButton.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // PasteToolStripButton
            // 
            this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteToolStripButton.Enabled = false;
            this.PasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripButton.Image")));
            this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripButton.Name = "PasteToolStripButton";
            this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PasteToolStripButton.Text = "&Paste";
            this.PasteToolStripButton.Click += new System.EventHandler(this.Paste1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Enabled = false;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Menu1);
            this.MainMenuStrip = this.Menu1;
            this.Name = "Form1";
            this.Text = "A Simple Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton CutToolStripButton;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripButton PasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem File1;
        private System.Windows.Forms.ToolStripMenuItem NewMenu1;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit1;
        private System.Windows.Forms.ToolStripMenuItem Undo1;
        private System.Windows.Forms.ToolStripMenuItem Redo1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Cut1;
        private System.Windows.Forms.ToolStripMenuItem Copy1;
        private System.Windows.Forms.ToolStripMenuItem Paste1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem SelectAll1;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu1;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteModesToolMenu1;
        private System.Windows.Forms.ToolStripMenuItem ToolbarMenu1;
        private System.Windows.Forms.ToolStripMenuItem PasteBeforeMenu1;
        private System.Windows.Forms.ToolStripMenuItem PasteAfterMenu1;
        private System.Windows.Forms.ToolStripMenuItem PasteOverMenu1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NumberOfLines;
        private System.Windows.Forms.ToolStripStatusLabel NumberOfCharacters;
    }
}

