using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTable;
namespace Localization_yml_CK3
{
    public partial class FormTable : Form
    {
        DataTable table_loc = TableYML.CreateTable();
        public FormTable(DataTable _table_loc)
        {
            table_loc = _table_loc;
            InitializeComponent();
            dataGridView1.DataSource = table_loc;
        }

        private void FormTable_Load(object sender, EventArgs e)
        {

        }
    }
}
