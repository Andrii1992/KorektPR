namespace Pizza_Exspress_plus
{
    partial class PEPromoje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEPromoje));
            this.label6 = new System.Windows.Forms.Label();
            this.pizaaR = new System.Windows.Forms.PictureBox();
            this.nazwaPizza = new System.Windows.Forms.PictureBox();
            this.nazwaRimini = new System.Windows.Forms.PictureBox();
            this.cena1399 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pizaaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwaPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwaRimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena1399)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dzisiejsza promocja";
            // 
            // pizaaR
            // 
            this.pizaaR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pizaaR.Image = ((System.Drawing.Image)(resources.GetObject("pizaaR.Image")));
            this.pizaaR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pizaaR.Location = new System.Drawing.Point(3, 3);
            this.pizaaR.Name = "pizaaR";
            this.pizaaR.Size = new System.Drawing.Size(278, 184);
            this.pizaaR.TabIndex = 7;
            this.pizaaR.TabStop = false;
            // 
            // nazwaPizza
            // 
            this.nazwaPizza.Image = ((System.Drawing.Image)(resources.GetObject("nazwaPizza.Image")));
            this.nazwaPizza.Location = new System.Drawing.Point(3, 175);
            this.nazwaPizza.Name = "nazwaPizza";
            this.nazwaPizza.Size = new System.Drawing.Size(74, 33);
            this.nazwaPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nazwaPizza.TabIndex = 13;
            this.nazwaPizza.TabStop = false;
            // 
            // nazwaRimini
            // 
            this.nazwaRimini.Image = ((System.Drawing.Image)(resources.GetObject("nazwaRimini.Image")));
            this.nazwaRimini.Location = new System.Drawing.Point(3, 214);
            this.nazwaRimini.Name = "nazwaRimini";
            this.nazwaRimini.Size = new System.Drawing.Size(100, 37);
            this.nazwaRimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nazwaRimini.TabIndex = 14;
            this.nazwaRimini.TabStop = false;
            // 
            // cena1399
            // 
            this.cena1399.Image = ((System.Drawing.Image)(resources.GetObject("cena1399.Image")));
            this.cena1399.Location = new System.Drawing.Point(109, 175);
            this.cena1399.Name = "cena1399";
            this.cena1399.Size = new System.Drawing.Size(142, 88);
            this.cena1399.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cena1399.TabIndex = 15;
            this.cena1399.TabStop = false;
            // 
            // PEPromoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.nazwaRimini);
            this.Controls.Add(this.nazwaPizza);
            this.Controls.Add(this.cena1399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pizaaR);
            this.Enabled = false;
            this.Name = "PEPromoje";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pizaaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwaPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwaRimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena1399)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pizaaR;
        private System.Windows.Forms.PictureBox nazwaPizza;
        private System.Windows.Forms.PictureBox nazwaRimini;
        private System.Windows.Forms.PictureBox cena1399;
    }
}
