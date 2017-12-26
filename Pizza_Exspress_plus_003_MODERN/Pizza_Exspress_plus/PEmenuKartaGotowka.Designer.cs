namespace Pizza_Exspress_plus
{
    partial class PEmenuKartaGotowka
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
            this.kartaRB = new System.Windows.Forms.RadioButton();
            this.gotowkaRB = new System.Windows.Forms.RadioButton();
            this.formaPlatnosciW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kartaRB
            // 
            this.kartaRB.AutoSize = true;
            this.kartaRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kartaRB.ForeColor = System.Drawing.Color.Black;
            this.kartaRB.Location = new System.Drawing.Point(4, 42);
            this.kartaRB.Name = "kartaRB";
            this.kartaRB.Size = new System.Drawing.Size(50, 17);
            this.kartaRB.TabIndex = 46;
            this.kartaRB.TabStop = true;
            this.kartaRB.Text = "Karta";
            this.kartaRB.UseVisualStyleBackColor = false;
            this.kartaRB.Click += new System.EventHandler(this.kartaZmien);
            // 
            // gotowkaRB
            // 
            this.gotowkaRB.AutoSize = true;
            this.gotowkaRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gotowkaRB.ForeColor = System.Drawing.Color.Black;
            this.gotowkaRB.Location = new System.Drawing.Point(4, 19);
            this.gotowkaRB.Name = "gotowkaRB";
            this.gotowkaRB.Size = new System.Drawing.Size(68, 17);
            this.gotowkaRB.TabIndex = 45;
            this.gotowkaRB.TabStop = true;
            this.gotowkaRB.Text = "Gotówka";
            this.gotowkaRB.UseVisualStyleBackColor = false;
            this.gotowkaRB.Click += new System.EventHandler(this.gotowkaZmien);
            // 
            // formaPlatnosciW
            // 
            this.formaPlatnosciW.AutoSize = true;
            this.formaPlatnosciW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.formaPlatnosciW.ForeColor = System.Drawing.Color.Black;
            this.formaPlatnosciW.Location = new System.Drawing.Point(2, 3);
            this.formaPlatnosciW.Name = "formaPlatnosciW";
            this.formaPlatnosciW.Size = new System.Drawing.Size(83, 13);
            this.formaPlatnosciW.TabIndex = 47;
            this.formaPlatnosciW.Text = "Forma płatności";
            // 
            // PEmenuKartaGotowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formaPlatnosciW);
            this.Controls.Add(this.kartaRB);
            this.Controls.Add(this.gotowkaRB);
            this.Name = "PEmenuKartaGotowka";
            this.Size = new System.Drawing.Size(87, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton kartaRB;
        private System.Windows.Forms.RadioButton gotowkaRB;
        private System.Windows.Forms.Label formaPlatnosciW;
    }
}
