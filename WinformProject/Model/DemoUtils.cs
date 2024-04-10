using LibConnection;
using System;
using System.Text;
using System.Windows.Forms;

namespace WinformProject
{
    /// <summary>
    /// Some static variable information of the DEMO program
    /// </summary>
    public class DemoUtils
    {

        /// <summary>
        /// Control the number of rows of <see cref="DataGridView"/> to the specified number of rows
        /// </summary>
        /// <param name="dataGridView1">Icon control</param>
        /// <param name="row">Specified row number information</param>
        public static void DataGridSpecifyRowCount(DataGridView dataGridView1, int row)
        {
            if (dataGridView1.AllowUserToAddRows)
            {
                row++;
            }
            if (dataGridView1.RowCount < row)
            {
                dataGridView1.Rows.Add(row - dataGridView1.RowCount);
            }
            else if (dataGridView1.RowCount > row)
            {
                int deleteRows = dataGridView1.RowCount - row;
                for (int i = 0; i < deleteRows; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            }
            if (row > 0)
            {
                dataGridView1.Rows[0].Cells[0].Selected = false;
            }
        }


        /// <summary>
        /// Unified data analysis and display of reading results
        /// </summary>
        /// <typeparam name="T">Type object</typeparam>
        /// <param name="result">Read result value</param>
        /// <param name="address">Address information</param>
        /// <param name="textBox">Input control</param>
        public static void ReadResultRender<T>(OperateResult<T> result, string address, TextBox textBox)
        {
            if (result.IsSuccess)
            {
                if (result.Content is Array)
                {
                    textBox.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {LibConnection.BasicFramework.SoftBasic.ArrayFormat(result.Content)}{Environment.NewLine}");
                }
                else
                {
                    textBox.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {result.Content}{Environment.NewLine}");
                }
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] Read Failed {Environment.NewLine}Reason：{result.ToMessageShowString()}");
            }
        }

        /// <summary>
        /// Display the results of unified data writing
        /// </summary>
        /// <param name="result">Written result information</param>
        /// <param name="address">Address information</param>
        public static void WriteResultRender(OperateResult result, string address)
        {
            if (result.IsSuccess)
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] Write Success");
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] Write Failed {Environment.NewLine} Reason：{result.ToMessageShowString()}");
            }
        }

        /// <summary>
        /// Display the results of unified data writing
        /// </summary>
        /// <param name="result">Written result information</param>
        /// <param name="address">Address information</param>
        public static void WriteResultRender(OperateResult result)
        {
            if (result.IsSuccess)
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"Success");
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"Failed {Environment.NewLine} Reason：{result.ToMessageShowString()}");
            }
        }

        /// <summary>
        /// Display the results of unified data writing
        /// </summary>
        /// <param name="result">Written result information</param>
        /// <param name="address">Address information</param>
        public static void WriteResultRender(Func<OperateResult> write, string address)
        {
            try
            {
                OperateResult result = write();
                if (result.IsSuccess)
                {
                    MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] Write Success");
                }
                else
                {
                    MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] Write Failed {Environment.NewLine} Reason：{result.ToMessageShowString()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data for writting is not corrent: " + ex.Message);
            }
        }

        public static void BulkReadRenderResult(LibConnection.Core.IReadWriteNet readWrite, TextBox addTextBox, TextBox lengthTextBox, TextBox resultTextBox)
        {
            try
            {
                OperateResult<byte[]> read = readWrite.Read(addTextBox.Text, ushort.Parse(lengthTextBox.Text));
                if (read.IsSuccess)
                {
                    resultTextBox.Text = "Result：" + LibConnection.BasicFramework.SoftBasic.ByteToHexString(read.Content);
                }
                else
                {
                    MessageBox.Show("Read Failed：" + read.ToMessageShowString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read Failed：" + ex.Message);
            }
        }

        /// <summary>
        /// Add message text to the text display control
        /// </summary>
        /// <param name="textBox">Displayed control</param>
        /// <param name="key">Keyword information</param>
        /// <param name="message">Message text</param>
        /// <param name="maxKeyLength">Alignment length</param>
        public static void AppendTextBox(TextBox textBox, string key, string message, int maxKeyLength = -1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] ");
            if (!string.IsNullOrEmpty(key))
            {
                sb.Append("[" + key + "] ");
            }
            sb.Append(message);
            sb.Append(Environment.NewLine);
            textBox.AppendText(sb.ToString());
        }

        public static OperateResult<int> ParseInt(string text)
        {
            try
            {
                if (text.StartsWith("0x") || text.StartsWith("0X"))
                {
                    return OperateResult.CreateSuccessResult(Convert.ToInt32(text.Substring(2), 16));
                }
                else
                    return OperateResult.CreateSuccessResult(Convert.ToInt32(text));
            }
            catch (Exception ex)
            {
                return new OperateResult<int>("Convert Int Failed: " + ex.Message);
            }
        }

        public static readonly string IpAddressInputWrong = "IpAddress input wrong";
        public static readonly string PortInputWrong = "Port input wrong";
        public static readonly string SlotInputWrong = "Slot input wrong";
        public static readonly string BaudRateInputWrong = "Baud rate input wrong";
        public static readonly string DataBitsInputWrong = "Data bit input wrong";
        public static readonly string StopBitInputWrong = "Stop bit input wrong";
    }
}
