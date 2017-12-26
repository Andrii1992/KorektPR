namespace Pizza_Exspress_plus
{
    partial class PEPodsumowanieReszta
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.podsumT = new System.Windows.Forms.Label();
            this.gotowka = new System.Windows.Forms.TextBox();
            this.reszta = new System.Windows.Forms.Label();
            this.drukujPar = new System.Windows.Forms.Button();
            this.resztaP = new System.Windows.Forms.Button();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // podsumT
            // 
            this.podsumT.AutoSize = true;
            this.podsumT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.podsumT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podsumT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.podsumT.Location = new System.Drawing.Point(80, 4);
            this.podsumT.Name = "podsumT";
            this.podsumT.Size = new System.Drawing.Size(66, 16);
            this.podsumT.TabIndex = 0;
            this.podsumT.Text = "Podsuma";
            this.infoTip.SetToolTip(this.podsumT, "Ile do zapłaty");
            // 
            // gotowka
            // 
            this.gotowka.Location = new System.Drawing.Point(3, 21);
            this.gotowka.Name = "gotowka";
            this.gotowka.Size = new System.Drawing.Size(69, 20);
            this.gotowka.TabIndex = 1;
            this.infoTip.SetToolTip(this.gotowka, "Wprowadzenie otrzymanej gotówki od klienta");
            this.gotowka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.obliczReszteEntrerem);
            // 
            // reszta
            // 
            this.reszta.AutoSize = true;
            this.reszta.BackColor = System.Drawing.Color.DarkRed;
            this.reszta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reszta.ForeColor = System.Drawing.Color.White;
            this.reszta.Location = new System.Drawing.Point(3, 2);
            this.reszta.Name = "reszta";
            this.reszta.Size = new System.Drawing.Size(50, 16);
            this.reszta.TabIndex = 2;
            this.reszta.Text = "Reszta";
            this.infoTip.SetToolTip(this.reszta, "Wynnik reszty");
            // 
            // drukujPar
            // 
            this.drukujPar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.drukujPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.drukujPar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drukujPar.CausesValidation = false;
            this.drukujPar.FlatAppearance.BorderSize = 0;
            this.drukujPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drukujPar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.drukujPar.Location = new System.Drawing.Point(81, 34);
            this.drukujPar.Name = "drukujPar";
            this.drukujPar.Size = new System.Drawing.Size(68, 38);
            this.drukujPar.TabIndex = 12;
            this.drukujPar.Text = "DRUKUJ PARAGON";
            this.drukujPar.UseVisualStyleBackColor = false;
            this.drukujPar.Click += new System.EventHandler(this.drukujParagon);
            // 
            // resztaP
            // 
            this.resztaP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.resztaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.resztaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resztaP.CausesValidation = false;
            this.resztaP.FlatAppearance.BorderSize = 0;
            this.resztaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resztaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resztaP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resztaP.Location = new System.Drawing.Point(3, 46);
            this.resztaP.Name = "resztaP";
            this.resztaP.Size = new System.Drawing.Size(68, 22);
            this.resztaP.TabIndex = 13;
            this.resztaP.Text = "OK";
            this.infoTip.SetToolTip(this.resztaP, "Obliczanie reszty");
            this.resztaP.UseVisualStyleBackColor = false;
            this.resztaP.Click += new System.EventHandler(this.obliczReszte);
            // 
            // PEPodsumowanieReszta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resztaP);
            this.Controls.Add(this.drukujPar);
            this.Controls.Add(this.reszta);
            this.Controls.Add(this.gotowka);
            this.Controls.Add(this.podsumT);
            this.Name = "PEPodsumowanieReszta";
            this.Size = new System.Drawing.Size(152, 75);
            this.Click += new System.EventHandler(this.odswiez);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gotowkaPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gotowka;
        private System.Windows.Forms.Label reszta;
        private System.Windows.Forms.Button drukujPar;
        private System.Windows.Forms.Button resztaP;
        private System.Windows.Forms.ToolTip infoTip;
        private System.Windows.Forms.Label podsumT;
    }
}
