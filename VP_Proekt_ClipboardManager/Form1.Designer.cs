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
            this.stripMenuReadClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetItems = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbStrngs = new System.Windows.Forms.ListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblStrings = new System.Windows.Forms.Label();
            this.btnSetText = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyTryIcon
            // 
            this.notifyTryIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyTryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTryIcon.Icon")));
            this.notifyTryIcon.Text = "notifyIcon1";
            this.notifyTryIcon.Visible = true;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuTitleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuTitleToolStripMenuItem
            // 
            this.stripMenuTitleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuReadClipboard,
            this.stripMenuPaste});
            this.stripMenuTitleToolStripMenuItem.Name = "stripMenuTitleToolStripMenuItem";
            this.stripMenuTitleToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.stripMenuTitleToolStripMenuItem.Text = "StripMenuTitle";
            // 
            // stripMenuReadClipboard
            // 
            this.stripMenuReadClipboard.Name = "stripMenuReadClipboard";
            this.stripMenuReadClipboard.Size = new System.Drawing.Size(184, 22);
            this.stripMenuReadClipboard.Text = "readClipboard";
            this.stripMenuReadClipboard.Click += new System.EventHandler(this.stripMenuReadClipboard_Click);
            // 
            // stripMenuPaste
            // 
            this.stripMenuPaste.Name = "stripMenuPaste";
            this.stripMenuPaste.Size = new System.Drawing.Size(184, 22);
            this.stripMenuPaste.Text = "Paste from clipboard";
            this.stripMenuPaste.Click += new System.EventHandler(this.stripMenuPaste_Click);
            // 
            // btnSetItems
            // 
            this.btnSetItems.Location = new System.Drawing.Point(317, 91);
            this.btnSetItems.Name = "btnSetItems";
            this.btnSetItems.Size = new System.Drawing.Size(115, 23);
            this.btnSetItems.TabIndex = 6;
            this.btnSetItems.Text = "Set copied items";
            this.btnSetItems.UseVisualStyleBackColor = true;
            this.btnSetItems.Click += new System.EventHandler(this.btnSetItems_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(317, 55);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(115, 23);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get copied items ";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(9, 55);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(148, 368);
            this.lbItems.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(317, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbStrngs
            // 
            this.lbStrngs.FormattingEnabled = true;
            this.lbStrngs.Location = new System.Drawing.Point(163, 55);
            this.lbStrngs.Name = "lbStrngs";
            this.lbStrngs.Size = new System.Drawing.Size(148, 368);
            this.lbStrngs.TabIndex = 10;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(6, 32);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(68, 13);
            this.lblItems.TabIndex = 11;
            this.lblItems.Text = "Copied Items";
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
            // btnSetText
            // 
            this.btnSetText.Location = new System.Drawing.Point(317, 120);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(115, 23);
            this.btnSetText.TabIndex = 13;
            this.btnSetText.Text = "Set copied text\r\n";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 435);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnSetText);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lbStrngs);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSetItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem stripMenuReadClipboard;
        private System.Windows.Forms.ToolStripMenuItem stripMenuPaste;
        private System.Windows.Forms.Button btnSetItems;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbStrngs;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.Button btnSetText;
    }
}

