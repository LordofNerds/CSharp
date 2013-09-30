namespace TextEditor
{
    partial class TextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_Customisation = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tb_Italics = new System.Windows.Forms.ToolStripButton();
            this.tb_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.tb_Strike = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_LeftAlign = new System.Windows.Forms.ToolStripButton();
            this.tb_CenterAlign = new System.Windows.Forms.ToolStripButton();
            this.tb_RightAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_TextUp = new System.Windows.Forms.ToolStripButton();
            this.tb_TextDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tb_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Font = new System.Windows.Forms.ToolStripComboBox();
            this.tb_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.Status.SuspendLayout();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AccessibleName = "my_file";
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(976, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator,
            this.file_Save,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(167, 24);
            this.file_New.Text = "New";
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(167, 24);
            this.file_Open.Text = "Open";
            this.file_Open.Click += new System.EventHandler(this.file_Open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(167, 24);
            this.file_Save.Text = "Save";
            this.file_Save.Click += new System.EventHandler(this.file_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Undo,
            this.edit_Redo,
            this.toolStripSeparator3,
            this.edit_Cut,
            this.edit_Copy,
            this.edit_Paste,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // edit_Undo
            // 
            this.edit_Undo.Name = "edit_Undo";
            this.edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.edit_Undo.Size = new System.Drawing.Size(165, 24);
            this.edit_Undo.Text = "Undo";
            this.edit_Undo.Click += new System.EventHandler(this.edit_Undo_Click);
            // 
            // edit_Redo
            // 
            this.edit_Redo.Name = "edit_Redo";
            this.edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.edit_Redo.Size = new System.Drawing.Size(165, 24);
            this.edit_Redo.Text = "Redo";
            this.edit_Redo.Click += new System.EventHandler(this.edit_Redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // edit_Cut
            // 
            this.edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("edit_Cut.Image")));
            this.edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Cut.Name = "edit_Cut";
            this.edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.edit_Cut.Size = new System.Drawing.Size(165, 24);
            this.edit_Cut.Text = "Cut";
            this.edit_Cut.Click += new System.EventHandler(this.edit_Cut_Click);
            // 
            // edit_Copy
            // 
            this.edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("edit_Copy.Image")));
            this.edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Copy.Name = "edit_Copy";
            this.edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edit_Copy.Size = new System.Drawing.Size(165, 24);
            this.edit_Copy.Text = "Copy";
            this.edit_Copy.Click += new System.EventHandler(this.edit_Copy_Click);
            // 
            // edit_Paste
            // 
            this.edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("edit_Paste.Image")));
            this.edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Paste.Name = "edit_Paste";
            this.edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.edit_Paste.Size = new System.Drawing.Size(165, 24);
            this.edit_Paste.Text = "Paste";
            this.edit_Paste.Click += new System.EventHandler(this.edit_Paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_Customisation,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tools_Customisation
            // 
            this.tools_Customisation.Name = "tools_Customisation";
            this.tools_Customisation.Size = new System.Drawing.Size(172, 24);
            this.tools_Customisation.Text = "Customisation";
            this.tools_Customisation.Click += new System.EventHandler(this.tools_Customisation_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // Tools
            // 
            this.Tools.AccessibleName = "my_edit";
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator6,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste,
            this.toolStripSeparator7,
            this.tb_Bold,
            this.tb_Italics,
            this.tb_UnderLine,
            this.tb_Strike,
            this.toolStripSeparator8,
            this.tb_LeftAlign,
            this.tb_CenterAlign,
            this.tb_RightAlign,
            this.toolStripSeparator11,
            this.tb_TextUp,
            this.tb_TextDown,
            this.toolStripSeparator9,
            this.tb_ZoomIn,
            this.tb_ZoomOut,
            this.toolStripSeparator10,
            this.tb_Font,
            this.tb_FontSize,
            this.toolStripSeparator12});
            this.Tools.Location = new System.Drawing.Point(0, 28);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(976, 28);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            this.tb_New.AccessibleName = "tb_New";
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 25);
            this.tb_New.Text = "&New";
            this.tb_New.Click += new System.EventHandler(this.tb_New_Click);
            // 
            // tb_Open
            // 
            this.tb_Open.AccessibleName = "tb_Open";
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 25);
            this.tb_Open.Text = "&Open";
            this.tb_Open.Click += new System.EventHandler(this.tb_Open_Click);
            // 
            // tb_Save
            // 
            this.tb_Save.AccessibleName = "tb_Save";
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 25);
            this.tb_Save.Text = "&Save";
            this.tb_Save.Click += new System.EventHandler(this.tb_Save_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_Cut
            // 
            this.tb_Cut.AccessibleName = "tb_Cut";
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tb_Cut.Image")));
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 25);
            this.tb_Cut.Text = "C&ut";
            this.tb_Cut.Click += new System.EventHandler(this.tb_Cut_Click);
            // 
            // tb_Copy
            // 
            this.tb_Copy.AccessibleName = "tb_Copy";
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tb_Copy.Image")));
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 25);
            this.tb_Copy.Text = "&Copy";
            this.tb_Copy.Click += new System.EventHandler(this.tb_Copy_Click);
            // 
            // tb_Paste
            // 
            this.tb_Paste.AccessibleName = "tb_Paste";
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tb_Paste.Image")));
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 25);
            this.tb_Paste.Text = "&Paste";
            this.tb_Paste.Click += new System.EventHandler(this.tb_Paste_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_Bold
            // 
            this.tb_Bold.AccessibleName = "tb_Bold";
            this.tb_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Bold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tb_Bold.Image")));
            this.tb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Bold.Name = "tb_Bold";
            this.tb_Bold.Size = new System.Drawing.Size(23, 25);
            this.tb_Bold.Text = "B";
            this.tb_Bold.Click += new System.EventHandler(this.tb_Bold_Click);
            // 
            // tb_Italics
            // 
            this.tb_Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Italics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic);
            this.tb_Italics.Image = ((System.Drawing.Image)(resources.GetObject("tb_Italics.Image")));
            this.tb_Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Italics.Name = "tb_Italics";
            this.tb_Italics.Size = new System.Drawing.Size(23, 25);
            this.tb_Italics.Text = "I";
            this.tb_Italics.Click += new System.EventHandler(this.tb_Italics_Click);
            // 
            // tb_UnderLine
            // 
            this.tb_UnderLine.AccessibleName = "tb_UnderLine";
            this.tb_UnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_UnderLine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline);
            this.tb_UnderLine.Image = ((System.Drawing.Image)(resources.GetObject("tb_UnderLine.Image")));
            this.tb_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UnderLine.Name = "tb_UnderLine";
            this.tb_UnderLine.Size = new System.Drawing.Size(23, 25);
            this.tb_UnderLine.Text = "U";
            this.tb_UnderLine.Click += new System.EventHandler(this.tb_UnderLine_Click);
            // 
            // tb_Strike
            // 
            this.tb_Strike.AccessibleName = "tb_Strike";
            this.tb_Strike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Strike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Strikeout);
            this.tb_Strike.Image = ((System.Drawing.Image)(resources.GetObject("tb_Strike.Image")));
            this.tb_Strike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Strike.Name = "tb_Strike";
            this.tb_Strike.Size = new System.Drawing.Size(23, 25);
            this.tb_Strike.Text = "S";
            this.tb_Strike.Click += new System.EventHandler(this.tb_Strike_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_LeftAlign
            // 
            this.tb_LeftAlign.AccessibleName = "tb_LeftAlign";
            this.tb_LeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_LeftAlign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_LeftAlign.Image = ((System.Drawing.Image)(resources.GetObject("tb_LeftAlign.Image")));
            this.tb_LeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_LeftAlign.Name = "tb_LeftAlign";
            this.tb_LeftAlign.Size = new System.Drawing.Size(23, 25);
            this.tb_LeftAlign.Text = "L";
            this.tb_LeftAlign.Click += new System.EventHandler(this.tb_LeftAlign_Click);
            // 
            // tb_CenterAlign
            // 
            this.tb_CenterAlign.AccessibleName = "tb_CenterAlign";
            this.tb_CenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_CenterAlign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_CenterAlign.Image = ((System.Drawing.Image)(resources.GetObject("tb_CenterAlign.Image")));
            this.tb_CenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_CenterAlign.Name = "tb_CenterAlign";
            this.tb_CenterAlign.Size = new System.Drawing.Size(23, 25);
            this.tb_CenterAlign.Text = "C";
            this.tb_CenterAlign.Click += new System.EventHandler(this.tb_CenterAlign_Click);
            // 
            // tb_RightAlign
            // 
            this.tb_RightAlign.AccessibleName = "tb_RightAlign";
            this.tb_RightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_RightAlign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_RightAlign.Image = ((System.Drawing.Image)(resources.GetObject("tb_RightAlign.Image")));
            this.tb_RightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_RightAlign.Name = "tb_RightAlign";
            this.tb_RightAlign.Size = new System.Drawing.Size(23, 25);
            this.tb_RightAlign.Text = "R";
            this.tb_RightAlign.Click += new System.EventHandler(this.tb_RightAlign_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_TextUp
            // 
            this.tb_TextUp.AccessibleName = "tb_TextUp";
            this.tb_TextUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_TextUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_TextUp.Image = ((System.Drawing.Image)(resources.GetObject("tb_TextUp.Image")));
            this.tb_TextUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_TextUp.Name = "tb_TextUp";
            this.tb_TextUp.Size = new System.Drawing.Size(23, 25);
            this.tb_TextUp.Text = "A";
            this.tb_TextUp.Click += new System.EventHandler(this.tb_TextUp_Click);
            // 
            // tb_TextDown
            // 
            this.tb_TextDown.AccessibleName = "tb_TextDown";
            this.tb_TextDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_TextDown.Image = ((System.Drawing.Image)(resources.GetObject("tb_TextDown.Image")));
            this.tb_TextDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_TextDown.Name = "tb_TextDown";
            this.tb_TextDown.Size = new System.Drawing.Size(23, 25);
            this.tb_TextDown.Text = "a";
            this.tb_TextDown.Click += new System.EventHandler(this.tb_TextDown_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_ZoomIn
            // 
            this.tb_ZoomIn.AccessibleName = "tb_ZoomIn";
            this.tb_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.tb_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomIn.Image")));
            this.tb_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomIn.Name = "tb_ZoomIn";
            this.tb_ZoomIn.Size = new System.Drawing.Size(23, 25);
            this.tb_ZoomIn.Text = "+";
            this.tb_ZoomIn.Click += new System.EventHandler(this.tb_ZoomIn_Click);
            // 
            // tb_ZoomOut
            // 
            this.tb_ZoomOut.AccessibleName = "tb_ZoomOut";
            this.tb_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomOut.Image")));
            this.tb_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomOut.Name = "tb_ZoomOut";
            this.tb_ZoomOut.Size = new System.Drawing.Size(23, 25);
            this.tb_ZoomOut.Text = "-";
            this.tb_ZoomOut.Click += new System.EventHandler(this.tb_ZoomOut_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
            // 
            // tb_Font
            // 
            this.tb_Font.AccessibleName = "tb_Font";
            this.tb_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Font.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_Font.Name = "tb_Font";
            this.tb_Font.Size = new System.Drawing.Size(160, 28);
            this.tb_Font.SelectedIndexChanged += new System.EventHandler(this.tb_Font_SelectedIndexChanged);
            this.tb_Font.Click += new System.EventHandler(this.tb_Font_Click);
            // 
            // tb_FontSize
            // 
            this.tb_FontSize.AccessibleName = "tb_FontSize";
            this.tb_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_FontSize.Name = "tb_FontSize";
            this.tb_FontSize.Size = new System.Drawing.Size(160, 28);
            this.tb_FontSize.SelectedIndexChanged += new System.EventHandler(this.tb_FontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 28);
            // 
            // Status
            // 
            this.Status.AccessibleDescription = "Status";
            this.Status.AccessibleName = "Status";
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charCount,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.Status.Location = new System.Drawing.Point(0, 509);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.Status.Size = new System.Drawing.Size(976, 25);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // charCount
            // 
            this.charCount.AccessibleDescription = "charCount";
            this.charCount.AccessibleName = "charCount";
            this.charCount.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(76, 20);
            this.charCount.Text = "charCount";
            this.charCount.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(831, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel3.Text = "Zoom";
            // 
            // Document
            // 
            this.Document.AccessibleDescription = "Document";
            this.Document.AccessibleName = "Document";
            this.Document.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.Document.ContextMenuStrip = this.rcMenu;
            this.Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Document.Location = new System.Drawing.Point(0, 56);
            this.Document.Margin = new System.Windows.Forms.Padding(4);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(976, 453);
            this.Document.TabIndex = 3;
            this.Document.Text = "";
            this.Document.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.tb_Italic_LinkClicked);
            this.Document.TextChanged += new System.EventHandler(this.tb_Italic_TextChanged);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator13,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(115, 130);
            this.rcMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rcMenu_Opening);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(111, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // openWork
            // 
            this.openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openWork.Title = "Open Work";
            // 
            // saveWork
            // 
            this.saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveWork.Title = "Save Work";
            this.saveWork.FileOk += new System.ComponentModel.CancelEventHandler(this.saveWork_FileOk);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 534);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(991, 571);
            this.Name = "TextEditor";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.RichTextBox Document;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tools_Customisation;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tb_Bold;
        private System.Windows.Forms.ToolStripButton tb_Italics;
        private System.Windows.Forms.ToolStripButton tb_UnderLine;
        private System.Windows.Forms.ToolStripButton tb_Strike;
        private System.Windows.Forms.ToolStripButton tb_LeftAlign;
        private System.Windows.Forms.ToolStripButton tb_CenterAlign;
        private System.Windows.Forms.ToolStripButton tb_RightAlign;
        private System.Windows.Forms.ToolStripButton tb_TextUp;
        private System.Windows.Forms.ToolStripButton tb_TextDown;
        private System.Windows.Forms.ToolStripButton tb_ZoomIn;
        private System.Windows.Forms.ToolStripButton tb_ZoomOut;
        private System.Windows.Forms.ToolStripComboBox tb_Font;
        private System.Windows.Forms.ToolStripComboBox tb_FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}

