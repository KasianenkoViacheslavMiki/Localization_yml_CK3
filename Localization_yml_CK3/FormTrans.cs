using LabFile;
using LabTable;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Localization_yml_CK3
{
    public partial class formTrans : Form
    {
        string[] pathsLab;
        private Button OffButton(Button button)
        {
            button.Enabled = false;
            button.ForeColor = SystemColors.AppWorkspace;
            return button;
        }
        private Button OnButton(Button button)
        {
            button.Enabled = true;
            button.ForeColor = SystemColors.ControlText;
            return button;
        }

        private static void ShowError()
        {
            MessageBox.Show(
                   "Не найдено .YML файлы",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.ServiceNotification);
        }

        DataTable table_loc = TableYML.CreateTable();
        public formTrans()
        {
            InitializeComponent();
            dataGridView1.DataSource = table_loc;
        }

        private void Button_Choose_Click(object sender, EventArgs e)
        {
            folderLocalization.ShowDialog();

            button_choose = OffButton(button_choose);

            button_load = OnButton(button_load);
        }
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            button_load = OffButton(button_load);
            backgroundWorker_Load.RunWorkerAsync();

            button_load = OffButton(button_load);

            button_translete = OnButton(button_translete);
        }
        private void Button_save_Click(object sender, EventArgs e)
        {
            
            backgroundWorker_Save.RunWorkerAsync();

            
            button_save = OffButton(button_save);
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            FileYML.SaveFiles(pathsLab, table_loc);
        }
        void SetLoc()
        {
            if (dataGridView1.InvokeRequired) dataGridView1.Invoke(new Action(() => { dataGridView1.DataSource = table_loc; dataGridView1.Update(); }));
            else { dataGridView1.DataSource = table_loc; dataGridView1.Update(); }
            }
        private void BackgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
 
            pathsLab = FileYML.PathFiles(folderLocalization.SelectedPath);
            if (FileYML.OpenFile(folderLocalization.SelectedPath, out table_loc, sender))
            {
                ShowError();
                return;
            }

            SetLoc();
        }

        private void BackgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            

            button_translete = OnButton(button_translete);
            SetLoc();
        }

        private void Button_translete_Click(object sender, EventArgs e)
        {
            backgroundWorker_Translete.RunWorkerAsync();
            button_translete = OffButton(button_translete);
            
        }

        private void BackgroundWorker_Translete_DoWork(object sender, DoWorkEventArgs e)
        {
            FileYML.TransleteFile(out table_loc, sender);
            SetLoc();
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_Load.IsBusy) backgroundWorker_Load.CancelAsync();
            if (backgroundWorker_Save.IsBusy) backgroundWorker_Save.CancelAsync();
            if (backgroundWorker_Translete.IsBusy) backgroundWorker_Translete.CancelAsync();
            table_loc = TableYML.CreateTable();
            SetLoc();
            button_choose = OnButton(button_choose);
            button_load = OffButton(button_load);
            button_save = OffButton(button_save);
            button_translete = OffButton(button_translete);
        }

        private void BackgroundWorker_Translete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button_save = OnButton(button_save);
            SetLoc();
        }

        private void BackgroundWorker_Save_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }

}
