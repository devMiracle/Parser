namespace ParserApp
{
    partial class Form1
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
            this.buttonParse = new System.Windows.Forms.Button();
            this.listBoxParse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(12, 12);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(303, 23);
            this.buttonParse.TabIndex = 0;
            this.buttonParse.Text = "parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            // 
            // listBoxParse
            // 
            this.listBoxParse.FormattingEnabled = true;
            this.listBoxParse.Location = new System.Drawing.Point(12, 41);
            this.listBoxParse.Name = "listBoxParse";
            this.listBoxParse.Size = new System.Drawing.Size(303, 342);
            this.listBoxParse.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 398);
            this.Controls.Add(this.listBoxParse);
            this.Controls.Add(this.buttonParse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.ListBox listBoxParse;
    }
}

