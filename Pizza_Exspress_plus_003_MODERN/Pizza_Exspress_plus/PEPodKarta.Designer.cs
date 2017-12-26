namespace Pizza_Exspress_plus
{
    partial class PEPodKarta
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
            this.kartaP = new System.Windows.Forms.Label();
            this.drukujPar = new System.Windows.Forms.Button();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // kartaP
            // 
            this.kartaP.AutoSize = true;
            this.kartaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kartaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kartaP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kartaP.Location = new System.Drawing.Point(3, 11);
            this.kartaP.Name = "kartaP";
            this.kartaP.Size = new System.Drawing.Size(66, 16);
            this.kartaP.TabIndex = 0;
            this.kartaP.Text = "Podsuma";
            this.infoTip.SetToolTip(this.kartaP, "Ile do zapłaty");
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
            this.drukujPar.TabIndex = 13;
            this.drukujPar.Text = "DRUKUJ PARAGON";
            this.drukujPar.UseVisualStyleBackColor = false;
            this.drukujPar.Click += new System.EventHandler(this.drukujParagon);
            // 
            // PEPodKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drukujPar);
            this.Controls.Add(this.kartaP);
            this.Name = "PEPodKarta";
            this.Size = new System.Drawing.Size(152, 75);
            this.Click += new System.EventHandler(this.odswiez);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.kartaPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kartaP;
        private System.Windows.Forms.Button drukujPar;
        private System.Windows.Forms.ToolTip infoTip;
    }
}
