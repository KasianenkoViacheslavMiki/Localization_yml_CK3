using LabTable;
using System;
using System.Data;
using System.Windows.Forms;
using LabFile;
using System.Drawing;
using System.Linq;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            folderLocalization.ShowDialog();

            button_choose = OffButton(button_choose);

            button_load = OnButton(button_load);
        }
        private void ButtonTranslate_Click(object sender, EventArgs e)
        {
            pathsLab = FileYML.PathFiles(folderLocalization.SelectedPath);
            if (FileYML.OpenFile(folderLocalization.SelectedPath, out table_loc))
            {
                ShowError();
                return;
            }
            dataGridView1.DataSource = table_loc;
            dataGridView1.Update();

            button_load = OffButton(button_load);

            button_save = OnButton(button_save);
        }
        private void Button_save_Click(object sender, EventArgs e)
        {
            FileYML.SaveFiles(pathsLab, table_loc);

            button_choose = OnButton(button_choose);

            button_save = OffButton(button_save);
        }
    }
}
