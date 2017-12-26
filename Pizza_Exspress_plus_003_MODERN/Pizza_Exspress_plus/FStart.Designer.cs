namespace Pizza_Exspress_plus
{
    partial class FStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStart));
            this.panelB = new System.Windows.Forms.Panel();
            this.promocjeW = new System.Windows.Forms.Button();
            this.noweZamW = new System.Windows.Forms.Button();
            this.pizzaW = new System.Windows.Forms.Label();
            this.panelG = new System.Windows.Forms.Panel();
            this.zamknijO = new System.Windows.Forms.Button();
            this.minimalizujO = new System.Windows.Forms.Button();
            this.powienkszPomniejszO = new System.Windows.Forms.Button();
            this.panelOken = new System.Windows.Forms.Panel();
            this.pizzaEksW = new System.Windows.Forms.Label();
            this.PizzaNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.peZakrycieFstrart1 = new Pizza_Exspress_plus.PEZakrycieFstrart();
            this.zamowienie = new Pizza_Exspress_plus.PEZamowienie();
            this.promocje = new Pizza_Exspress_plus.PEPromoje();
            this.PizzaContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zamknąćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zminimalizujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.powiekszLubPomiejszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelB.SuspendLayout();
            this.panelG.SuspendLayout();
            this.panelOken.SuspendLayout();
            this.PizzaContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelB.Controls.Add(this.promocjeW);
            this.panelB.Controls.Add(this.noweZamW);
            this.panelB.Controls.Add(this.pizzaW);
            this.panelB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelB.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelB.Location = new System.Drawing.Point(0, 0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(209, 500);
            this.panelB.TabIndex = 3;
            // 
            // promocjeW
            // 
            this.promocjeW.AutoSize = true;
            this.promocjeW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.promocjeW.FlatAppearance.BorderSize = 0;
            this.promocjeW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promocjeW.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promocjeW.Image = ((System.Drawing.Image)(resources.GetObject("promocjeW.Image")));
            this.promocjeW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.promocjeW.Location = new System.Drawing.Point(9, 148);
            this.promocjeW.Name = "promocjeW";
            this.promocjeW.Size = new System.Drawing.Size(200, 71);
            this.promocjeW.TabIndex = 16;
            this.promocjeW.Text = "     PROMOCJE";
            this.promocjeW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.promocjeW.UseVisualStyleBackColor = true;
            this.promocjeW.Click += new System.EventHandler(this.wyswietlPeomocje);
            // 
            // noweZamW
            // 
            this.noweZamW.AutoSize = true;
            this.noweZamW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noweZamW.FlatAppearance.BorderSize = 0;
            this.noweZamW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noweZamW.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noweZamW.Image = ((System.Drawing.Image)(resources.GetObject("noweZamW.Image")));
            this.noweZamW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noweZamW.Location = new System.Drawing.Point(3, 68);
            this.noweZamW.Name = "noweZamW";
            this.noweZamW.Size = new System.Drawing.Size(200, 71);
            this.noweZamW.TabIndex = 15;
            this.noweZamW.Text = "  NOWE ZAMÓWIENIE";
            this.noweZamW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.noweZamW.UseVisualStyleBackColor = true;
            this.noweZamW.Click += new System.EventHandler(this.noweZamowienie);
            // 
            // pizzaW
            // 
            this.pizzaW.AutoSize = true;
            this.pizzaW.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaW.ForeColor = System.Drawing.Color.Red;
            this.pizzaW.Location = new System.Drawing.Point(12, 14);
            this.pizzaW.Name = "pizzaW";
            this.pizzaW.Size = new System.Drawing.Size(181, 24);
            this.pizzaW.TabIndex = 14;
            this.pizzaW.Text = "PIZZA express +";
            // 
            // panelG
            // 
            this.panelG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelG.Controls.Add(this.zamknijO);
            this.panelG.Controls.Add(this.minimalizujO);
            this.panelG.Controls.Add(this.powienkszPomniejszO);
            this.panelG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG.Location = new System.Drawing.Point(209, 0);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(426, 62);
            this.panelG.TabIndex = 4;
            this.panelG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.przesunD);
            this.panelG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.przesunM);
            // 
            // zamknijO
            // 
            this.zamknijO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijO.AutoSize = true;
            this.zamknijO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijO.FlatAppearance.BorderSize = 0;
            this.zamknijO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijO.Image = ((System.Drawing.Image)(resources.GetObject("zamknijO.Image")));
            this.zamknijO.Location = new System.Drawing.Point(378, 10);
            this.zamknijO.Name = "zamknijO";
            this.zamknijO.Size = new System.Drawing.Size(42, 42);
            this.zamknijO.TabIndex = 9;
            this.zamknijO.UseVisualStyleBackColor = true;
            this.zamknijO.Click += new System.EventHandler(this.zamknij);
            // 
            // minimalizujO
            // 
            this.minimalizujO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalizujO.AutoSize = true;
            this.minimalizujO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimalizujO.FlatAppearance.BorderSize = 0;
            this.minimalizujO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizujO.Image = ((System.Drawing.Image)(resources.GetObject("minimalizujO.Image")));
            this.minimalizujO.Location = new System.Drawing.Point(286, 10);
            this.minimalizujO.Name = "minimalizujO";
            this.minimalizujO.Size = new System.Drawing.Size(38, 41);
            this.minimalizujO.TabIndex = 10;
            this.minimalizujO.UseVisualStyleBackColor = true;
            this.minimalizujO.Click += new System.EventHandler(this.zminimalizuj);
            // 
            // powienkszPomniejszO
            // 
            this.powienkszPomniejszO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powienkszPomniejszO.AutoSize = true;
            this.powienkszPomniejszO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powienkszPomniejszO.FlatAppearance.BorderSize = 0;
            this.powienkszPomniejszO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powienkszPomniejszO.Image = ((System.Drawing.Image)(resources.GetObject("powienkszPomniejszO.Image")));
            this.powienkszPomniejszO.Location = new System.Drawing.Point(330, 10);
            this.powienkszPomniejszO.Name = "powienkszPomniejszO";
            this.powienkszPomniejszO.Size = new System.Drawing.Size(42, 42);
            this.powienkszPomniejszO.TabIndex = 13;
            this.powienkszPomniejszO.UseVisualStyleBackColor = true;
            this.powienkszPomniejszO.Click += new System.EventHandler(this.powiekszPomiejsz);
            // 
            // panelOken
            // 
            this.panelOken.Controls.Add(this.pizzaEksW);
            this.panelOken.Controls.Add(this.peZakrycieFstrart1);
            this.panelOken.Controls.Add(this.zamowienie);
            this.panelOken.Controls.Add(this.promocje);
            this.panelOken.Location = new System.Drawing.Point(212, 68);
            this.panelOken.Name = "panelOken";
            this.panelOken.Size = new System.Drawing.Size(420, 417);
            this.panelOken.TabIndex = 5;
            // 
            // pizzaEksW
            // 
            this.pizzaEksW.AutoSize = true;
            this.pizzaEksW.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaEksW.ForeColor = System.Drawing.Color.Red;
            this.pizzaEksW.Location = new System.Drawing.Point(15, 32);
            this.pizzaEksW.Name = "pizzaEksW";
            this.pizzaEksW.Size = new System.Drawing.Size(322, 42);
            this.pizzaEksW.TabIndex = 17;
            this.pizzaEksW.Text = "PIZZA express +";
            // 
            // PizzaNotifyIcon
            // 
            this.PizzaNotifyIcon.ContextMenuStrip = this.PizzaContextMenuStrip;
            this.PizzaNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("PizzaNotifyIcon.Icon")));
            this.PizzaNotifyIcon.Text = "PIZZA express +";
            this.PizzaNotifyIcon.Visible = true;
            this.PizzaNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.normaRozm);
            // 
            // peZakrycieFstrart1
            // 
            this.peZakrycieFstrart1.Location = new System.Drawing.Point(1, 3);
            this.peZakrycieFstrart1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.peZakrycieFstrart1.Name = "peZakrycieFstrart1";
            this.peZakrycieFstrart1.Size = new System.Drawing.Size(732, 480);
            this.peZakrycieFstrart1.TabIndex = 2;
            // 
            // zamowienie
            // 
            this.zamowienie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zamowienie.Location = new System.Drawing.Point(7, 3);
            this.zamowienie.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.zamowienie.Name = "zamowienie";
            this.zamowienie.Size = new System.Drawing.Size(615, 348);
            this.zamowienie.TabIndex = 1;
            // 
            // promocje
            // 
            this.promocje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promocje.Enabled = false;
            this.promocje.Location = new System.Drawing.Point(7, 3);
            this.promocje.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.promocje.Name = "promocje";
            this.promocje.Size = new System.Drawing.Size(644, 348);
            this.promocje.TabIndex = 0;
            // 
            // PizzaContextMenuStrip
            // 
            this.PizzaContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknąćToolStripMenuItem,
            this.zminimalizujToolStripMenuItem1,
            this.powiekszLubPomiejszToolStripMenuItem});
            this.PizzaContextMenuStrip.Name = "contextMenuStrip1";
            this.PizzaContextMenuStrip.Size = new System.Drawing.Size(193, 70);
            // 
            // zamknąćToolStripMenuItem
            // 
            this.zamknąćToolStripMenuItem.Name = "zamknąćToolStripMenuItem";
            this.zamknąćToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.zamknąćToolStripMenuItem.Text = "Zamknąć";
            this.zamknąćToolStripMenuItem.Click += new System.EventHandler(this.zamknij);
            // 
            // zminimalizujToolStripMenuItem1
            // 
            this.zminimalizujToolStripMenuItem1.Name = "zminimalizujToolStripMenuItem1";
            this.zminimalizujToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.zminimalizujToolStripMenuItem1.Text = "Zminimalizuj";
            this.zminimalizujToolStripMenuItem1.Click += new System.EventHandler(this.zminimalizuj);
            // 
            // powiekszLubPomiejszToolStripMenuItem
            // 
            this.powiekszLubPomiejszToolStripMenuItem.Name = "powiekszLubPomiejszToolStripMenuItem";
            this.powiekszLubPomiejszToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.powiekszLubPomiejszToolStripMenuItem.Text = "Powieksz lub pomiejsz";
            this.powiekszLubPomiejszToolStripMenuItem.Click += new System.EventHandler(this.powiekszPomiejsz);
            // 
            // FStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.panelOken);
            this.Controls.Add(this.panelG);
            this.Controls.Add(this.panelB);
            this.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelG.ResumeLayout(false);
            this.panelG.PerformLayout();
            this.panelOken.ResumeLayout(false);
            this.panelOken.PerformLayout();
            this.PizzaContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Button zamknijO;
        private System.Windows.Forms.Button minimalizujO;
        private System.Windows.Forms.Button powienkszPomniejszO;
        private System.Windows.Forms.Label pizzaW;
        private System.Windows.Forms.Button promocjeW;
        private System.Windows.Forms.Button noweZamW;
        private System.Windows.Forms.Panel panelOken;
        private System.Windows.Forms.Label pizzaEksW;
        private PEZakrycieFstrart peZakrycieFstrart1;
        private PEZamowienie zamowienie;
        private PEPromoje promocje;
        private System.Windows.Forms.NotifyIcon PizzaNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip PizzaContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem zamknąćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zminimalizujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem powiekszLubPomiejszToolStripMenuItem;
    }
}

