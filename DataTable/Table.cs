using System;
using System.Data;

namespace DataTables
{
    public class Table
    {
        public DataTable CreateTable()
        {
            DataTable table = new DataTable("OrderDetail");
            DataColumn[] cols ={
                                  new DataColumn("ID",typeof(Int32)),
                                  new DataColumn("Name",typeof(String)),
                                  new DataColumn("Text",typeof(String)),
                                  new DataColumn("LocalizationText",typeof(String)),
                              };

            table.Columns.AddRange(cols);
            table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
            return table;
        }

    }
}
