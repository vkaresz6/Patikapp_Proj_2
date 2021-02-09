using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    partial class MainWindow : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patikákKezeléseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartozásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patikánakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betegnekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tennivalókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tartozásokToolStripMenuItem,
            this.eszközökToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(981, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.exitToolStripMenuItem,
            this.patikákKezeléseToolStripMenuItem1,
            this.felhasználókKezeléseToolStripMenuItem,
            this.kijelentkezésToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // patikákKezeléseToolStripMenuItem1
            // 
            this.patikákKezeléseToolStripMenuItem1.Name = "patikákKezeléseToolStripMenuItem1";
            this.patikákKezeléseToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.patikákKezeléseToolStripMenuItem1.Text = "Patikák kezelése";
            this.patikákKezeléseToolStripMenuItem1.Click += new System.EventHandler(this.patikákKezeléseToolStripMenuItem1_Click);
            // 
            // felhasználókKezeléseToolStripMenuItem
            // 
            this.felhasználókKezeléseToolStripMenuItem.Name = "felhasználókKezeléseToolStripMenuItem";
            this.felhasználókKezeléseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.felhasználókKezeléseToolStripMenuItem.Text = "Felhasználók kezelése";
            this.felhasználókKezeléseToolStripMenuItem.Click += new System.EventHandler(this.felhasználókKezeléseToolStripMenuItem_Click);
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            // 
            // tartozásokToolStripMenuItem
            // 
            this.tartozásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patikánakToolStripMenuItem,
            this.betegnekToolStripMenuItem});
            this.tartozásokToolStripMenuItem.Name = "tartozásokToolStripMenuItem";
            this.tartozásokToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.tartozásokToolStripMenuItem.Text = "Tartozások";
            // 
            // patikánakToolStripMenuItem
            // 
            this.patikánakToolStripMenuItem.Name = "patikánakToolStripMenuItem";
            this.patikánakToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.patikánakToolStripMenuItem.Text = "Patikának";
            this.patikánakToolStripMenuItem.Click += new System.EventHandler(this.patikánakToolStripMenuItem_Click);
            // 
            // betegnekToolStripMenuItem
            // 
            this.betegnekToolStripMenuItem.Name = "betegnekToolStripMenuItem";
            this.betegnekToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.betegnekToolStripMenuItem.Text = "Betegnek";
            this.betegnekToolStripMenuItem.Click += new System.EventHandler(this.betegnekToolStripMenuItem_Click);
            // 
            // eszközökToolStripMenuItem
            // 
            this.eszközökToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tennivalókToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.eszközökToolStripMenuItem.Name = "eszközökToolStripMenuItem";
            this.eszközökToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.eszközökToolStripMenuItem.Text = "Eszközök";
            // 
            // tennivalókToolStripMenuItem
            // 
            this.tennivalókToolStripMenuItem.Name = "tennivalókToolStripMenuItem";
            this.tennivalókToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tennivalókToolStripMenuItem.Text = "Tennivalók";
            this.tennivalókToolStripMenuItem.Click += new System.EventHandler(this.tennivalókToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 564);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "PatikApp";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem tartozásokToolStripMenuItem;
        private ToolStripMenuItem patikánakToolStripMenuItem;
        private ToolStripMenuItem betegnekToolStripMenuItem;
        private ToolStripMenuItem eszközökToolStripMenuItem;
        private ToolStripMenuItem tennivalókToolStripMenuItem;
        private ToolStripMenuItem chatToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private ToolStripMenuItem patikákKezeléseToolStripMenuItem1;
        private ToolStripMenuItem felhasználókKezeléseToolStripMenuItem;
        private ToolStripMenuItem kijelentkezésToolStripMenuItem;
    }
}



