namespace VP_Proekt_ClipboardManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyTryIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenuTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lbStrngs = new System.Windows.Forms.ListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblStrings = new System.Windows.Forms.Label();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.checkBoxItems = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStoredItems = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPositionBotomRight = new System.Windows.Forms.RadioButton();
            this.rbPositionBotomLeft = new System.Windows.Forms.RadioButton();
            this.rbPositionTopRight = new System.Windows.Forms.RadioButton();
            this.rbPositionTopLeft = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSortFilesAndFoldersFirst = new System.Windows.Forms.RadioButton();
            this.rbSortTextFirst = new System.Windows.Forms.RadioButton();
            this.rbSortByCategory = new System.Windows.Forms.RadioButton();
            this.rbSortByTime = new System.Windows.Forms.RadioButton();
            this.checkBoxRememberOnClose = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoredItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyTryIcon
            // 
            this.notifyTryIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyTryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTryIcon.Icon")));
            this.notifyTryIcon.Text = "notifyIcon1";
            this.notifyTryIcon.Visible = true;
            this.notifyTryIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyTryIcon_MouseClick);
            this.notifyTryIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyTryIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 70);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuTitleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuTitleToolStripMenuItem
            // 
            this.stripMenuTitleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuClose,
            this.stripMenuClear});
            this.stripMenuTitleToolStripMenuItem.Name = "stripMenuTitleToolStripMenuItem";
            this.stripMenuTitleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.stripMenuTitleToolStripMenuItem.Text = "File";
            // 
            // stripMenuClose
            // 
            this.stripMenuClose.Name = "stripMenuClose";
            this.stripMenuClose.Size = new System.Drawing.Size(156, 22);
            this.stripMenuClose.Text = "Close";
            this.stripMenuClose.Click += new System.EventHandler(this.stripMenuReadClipboard_Click);
            // 
            // stripMenuClear
            // 
            this.stripMenuClear.Name = "stripMenuClear";
            this.stripMenuClear.Size = new System.Drawing.Size(156, 22);
            this.stripMenuClear.Text = "Clear Clipboard";
            this.stripMenuClear.Click += new System.EventHandler(this.stripMenuPaste_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(9, 48);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(148, 368);
            this.lbItems.TabIndex = 8;
            // 
            // lbStrngs
            // 
            this.lbStrngs.FormattingEnabled = true;
            this.lbStrngs.Location = new System.Drawing.Point(163, 48);
            this.lbStrngs.Name = "lbStrngs";
            this.lbStrngs.Size = new System.Drawing.Size(148, 368);
            this.lbStrngs.TabIndex = 10;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(6, 32);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(98, 13);
            this.lblItems.TabIndex = 11;
            this.lblItems.Text = "Copied Files/Folder";
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.Location = new System.Drawing.Point(160, 32);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(64, 13);
            this.lblStrings.TabIndex = 12;
            this.lblStrings.Text = "Copied Text";
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Checked = true;
            this.checkBoxText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxText.Location = new System.Drawing.Point(7, 19);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(47, 17);
            this.checkBoxText.TabIndex = 15;
            this.checkBoxText.Text = "Text";
            this.checkBoxText.UseVisualStyleBackColor = true;
            // 
            // checkBoxItems
            // 
            this.checkBoxItems.AutoSize = true;
            this.checkBoxItems.Checked = true;
            this.checkBoxItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItems.Location = new System.Drawing.Point(7, 42);
            this.checkBoxItems.Name = "checkBoxItems";
            this.checkBoxItems.Size = new System.Drawing.Size(105, 17);
            this.checkBoxItems.TabIndex = 16;
            this.checkBoxItems.Text = "Files and Folders";
            this.checkBoxItems.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxText);
            this.groupBox1.Controls.Add(this.checkBoxItems);
            this.groupBox1.Location = new System.Drawing.Point(324, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 67);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content to copy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "No. of elements in history";
            // 
            // nudStoredItems
            // 
            this.nudStoredItems.Location = new System.Drawing.Point(448, 193);
            this.nudStoredItems.Name = "nudStoredItems";
            this.nudStoredItems.Size = new System.Drawing.Size(116, 20);
            this.nudStoredItems.TabIndex = 21;
            this.nudStoredItems.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStoredItems.ValueChanged += new System.EventHandler(this.nudStoredItems_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPositionBotomRight);
            this.groupBox2.Controls.Add(this.rbPositionBotomLeft);
            this.groupBox2.Controls.Add(this.rbPositionTopRight);
            this.groupBox2.Controls.Add(this.rbPositionTopLeft);
            this.groupBox2.Location = new System.Drawing.Point(324, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 113);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChosePosition of ControlPanel";
            // 
            // rbPositionBotomRight
            // 
            this.rbPositionBotomRight.AutoSize = true;
            this.rbPositionBotomRight.Checked = true;
            this.rbPositionBotomRight.Location = new System.Drawing.Point(6, 88);
            this.rbPositionBotomRight.Name = "rbPositionBotomRight";
            this.rbPositionBotomRight.Size = new System.Drawing.Size(117, 17);
            this.rbPositionBotomRight.TabIndex = 3;
            this.rbPositionBotomRight.TabStop = true;
            this.rbPositionBotomRight.Text = "Botom Right Corner";
            this.rbPositionBotomRight.UseVisualStyleBackColor = true;
            this.rbPositionBotomRight.CheckedChanged += new System.EventHandler(this.rbPositionBotomRight_CheckedChanged);
            // 
            // rbPositionBotomLeft
            // 
            this.rbPositionBotomLeft.Location = new System.Drawing.Point(7, 65);
            this.rbPositionBotomLeft.Name = "rbPositionBotomLeft";
            this.rbPositionBotomLeft.Size = new System.Drawing.Size(85, 17);
            this.rbPositionBotomLeft.TabIndex = 2;
            this.rbPositionBotomLeft.Text = "Botom Left Corner";
            this.rbPositionBotomLeft.UseVisualStyleBackColor = true;
            this.rbPositionBotomLeft.CheckedChanged += new System.EventHandler(this.rbPositionBotomLeft_CheckedChanged);
            // 
            // rbPositionTopRight
            // 
            this.rbPositionTopRight.Location = new System.Drawing.Point(7, 43);
            this.rbPositionTopRight.Name = "rbPositionTopRight";
            this.rbPositionTopRight.Size = new System.Drawing.Size(85, 17);
            this.rbPositionTopRight.TabIndex = 1;
            this.rbPositionTopRight.Text = "Top Right Corner";
            this.rbPositionTopRight.UseVisualStyleBackColor = true;
            this.rbPositionTopRight.CheckedChanged += new System.EventHandler(this.rbPositionTopRight_CheckedChanged);
            // 
            // rbPositionTopLeft
            // 
            this.rbPositionTopLeft.AutoSize = true;
            this.rbPositionTopLeft.Location = new System.Drawing.Point(7, 20);
            this.rbPositionTopLeft.Name = "rbPositionTopLeft";
            this.rbPositionTopLeft.Size = new System.Drawing.Size(99, 17);
            this.rbPositionTopLeft.TabIndex = 0;
            this.rbPositionTopLeft.Text = "Top Left Corner";
            this.rbPositionTopLeft.UseVisualStyleBackColor = true;
            this.rbPositionTopLeft.CheckedChanged += new System.EventHandler(this.rbPositionTopLeft_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.rbSortByCategory);
            this.groupBox3.Controls.Add(this.rbSortByTime);
            this.groupBox3.Location = new System.Drawing.Point(324, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 135);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort Items";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSortFilesAndFoldersFirst);
            this.groupBox4.Controls.Add(this.rbSortTextFirst);
            this.groupBox4.Location = new System.Drawing.Point(23, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category Sort:";
            // 
            // rbSortFilesAndFoldersFirst
            // 
            this.rbSortFilesAndFoldersFirst.AutoSize = true;
            this.rbSortFilesAndFoldersFirst.Enabled = false;
            this.rbSortFilesAndFoldersFirst.Location = new System.Drawing.Point(7, 36);
            this.rbSortFilesAndFoldersFirst.Name = "rbSortFilesAndFoldersFirst";
            this.rbSortFilesAndFoldersFirst.Size = new System.Drawing.Size(173, 17);
            this.rbSortFilesAndFoldersFirst.TabIndex = 1;
            this.rbSortFilesAndFoldersFirst.TabStop = true;
            this.rbSortFilesAndFoldersFirst.Text = "First Files and Folders, then text";
            this.rbSortFilesAndFoldersFirst.UseVisualStyleBackColor = true;
            // 
            // rbSortTextFirst
            // 
            this.rbSortTextFirst.AutoSize = true;
            this.rbSortTextFirst.Enabled = false;
            this.rbSortTextFirst.Location = new System.Drawing.Point(7, 17);
            this.rbSortTextFirst.Name = "rbSortTextFirst";
            this.rbSortTextFirst.Size = new System.Drawing.Size(173, 17);
            this.rbSortTextFirst.TabIndex = 0;
            this.rbSortTextFirst.TabStop = true;
            this.rbSortTextFirst.Text = "First text, then Files and Folders";
            this.rbSortTextFirst.UseVisualStyleBackColor = true;
            // 
            // rbSortByCategory
            // 
            this.rbSortByCategory.AutoSize = true;
            this.rbSortByCategory.Location = new System.Drawing.Point(7, 42);
            this.rbSortByCategory.Name = "rbSortByCategory";
            this.rbSortByCategory.Size = new System.Drawing.Size(82, 17);
            this.rbSortByCategory.TabIndex = 1;
            this.rbSortByCategory.Text = "By Category";
            this.rbSortByCategory.UseVisualStyleBackColor = true;
            this.rbSortByCategory.CheckedChanged += new System.EventHandler(this.rbSortByCategory_CheckedChanged);
            // 
            // rbSortByTime
            // 
            this.rbSortByTime.AutoSize = true;
            this.rbSortByTime.Checked = true;
            this.rbSortByTime.Location = new System.Drawing.Point(7, 19);
            this.rbSortByTime.Name = "rbSortByTime";
            this.rbSortByTime.Size = new System.Drawing.Size(59, 17);
            this.rbSortByTime.TabIndex = 0;
            this.rbSortByTime.TabStop = true;
            this.rbSortByTime.Text = "By time";
            this.rbSortByTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberOnClose
            // 
            this.checkBoxRememberOnClose.AutoSize = true;
            this.checkBoxRememberOnClose.Location = new System.Drawing.Point(448, 219);
            this.checkBoxRememberOnClose.Name = "checkBoxRememberOnClose";
            this.checkBoxRememberOnClose.Size = new System.Drawing.Size(112, 17);
            this.checkBoxRememberOnClose.TabIndex = 24;
            this.checkBoxRememberOnClose.Text = "Remember History";
            this.checkBoxRememberOnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(236, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear All History";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 420);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkBoxRememberOnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nudStoredItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lbStrngs);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simple Clipboard Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoredItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyTryIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMenuClose;
        private System.Windows.Forms.ToolStripMenuItem stripMenuClear;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ListBox lbStrngs;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.CheckBox checkBoxItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStoredItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPositionBotomRight;
        private System.Windows.Forms.RadioButton rbPositionBotomLeft;
        private System.Windows.Forms.RadioButton rbPositionTopRight;
        private System.Windows.Forms.RadioButton rbPositionTopLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSortFilesAndFoldersFirst;
        private System.Windows.Forms.RadioButton rbSortTextFirst;
        private System.Windows.Forms.RadioButton rbSortByCategory;
        private System.Windows.Forms.RadioButton rbSortByTime;
        private System.Windows.Forms.CheckBox checkBoxRememberOnClose;
        private System.Windows.Forms.Button btnClear;
    }
}

