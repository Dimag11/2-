namespace Dmitri16
{
    partial class Work16
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображатьтекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображатьВводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.отображатьКнопкиУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видимостьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видимостьToolStripMenuItem
            // 
            this.видимостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отображатьтекстToolStripMenuItem,
            this.отображатьВводToolStripMenuItem,
            this.отображатьКнопкиУправленияToolStripMenuItem});
            this.видимостьToolStripMenuItem.Name = "видимостьToolStripMenuItem";
            this.видимостьToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.видимостьToolStripMenuItem.Text = "Видимость";
            this.видимостьToolStripMenuItem.Click += new System.EventHandler(this.видимостьToolStripMenuItem_Click);
            // 
            // отображатьтекстToolStripMenuItem
            // 
            this.отображатьтекстToolStripMenuItem.Name = "отображатьтекстToolStripMenuItem";
            this.отображатьтекстToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.отображатьтекстToolStripMenuItem.Text = "Отображать (текст)";
            this.отображатьтекстToolStripMenuItem.Click += new System.EventHandler(this.отображатьтекстToolStripMenuItem_Click);
            // 
            // отображатьВводToolStripMenuItem
            // 
            this.отображатьВводToolStripMenuItem.Name = "отображатьВводToolStripMenuItem";
            this.отображатьВводToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.отображатьВводToolStripMenuItem.Text = "Отображать (Ввод)";
            this.отображатьВводToolStripMenuItem.Click += new System.EventHandler(this.отображатьВводToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ВВОД ТЕКСТА";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(259, 182);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(249, 22);
            this.InputText.TabIndex = 5;
            this.InputText.Text = "Введите сообщение...";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(293, 256);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(203, 20);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Показать меню видимости";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(293, 282);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(187, 20);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Скрыть меню видимости";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // отображатьКнопкиУправленияToolStripMenuItem
            // 
            this.отображатьКнопкиУправленияToolStripMenuItem.Name = "отображатьКнопкиУправленияToolStripMenuItem";
            this.отображатьКнопкиУправленияToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.отображатьКнопкиУправленияToolStripMenuItem.Text = "Отображать (Кнопки управления)";
            this.отображатьКнопкиУправленияToolStripMenuItem.Click += new System.EventHandler(this.отображатьКнопкиУправленияToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(534, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Закрыть программу";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображатьтекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображатьВводToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem отображатьКнопкиУправленияToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

