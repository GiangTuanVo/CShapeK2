using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformProject.FileHelper;

namespace WinformProject.Model
{
    public class GetDataTable
    {
        public DataSet TakeData(DataSet dataSet, string text)
        {
            string[] split_text = text.Split('\\');
            DataTable system = new DataTable(split_text[split_text.Length - 1].Split('.')[0]);
            CSVFile.FileToTBL(Application.StartupPath, text, dataSet, system);
            return dataSet;
        }

    }
    /*
     *  if (_dataSet.Tables.Count != 0)
                for (int i = 0; i < _dataSet.Tables["FixTool"].Rows.Count; i++)
                {
                    string text = _dataSet.Tables["FixTool"].Rows[i][1].ToString();
                    if (text != "")
                        _listToolFix.Add(text);
                }
     */
}
