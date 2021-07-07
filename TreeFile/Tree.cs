using System;
using LabTable;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace TreeFile
{
    public class Tree
    {
        static DataTable table_loc = TableYML.CreateTable();
        static public void CreateTree(string pathLoc, DataTable _table)
        {
            DataRow[] s = table_loc.Select();//.Select(x => (string)x).ToList();
            List<string> listPath = new List<string>();
            foreach (var t in s)
            {
                listPath.Add(t.ItemArray[0].ToString());
            }
            //  TreeNode treeLoc=new TreeNode();

            // treeView.SelectedNode;
        }
    }   
}
