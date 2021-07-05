using LabTable;
using System;
using System.Data;
using System.Windows.Forms;
using LabFile;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Localization_yml_CK3
{
    public partial class formTrans : Form
    {
        DataTable table_loc = TableYML.CreateTable();
        public formTrans()
        {
            InitializeComponent();
        }

        private void выбратьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderLocalization.ShowDialog();
            System.Console.WriteLine(folderLocalization.SelectedPath);
            Regex regex_text = new Regex(@"localization", RegexOptions.IgnoreCase);
            if (!regex_text.IsMatch(folderLocalization.SelectedPath)){
                MessageBox.Show(
       "Не найдена папка localization",
       "Ошибка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.ServiceNotification);
                return;
            }
            comboBox_SourceLanguage.Enabled = true;
            comboBox_SourceLanguage.ForeColor = SystemColors.ControlText;
            comboBox_RecipientLanguage.Enabled = true;
            comboBox_RecipientLanguage.ForeColor = SystemColors.ControlText;
            buttonTranslate.Enabled = true;
            buttonTranslate.ForeColor = SystemColors.ControlText;
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            FileYML.OpenFile(folderLocalization.SelectedPath, comboBox_SourceLanguage.Text,out table_loc);
        }
    }
}
