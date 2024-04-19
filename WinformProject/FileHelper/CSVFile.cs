using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformProject.FileHelper
{
    public class CSVFile
    {
        public static void FileToTBL(string folder, string fileName, DataSet ds, DataTable tbl)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string path = Path.Combine(folder, fileName);
                if (!File.Exists(path))
                    return;
                StreamReader streamReader = new StreamReader(Path.Combine(folder, fileName), Encoding.Default);
                while (streamReader.Peek() >= 0)
                {
                    string str = streamReader.ReadLine();
                    if (Operators.CompareString(str, "", false) != 0)
                    {
                        string[] strArray = Strings.Split(str, ",");
                        if (num1 == 0)
                        {
                            num2 = checked(Information.UBound((Array)strArray) + 1);
                            int num3 = Information.UBound((Array)strArray);
                            int index = 0;
                            while (index <= num3)
                            {
                                tbl.Columns.Add(strArray[index], typeof(string));
                                checked { ++index; }
                            }
                        }
                        else
                        {
                            if (checked(Information.UBound((Array)strArray) + 1) != num2)
                            {
                                MessageBox.Show("err15:csv file error \r\n" +
                                    "fileName=" + System.IO.Path.Combine(folder, fileName) +
                                    "line=" + Conversions.ToString(checked(num1 + 1)), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            DataRow row = tbl.NewRow();
                            int num3 = Information.UBound((Array)strArray);
                            int columnIndex = 0;
                            while (columnIndex <= num3)
                            {
                                row[columnIndex] = (object)strArray[columnIndex];
                                checked { ++columnIndex; }
                            }
                            tbl.Rows.Add(row);
                        }
                        checked { ++num1; }
                    }
                }
                streamReader.Close();
                ds.Tables.Add(tbl);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
