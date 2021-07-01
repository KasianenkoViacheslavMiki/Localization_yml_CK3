namespace Localization_yml_CK3
{
    partial class formTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrans));
            this.folderLocalization = new System.Windows.Forms.FolderBrowserDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_SourceLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_RecipientLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderLocalization
            // 
            this.folderLocalization.Description = "Выбрать папку localization мода";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(300, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьПапкуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьПапкуToolStripMenuItem
            // 
            this.выбратьПапкуToolStripMenuItem.Name = "выбратьПапкуToolStripMenuItem";
            this.выбратьПапкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбратьПапкуToolStripMenuItem.Text = "Выбрать папку";
            this.выбратьПапкуToolStripMenuItem.Click += new System.EventHandler(this.выбратьПапкуToolStripMenuItem_Click);
            // 
            // comboBox_SourceLanguage
            // 
            this.comboBox_SourceLanguage.FormattingEnabled = true;
            this.comboBox_SourceLanguage.Items.AddRange(new object[] {
            "english"});
            this.comboBox_SourceLanguage.Location = new System.Drawing.Point(12, 48);
            this.comboBox_SourceLanguage.Name = "comboBox_SourceLanguage";
            this.comboBox_SourceLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SourceLanguage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Язык исходник ";
            // 
            // comboBox_RecipientLanguage
            // 
            this.comboBox_RecipientLanguage.FormattingEnabled = true;
            this.comboBox_RecipientLanguage.Items.AddRange(new object[] {
            "russian"});
            this.comboBox_RecipientLanguage.Location = new System.Drawing.Point(160, 48);
            this.comboBox_RecipientLanguage.Name = "comboBox_RecipientLanguage";
            this.comboBox_RecipientLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBox_RecipientLanguage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Язык реципиент";
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(88, 92);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(121, 23);
            this.buttonTranslate.TabIndex = 5;
            this.buttonTranslate.Text = "Перевод";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // formTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 133);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_RecipientLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SourceLanguage);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "formTrans";
            this.Text = "Машинный перевод";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderLocalization;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьПапкуToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_SourceLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_RecipientLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTranslate;
    }
}

