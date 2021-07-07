using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using LabTable;
using static LabTable.TableYML;
using System.Collections.Generic;
using API_translate;

namespace LabFile
{
    public class FileYML
    {
        static string pattern_name = @"\u0022\D*\u0022";
        static string pattern_text = @"\s\S*:\d\s";
        static private Regex regex_If = new Regex(pattern_text+ pattern_name, RegexOptions.IgnoreCase);
        static private Regex regex_text = new Regex(pattern_text, RegexOptions.IgnoreCase);
        static private Regex regex_name = new Regex(pattern_name, RegexOptions.IgnoreCase);
        
        static private List<TextYML> ReadYML(string _file)
        {
            Translator t = new Translator();
            string line;
            List<TextYML> textYML = new List<TextYML>();
            Console.WriteLine(_file);
            using (StreamReader fs = File.OpenText(_file))
            {
                while (!fs.EndOfStream)
                {
                    line = fs.ReadLine();
                    //Console.WriteLine("all " + line);
                    if (regex_If.IsMatch(line)) {
                        TextYML temp = new TextYML();
                        //Console.WriteLine("name " + regex_name.Split(line)[0]);
                        //Console.WriteLine("text " + regex_text.Split(line)[1]);
                        temp.Name = regex_name.Split(line)[0];
                        temp.Text = regex_text.Split(line)[1];
                        string translation = t.Translate(temp.Text, "English", "Russian");
                        temp.Text_Translate = (translation.Replace("\u00AB", "\u0022").Replace("\u00BB.", ".\u0022")).Replace("\u00BB", "\u0022");
                        //Console.WriteLine("text_Translate " + translation);
                        textYML.Add(temp);
                    }
                }
            }
            return textYML;
        }
        static public void OpenFile(string _path, string _sourceLan, out DataTable table_loc)
        {
            table_loc = TableYML.CreateTable();
            foreach (string file in PathFiles(_path, _sourceLan))
            {
                List<TextYML> textYML = ReadYML(file);
                foreach (TextYML transYML in textYML)
                {
                    table_loc = Insert(file, transYML.Name, transYML.Text, transYML.Text_Translate, table_loc);
                }
            }
        }
        static private string[] PathFiles(string _path,string _sourceLan)
        {
            return Directory.GetFiles(_path + '\u005c' + _sourceLan, "*.yml", SearchOption.AllDirectories);
        }
    }
}
