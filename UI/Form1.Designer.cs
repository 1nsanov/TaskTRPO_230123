namespace UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrasportationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuBus = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuSupervisor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrasportationMenu,
            this.ViewMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrasportationMenu
            // 
            this.TrasportationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.TrasportationMenu.Name = "TrasportationMenu";
            this.TrasportationMenu.Size = new System.Drawing.Size(77, 20);
            this.TrasportationMenu.Text = "Перевозка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMenuTicket,
            this.ViewMenuRoute,
            this.ViewMenuBus,
            this.ViewMenuDriver,
            this.ViewMenuSupervisor});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(76, 20);
            this.ViewMenu.Text = "Просмотр";
            // 
            // ViewMenuTicket
            // 
            this.ViewMenuTicket.Name = "ViewMenuTicket";
            this.ViewMenuTicket.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuTicket.Text = "Билеты";
            this.ViewMenuTicket.Click += new System.EventHandler(this.ViewMenuTicket_Click);
            // 
            // ViewMenuRoute
            // 
            this.ViewMenuRoute.Name = "ViewMenuRoute";
            this.ViewMenuRoute.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuRoute.Text = "Маршруты";
            // 
            // ViewMenuBus
            // 
            this.ViewMenuBus.Name = "ViewMenuBus";
            this.ViewMenuBus.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuBus.Text = "Автобусы";
            // 
            // ViewMenuDriver
            // 
            this.ViewMenuDriver.Name = "ViewMenuDriver";
            this.ViewMenuDriver.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuDriver.Text = "Водители";
            // 
            // ViewMenuSupervisor
            // 
            this.ViewMenuSupervisor.Name = "ViewMenuSupervisor";
            this.ViewMenuSupervisor.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuSupervisor.Text = "Диспетчеры";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(898, 586);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TrasportationMenu;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem ViewMenu;
        private ToolStripMenuItem ViewMenuTicket;
        private ToolStripMenuItem ViewMenuRoute;
        private ToolStripMenuItem ViewMenuBus;
        private ToolStripMenuItem ViewMenuDriver;
        private ToolStripMenuItem ViewMenuSupervisor;
    }
}