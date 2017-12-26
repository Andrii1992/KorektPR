namespace Pizza_Exspress_plus
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.panelB = new System.Windows.Forms.Panel();
            this.napoje = new System.Windows.Forms.Button();
            this.pizze = new System.Windows.Forms.Button();
            this.souse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pizzaW = new System.Windows.Forms.Label();
            this.panelG = new System.Windows.Forms.Panel();
            this.inF = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numerTelW = new System.Windows.Forms.Label();
            this.adresW = new System.Windows.Forms.Label();
            this.zamknijO = new System.Windows.Forms.Button();
            this.minimalizujO = new System.Windows.Forms.Button();
            this.powienkszPomniejszO = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.podsumowanie = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.ZakrycieKartaGMenuO = new Pizza_Exspress_plus.PEZakrycieKartaGMenu();
            this.zakrycie = new Pizza_Exspress_plus.PEZakrycieMenu();
            this.podKartaP = new Pizza_Exspress_plus.PEPodKarta();
            this.podsumowanieReszta = new Pizza_Exspress_plus.PEPodsumowanieReszta();
            this.menuKartaGotowkaO = new Pizza_Exspress_plus.PEmenuKartaGotowka();
            this.peLista = new Pizza_Exspress_plus.PELista();
            this.pizzE_P1 = new Pizza_Exspress_plus.PEPizze();
            this.napojE_P1 = new Pizza_Exspress_plus.PENnapoje();
            this.sousE_P1 = new Pizza_Exspress_plus.PESouse();
            this.panelB.SuspendLayout();
            this.panelG.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelB.Controls.Add(this.napoje);
            this.panelB.Controls.Add(this.pizze);
            this.panelB.Controls.Add(this.souse);
            this.panelB.Controls.Add(this.panel3);
            this.panelB.Controls.Add(this.pizzaW);
            this.panelB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelB.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelB.Location = new System.Drawing.Point(0, 0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(200, 500);
            this.panelB.TabIndex = 9;
            // 
            // napoje
            // 
            this.napoje.AutoSize = true;
            this.napoje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.napoje.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.napoje.FlatAppearance.BorderSize = 0;
            this.napoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.napoje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napoje.ForeColor = System.Drawing.SystemColors.Control;
            this.napoje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.napoje.Location = new System.Drawing.Point(0, 301);
            this.napoje.Name = "napoje";
            this.napoje.Size = new System.Drawing.Size(204, 108);
            this.napoje.TabIndex = 20;
            this.napoje.Text = "NAPOJE";
            this.napoje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.napoje.UseVisualStyleBackColor = false;
            this.napoje.Click += new System.EventHandler(this.dodajNapoje);
            // 
            // pizze
            // 
            this.pizze.AutoSize = true;
            this.pizze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pizze.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pizze.FlatAppearance.BorderSize = 0;
            this.pizze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pizze.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizze.ForeColor = System.Drawing.SystemColors.Control;
            this.pizze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pizze.Location = new System.Drawing.Point(0, 91);
            this.pizze.Name = "pizze";
            this.pizze.Size = new System.Drawing.Size(204, 108);
            this.pizze.TabIndex = 16;
            this.pizze.Text = "PIZZE";
            this.pizze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pizze.UseVisualStyleBackColor = false;
            this.pizze.Click += new System.EventHandler(this.dodajPizze);
            // 
            // souse
            // 
            this.souse.AutoSize = true;
            this.souse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.souse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.souse.FlatAppearance.BorderSize = 0;
            this.souse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.souse.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.souse.ForeColor = System.Drawing.SystemColors.Control;
            this.souse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.souse.Location = new System.Drawing.Point(0, 196);
            this.souse.Name = "souse";
            this.souse.Size = new System.Drawing.Size(204, 108);
            this.souse.TabIndex = 17;
            this.souse.Text = "SOUSE";
            this.souse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.souse.UseVisualStyleBackColor = false;
            this.souse.Click += new System.EventHandler(this.dodajSouse);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(204, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 336);
            this.panel3.TabIndex = 15;
            // 
            // pizzaW
            // 
            this.pizzaW.AutoSize = true;
            this.pizzaW.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaW.ForeColor = System.Drawing.Color.Red;
            this.pizzaW.Location = new System.Drawing.Point(12, 14);
            this.pizzaW.Name = "pizzaW";
            this.pizzaW.Size = new System.Drawing.Size(181, 24);
            this.pizzaW.TabIndex = 0;
            this.pizzaW.Text = "PIZZA express +";
            // 
            // panelG
            // 
            this.panelG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelG.Controls.Add(this.inF);
            this.panelG.Controls.Add(this.panel4);
            this.panelG.Controls.Add(this.numerTelW);
            this.panelG.Controls.Add(this.adresW);
            this.panelG.Controls.Add(this.zamknijO);
            this.panelG.Controls.Add(this.minimalizujO);
            this.panelG.Controls.Add(this.powienkszPomniejszO);
            this.panelG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG.Location = new System.Drawing.Point(200, 0);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(450, 62);
            this.panelG.TabIndex = 10;
            this.panelG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.przesunD);
            this.panelG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.przesunM);
            // 
            // inF
            // 
            this.inF.AutoSize = true;
            this.inF.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inF.Image = ((System.Drawing.Image)(resources.GetObject("inF.Image")));
            this.inF.Location = new System.Drawing.Point(281, 16);
            this.inF.Name = "inF";
            this.inF.Size = new System.Drawing.Size(24, 27);
            this.inF.TabIndex = 68;
            this.inF.Text = "  ";
            this.infoTip.SetToolTip(this.inF, resources.GetString("inF.ToolTip"));
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(235, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 333);
            this.panel4.TabIndex = 18;
            // 
            // numerTelW
            // 
            this.numerTelW.AutoSize = true;
            this.numerTelW.ForeColor = System.Drawing.Color.Red;
            this.numerTelW.Location = new System.Drawing.Point(7, 36);
            this.numerTelW.Name = "numerTelW";
            this.numerTelW.Size = new System.Drawing.Size(83, 13);
            this.numerTelW.TabIndex = 23;
            this.numerTelW.Text = "Numer Telefonu";
            this.infoTip.SetToolTip(this.numerTelW, "Numer telefonu");
            // 
            // adresW
            // 
            this.adresW.AutoSize = true;
            this.adresW.ForeColor = System.Drawing.Color.Red;
            this.adresW.Location = new System.Drawing.Point(6, 14);
            this.adresW.Name = "adresW";
            this.adresW.Size = new System.Drawing.Size(34, 13);
            this.adresW.TabIndex = 22;
            this.adresW.Text = "Adres";
            this.infoTip.SetToolTip(this.adresW, "Adres lub godzina dostawy");
            // 
            // zamknijO
            // 
            this.zamknijO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijO.AutoSize = true;
            this.zamknijO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijO.FlatAppearance.BorderSize = 0;
            this.zamknijO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijO.Image = ((System.Drawing.Image)(resources.GetObject("zamknijO.Image")));
            this.zamknijO.Location = new System.Drawing.Point(403, 10);
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
            this.minimalizujO.Location = new System.Drawing.Point(311, 10);
            this.minimalizujO.Name = "minimalizujO";
            this.minimalizujO.Size = new System.Drawing.Size(42, 42);
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
            this.powienkszPomniejszO.Location = new System.Drawing.Point(355, 10);
            this.powienkszPomniejszO.Name = "powienkszPomniejszO";
            this.powienkszPomniejszO.Size = new System.Drawing.Size(42, 42);
            this.powienkszPomniejszO.TabIndex = 13;
            this.powienkszPomniejszO.UseVisualStyleBackColor = true;
            this.powienkszPomniejszO.Click += new System.EventHandler(this.powiekszPomiejsz);
            // 
            // usun
            // 
            this.usun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usun.BackgroundImage")));
            this.usun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usun.FlatAppearance.BorderSize = 0;
            this.usun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usun.Location = new System.Drawing.Point(586, 404);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(35, 36);
            this.usun.TabIndex = 22;
            this.infoTip.SetToolTip(this.usun, "Usuwa towar z listy");
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usunDaneZListy);
            // 
            // podsumowanie
            // 
            this.podsumowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.podsumowanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.podsumowanie.FlatAppearance.BorderSize = 0;
            this.podsumowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podsumowanie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.podsumowanie.Location = new System.Drawing.Point(204, 442);
            this.podsumowanie.Name = "podsumowanie";
            this.podsumowanie.Size = new System.Drawing.Size(128, 43);
            this.podsumowanie.TabIndex = 24;
            this.podsumowanie.Text = "PODSUMOWANIE";
            this.infoTip.SetToolTip(this.podsumowanie, "Wylicza finalną cene\r\n");
            this.podsumowanie.UseVisualStyleBackColor = false;
            this.podsumowanie.Click += new System.EventHandler(this.podsumujZamowienie);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.zakrycie);
            this.panel5.Controls.Add(this.podKartaP);
            this.panel5.Controls.Add(this.podsumowanieReszta);
            this.panel5.Location = new System.Drawing.Point(338, 413);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 75);
            this.panel5.TabIndex = 25;
            // 
            // infoTip
            // 
            this.infoTip.AutoPopDelay = 20000;
            this.infoTip.InitialDelay = 500;
            this.infoTip.ReshowDelay = 100;
            // 
            // ZakrycieKartaGMenuO
            // 
            this.ZakrycieKartaGMenuO.Location = new System.Drawing.Point(493, 404);
            this.ZakrycieKartaGMenuO.Name = "ZakrycieKartaGMenuO";
            this.ZakrycieKartaGMenuO.Size = new System.Drawing.Size(87, 62);
            this.ZakrycieKartaGMenuO.TabIndex = 26;
            // 
            // zakrycie
            // 
            this.zakrycie.Location = new System.Drawing.Point(0, 0);
            this.zakrycie.Name = "zakrycie";
            this.zakrycie.Size = new System.Drawing.Size(149, 78);
            this.zakrycie.TabIndex = 28;
            // 
            // podKartaP
            // 
            this.podKartaP.Location = new System.Drawing.Point(0, 0);
            this.podKartaP.Name = "podKartaP";
            this.podKartaP.Size = new System.Drawing.Size(152, 75);
            this.podKartaP.TabIndex = 28;
            // 
            // podsumowanieReszta
            // 
            this.podsumowanieReszta.Location = new System.Drawing.Point(0, 0);
            this.podsumowanieReszta.Name = "podsumowanieReszta";
            this.podsumowanieReszta.Size = new System.Drawing.Size(152, 75);
            this.podsumowanieReszta.TabIndex = 28;
            // 
            // menuKartaGotowkaO
            // 
            this.menuKartaGotowkaO.Location = new System.Drawing.Point(493, 407);
            this.menuKartaGotowkaO.Name = "menuKartaGotowkaO";
            this.menuKartaGotowkaO.Size = new System.Drawing.Size(87, 62);
            this.menuKartaGotowkaO.TabIndex = 23;
            // 
            // peLista
            // 
            this.peLista.Location = new System.Drawing.Point(432, 63);
            this.peLista.Name = "peLista";
            this.peLista.Size = new System.Drawing.Size(194, 335);
            this.peLista.TabIndex = 21;
            this.infoTip.SetToolTip(this.peLista, "Lista towarów");
            // 
            // pizzE_P1
            // 
            this.pizzE_P1.Location = new System.Drawing.Point(206, 65);
            this.pizzE_P1.Name = "pizzE_P1";
            this.pizzE_P1.Size = new System.Drawing.Size(232, 336);
            this.pizzE_P1.TabIndex = 18;
            // 
            // napojE_P1
            // 
            this.napojE_P1.Location = new System.Drawing.Point(206, 65);
            this.napojE_P1.Name = "napojE_P1";
            this.napojE_P1.Size = new System.Drawing.Size(232, 336);
            this.napojE_P1.TabIndex = 20;
            // 
            // sousE_P1
            // 
            this.sousE_P1.Location = new System.Drawing.Point(206, 65);
            this.sousE_P1.Name = "sousE_P1";
            this.sousE_P1.Size = new System.Drawing.Size(232, 336);
            this.sousE_P1.TabIndex = 19;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.ZakrycieKartaGMenuO);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.podsumowanie);
            this.Controls.Add(this.menuKartaGotowkaO);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.peLista);
            this.Controls.Add(this.pizzE_P1);
            this.Controls.Add(this.panelG);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.napojE_P1);
            this.Controls.Add(this.sousE_P1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMenuD";
            this.Click += new System.EventHandler(this.klikMenu);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPaint);
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelG.ResumeLayout(false);
            this.panelG.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Button napoje;
        private System.Windows.Forms.Button pizze;
        private System.Windows.Forms.Button souse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pizzaW;
        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label numerTelW;
        private System.Windows.Forms.Label adresW;
        private System.Windows.Forms.Button zamknijO;
        private System.Windows.Forms.Button minimalizujO;
        private System.Windows.Forms.Button powienkszPomniejszO;
        private PEPizze pizzE_P1;
        private PESouse sousE_P1;
        private PENnapoje napojE_P1;
        private PELista peLista;
        private System.Windows.Forms.Button usun;
        private PEmenuKartaGotowka menuKartaGotowkaO;
        private System.Windows.Forms.Button podsumowanie;
        private System.Windows.Forms.Panel panel5;
        private PEZakrycieKartaGMenu ZakrycieKartaGMenuO;
        private PEZakrycieMenu zakrycie;
        private PEPodKarta podKartaP;
        private PEPodsumowanieReszta podsumowanieReszta;
        private System.Windows.Forms.ToolTip infoTip;
        private System.Windows.Forms.Label inF;
    }
}