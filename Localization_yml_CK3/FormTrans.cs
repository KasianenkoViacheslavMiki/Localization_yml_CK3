using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Localization_yml_CK3
{
    public partial class formTrans : Form
    {
        public formTrans()
        {
            InitializeComponent();
        }

        private void выбратьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderLocalization.ShowDialog();
            System.Console.WriteLine(folderLocalization.SelectedPath);
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"", RegexOptions.IgnoreCase);

        }
    }
}
