namespace Pizza_Exspress_plus
{
    partial class PEZamowienie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEZamowienie));
            this.lokal = new System.Windows.Forms.Button();
            this.odebrac = new System.Windows.Forms.Button();
            this.dostawa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lokal
            // 
            resources.ApplyResources(this.lokal, "lokal");
            this.lokal.BackColor = System.Drawing.Color.DarkRed;
            this.lokal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.lokal.FlatAppearance.BorderSize = 0;
            this.lokal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lokal.Name = "lokal";
            this.lokal.UseVisualStyleBackColor = false;
            this.lokal.Click += new System.EventHandler(this.lokalOtwoz);
            // 
            // odebrac
            // 
            resources.ApplyResources(this.odebrac, "odebrac");
            this.odebrac.BackColor = System.Drawing.Color.DarkRed;
            this.odebrac.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.odebrac.FlatAppearance.BorderSize = 0;
            this.odebrac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odebrac.Name = "odebrac";
            this.odebrac.UseVisualStyleBackColor = false;
            this.odebrac.Click += new System.EventHandler(this.odebracOtwoz);
            // 
            // dostawa
            // 
            resources.ApplyResources(this.dostawa, "dostawa");
            this.dostawa.BackColor = System.Drawing.Color.DarkRed;
            this.dostawa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dostawa.FlatAppearance.BorderSize = 0;
            this.dostawa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dostawa.Name = "dostawa";
            this.dostawa.UseVisualStyleBackColor = false;
            this.dostawa.Click += new System.EventHandler(this.dostawaOtwoz);
            // 
            // PEZamowienie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dostawa);
            this.Controls.Add(this.odebrac);
            this.Controls.Add(this.lokal);
            this.Name = "PEZamowienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lokal;
        private System.Windows.Forms.Button odebrac;
        private System.Windows.Forms.Button dostawa;
    }
}
