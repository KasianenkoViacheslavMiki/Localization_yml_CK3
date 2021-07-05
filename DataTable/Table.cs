using System;
using System.Data;

namespace LabTable
{
    public class TableYML
    {
        public struct TextYML
        {
            private string name;
            private string text;

            public string Name { get => name; set => name = value; }
            public string Text { get => text; set => text = value; }
        }
        static public DataTable CreateTable()
        {
            DataTable table_Loc = new DataTable();
            table_Loc.Columns.AddRange(CreateColumn());
            return table_Loc;
        }
        static private DataColumn[] CreateColumn()
        {
            DataColumn[] _cols ={
                                  new DataColumn("file",typeof(String)),
                                  new DataColumn("name",typeof(String)),
                                  new DataColumn("text",typeof(String)),
                                  new DataColumn("localizationText",typeof(String)),
                              };
            return _cols;
        }

        static public DataTable Insert(string _file,string _name, string _text, DataTable _table)
        {

            DataRow row = _table.NewRow();
            row["file"] = _file;
            row["name"] = _name;
            row["text"] = _text;
            _table.Rows.Add(row);
            return _table;
        }
        static public void InsertTransl(string _localizationText, DataTable _table)
        {
            DataRow row = _table.NewRow();
            _table.Rows.Add();
        }
    }
}
