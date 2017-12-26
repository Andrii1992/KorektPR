namespace Pizza_Exspress_plus
{
    partial class PELista
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
            this.listaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listaBox
            // 
            this.listaBox.FormattingEnabled = true;
            this.listaBox.Location = new System.Drawing.Point(3, 2);
            this.listaBox.Name = "listaBox";
            this.listaBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listaBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaBox.Size = new System.Drawing.Size(188, 329);
            this.listaBox.TabIndex = 0;
            this.listaBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.formatList);
            // 
            // PELista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listaBox);
            this.Name = "PELista";
            this.Size = new System.Drawing.Size(194, 335);
            this.Load += new System.EventHandler(this.listaZaladuj);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaBox;
    }
}
