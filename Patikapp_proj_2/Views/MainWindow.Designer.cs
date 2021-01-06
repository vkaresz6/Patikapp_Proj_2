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
            this.patikákKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartozásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patikánakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betegnekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartozásokTallózásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tartozásokToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(981, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.patikákKezeléseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // patikákKezeléseToolStripMenuItem
            // 
            this.patikákKezeléseToolStripMenuItem.Name = "patikákKezeléseToolStripMenuItem";
            this.patikákKezeléseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.patikákKezeléseToolStripMenuItem.Text = "Patikák kezelése";
            this.patikákKezeléseToolStripMenuItem.Click += new System.EventHandler(this.patikákKezeléseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // tartozásokToolStripMenuItem
            // 
            this.tartozásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patikánakToolStripMenuItem,
            this.betegnekToolStripMenuItem,
            this.tartozásokTallózásaToolStripMenuItem});
            this.tartozásokToolStripMenuItem.Name = "tartozásokToolStripMenuItem";
            this.tartozásokToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.tartozásokToolStripMenuItem.Text = "Tartozások";
            // 
            // patikánakToolStripMenuItem
            // 
            this.patikánakToolStripMenuItem.Name = "patikánakToolStripMenuItem";
            this.patikánakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.patikánakToolStripMenuItem.Text = "Patikának";
            this.patikánakToolStripMenuItem.Click += new System.EventHandler(this.patikánakToolStripMenuItem_Click);
            // 
            // betegnekToolStripMenuItem
            // 
            this.betegnekToolStripMenuItem.Name = "betegnekToolStripMenuItem";
            this.betegnekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.betegnekToolStripMenuItem.Text = "Betegnek";
            this.betegnekToolStripMenuItem.Click += new System.EventHandler(this.betegnekToolStripMenuItem_Click);
            // 
            // tartozásokTallózásaToolStripMenuItem
            // 
            this.tartozásokTallózásaToolStripMenuItem.Name = "tartozásokTallózásaToolStripMenuItem";
            this.tartozásokTallózásaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tartozásokTallózásaToolStripMenuItem.Text = "Tartozások tallózása";
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
        private System.Windows.Forms.ToolStripMenuItem patikákKezeléseToolStripMenuItem;
        private ToolStripMenuItem tartozásokToolStripMenuItem;
        private ToolStripMenuItem patikánakToolStripMenuItem;
        private ToolStripMenuItem betegnekToolStripMenuItem;
        private ToolStripMenuItem tartozásokTallózásaToolStripMenuItem;
    }
}



