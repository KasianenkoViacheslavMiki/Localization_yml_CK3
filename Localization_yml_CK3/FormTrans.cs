using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
          //  Regex begin_regex = new Regex(@"l_"+comboBox_SourceLanguage.Text+":", RegexOptions.IgnoreCase|RegexOptions.Multiline);
            Regex next_regex = new Regex(@"^\D*:\d\s\x22\D*\x22", RegexOptions.IgnoreCase);
            string[] files = Directory.GetFiles(folderLocalization.SelectedPath +'\u005c'+comboBox_SourceLanguage.Text, "*.yml", SearchOption.AllDirectories);
            foreach (string file in files)
                using (StreamReader fs = File.OpenText(file))
                {
                    while (fs.EndOfStream)
                    {
                        System.Console.WriteLine(fs.ReadLine());
                    }
                }

            }
        }
    }
}
