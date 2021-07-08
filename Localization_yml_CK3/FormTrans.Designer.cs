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
            this.button_load = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView = new System.Windows.Forms.TreeView();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker_Save = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker_Load = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.button_translete = new System.Windows.Forms.Button();
            this.backgroundWorker_Translete = new System.ComponentModel.BackgroundWorker();
            this.button_abort = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderLocalization
            // 
            this.folderLocalization.Description = "Выбрать папку localization мода";
            this.folderLocalization.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // button_load
            // 
            this.button_load.Enabled = false;
            this.button_load.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_load.Location = new System.Drawing.Point(265, 498);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(221, 23);
            this.button_load.TabIndex = 5;
            this.button_load.Text = "Загрузка .YML файлов";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(16, 498);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(176, 23);
            this.button_choose.TabIndex = 6;
            this.button_choose.Text = "Выбор папки локализации";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.Button_Choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый шаг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй шаг";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 467);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(981, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Файлова система";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(6, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(121, 97);
            this.treeView.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_save.Location = new System.Drawing.Point(824, 498);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(176, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Сохранения перевода";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Четвертий шаг";
            // 
            // backgroundWorker_Save
            // 
            this.backgroundWorker_Save.WorkerReportsProgress = true;
            this.backgroundWorker_Save.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker_Save.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2_ProgressChanged);
            this.backgroundWorker_Save.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_Save_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 527);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(984, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // backgroundWorker_Load
            // 
            this.backgroundWorker_Load.WorkerReportsProgress = true;
            this.backgroundWorker_Load.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            this.backgroundWorker_Load.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2_ProgressChanged);
            this.backgroundWorker_Load.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Третий шаг";
            // 
            // button_translete
            // 
            this.button_translete.Enabled = false;
            this.button_translete.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_translete.Location = new System.Drawing.Point(551, 498);
            this.button_translete.Name = "button_translete";
            this.button_translete.Size = new System.Drawing.Size(221, 23);
            this.button_translete.TabIndex = 13;
            this.button_translete.Text = "Перевод .YML файлов";
            this.button_translete.UseVisualStyleBackColor = true;
            this.button_translete.Click += new System.EventHandler(this.Button_translete_Click);
            // 
            // backgroundWorker_Translete
            // 
            this.backgroundWorker_Translete.WorkerReportsProgress = true;
            this.backgroundWorker_Translete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_Translete_DoWork);
            this.backgroundWorker_Translete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2_ProgressChanged);
            this.backgroundWorker_Translete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_Translete_RunWorkerCompleted);
            // 
            // button_abort
            // 
            this.button_abort.Location = new System.Drawing.Point(935, 7);
            this.button_abort.Name = "button_abort";
            this.button_abort.Size = new System.Drawing.Size(65, 23);
            this.button_abort.TabIndex = 1;
            this.button_abort.Text = "Сброс";
            this.button_abort.UseVisualStyleBackColor = true;
            this.button_abort.Click += new System.EventHandler(this.Button_Abort_Click);
            // 
            // formTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 565);
            this.Controls.Add(this.button_abort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_translete);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.button_load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машинный перевод";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderLocalization;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Save;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_translete;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Translete;
        private System.Windows.Forms.Button button_abort;
    }
}

