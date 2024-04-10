using LibConnection.Profinet.Melsec;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibConnection;

namespace WinformProject
{
    public partial class FormMelsecComponent : Form
    {
        public FormMelsecComponent()
        {
            InitializeComponent();
        }

        private MelsecComponent melsecComponent = null;

        private string[] encodings = new string[]
          {
                "ASCII",
                "Unicode",
                "Unicode-big",
                "UTF8",
                "UTF32",
                "ANSI",
                "GB2312"
          };
        private void FormModbusRtu_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            comboBox_read_encoding.DataSource = encodings;
            comboBox_write_Encoding.DataSource = encodings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                melsecComponent = new MelsecComponent();
                OperateResult res = melsecComponent.Connection(int.Parse(txtStation.Text));
                if (res.IsSuccess)
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperateResult res = melsecComponent.Close();
            if (res.IsSuccess)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
        public string getChar(string inputtext)
        {
            Regex re1 = new Regex(@"([a-zA-Z]+)(\d+)");
            var regex = string.Format(@"([a-zA-Z]+)(\d+)");
            var match = Regex.Match(inputtext, regex, RegexOptions.IgnoreCase);
            if (match.Success) //neu chuoi co ca so va chu
            {
                Match result1 = re1.Match(inputtext);
                string alphaPart = result1.Groups[1].Value;
                return alphaPart;
            }
            else
            {
                return inputtext;
            }
        }

        public int getNum(string inputtext)
        {
            Regex re2 = new Regex(@"([0-9.]+)");
            Match result2 = re2.Match(inputtext);
            string numberPart = result2.Groups[1].Value;
            return int.Parse(numberPart);
        }

        private void button_read_bool_Click(object sender, EventArgs e)
        {
            textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{textBox3.Text}] {melsecComponent.ReadBool(textBox3.Text).Content}{Environment.NewLine}");
        }

        private void button_read_short_Click(object sender, EventArgs e)
        {
            short[] res = melsecComponent.ReadInt16(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i}] {res[i]}{Environment.NewLine}");
            }
        }
        private void button_read_ushort_Click(object sender, EventArgs e)
        {
            UInt16[] res = melsecComponent.ReadUInt16(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i}] {res[i]}{Environment.NewLine}");
            }
        }

        private void button_read_int_Click(object sender, EventArgs e)
        {
            int[] res = melsecComponent.ReadInt32(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 2}] {res[i]}{Environment.NewLine}");
            }
        }
        private void button_read_uint_Click(object sender, EventArgs e)
        {
            UInt32[] res = melsecComponent.ReadUInt32(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 2}] {res[i]}{Environment.NewLine}");
            }
        }

        private void button_read_long_Click(object sender, EventArgs e)
        {
            Int64[] res = melsecComponent.ReadInt64(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 4}] {res[i]}{Environment.NewLine}");
            }
        }
        private void button_read_ulong_Click(object sender, EventArgs e)
        {
            UInt64[] res = melsecComponent.ReadUInt64(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 4}] {res[i]}{Environment.NewLine}");
            }
        }
        private void button_read_float_Click(object sender, EventArgs e)
        {
            float[] res = melsecComponent.ReadFloat(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 2}] {res[i]}{Environment.NewLine}");
            }
        }

        private void button_read_double_Click(object sender, EventArgs e)
        {
            double[] res = melsecComponent.ReadDouble(textBox3.Text, int.Parse(textBox5.Text)).Content;
            for (int i = 0; i < res.Length; i++)
            {
                textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{getChar(textBox3.Text)}{getNum(textBox3.Text) + i * 2}] {res[i]}{Environment.NewLine}");
            }
        }

        private void button_read_string_Click(object sender, EventArgs e)
        {
            textBox4.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{textBox3.Text}] {melsecComponent.ReadString(textBox3.Text, int.Parse(textBox1.Text)).Content}");
            textBox4.AppendText("\r\n");
        }

        /*_________________________________________________________________________________________________________________________________________________________________________________*/
        private void button_write_bool_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(textBox7.Text, out bool val))
            {
                OperateResult res = melsecComponent.WriteBool(textBox8.Text, val);
                if (res.IsSuccess) MessageBox.Show("Send successful !");
                else MessageBox.Show("Send fail !");
            }
            else
                MessageBox.Show("Data format error");
        }

        private void button_write_short_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                short[] val = new short[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = short.TryParse(text[i], out short result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (short.TryParse(textBox7.Text, out short val))
                {
                    OperateResult ret = melsecComponent.WriteInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_ushort_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                ushort[] val = new ushort[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = ushort.TryParse(text[i], out ushort result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteUInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (ushort.TryParse(textBox7.Text, out ushort val))
                {
                    OperateResult ret = melsecComponent.WriteUInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_int_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                int[] val = new int[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = int.TryParse(text[i], out int result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteInt32(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (int.TryParse(textBox7.Text, out int val))
                {
                    OperateResult ret = melsecComponent.WriteInt32(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_uint_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                UInt32[] val = new UInt32[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = UInt32.TryParse(text[i], out UInt32 result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteUInt32(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (UInt32.TryParse(textBox7.Text, out UInt32 val))
                {
                    OperateResult ret = melsecComponent.WriteUInt32(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }
        private void button_write_long_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                Int64[] val = new Int64[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = Int64.TryParse(text[i], out Int64 result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteInt64(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (Int64.TryParse(textBox7.Text, out Int64 val))
                {
                    OperateResult ret = melsecComponent.WriteInt64(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_ulong_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                UInt64[] val = new UInt64[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = UInt64.TryParse(text[i], out UInt64 result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteUInt64(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (UInt64.TryParse(textBox7.Text, out UInt64 val))
                {
                    OperateResult ret = melsecComponent.WriteUInt64(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }
        private void button_write_float_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                float[] val = new float[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = float.TryParse(text[i], out float result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret = melsecComponent.WriteFloat(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (float.TryParse(textBox7.Text, out float val))
                {
                    OperateResult ret = melsecComponent.WriteFloat(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_hex_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                Int16[] val = new Int16[text.Length];
                try
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        short result = Convert.ToInt16(text[i], 16);
                        val[i] = result;
                    }
                    OperateResult ret = melsecComponent.WriteInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Data format error");
                }
            }
            else
            {
                try
                {
                    short val = Convert.ToInt16(textBox7.Text, 16);
                    OperateResult ret = melsecComponent.WriteInt16(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Data format error");
                }
            }
        }

        private void button_write_double_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.StartsWith("[") && textBox7.Text.EndsWith("]"))
            {
                bool check = false;
                string[] text = textBox7.Text.Replace('[', ' ').Replace(']', ' ').Trim().Split(',');
                double[] val = new double[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    bool res = double.TryParse(text[i], out double result);
                    if (res)
                    {
                        val[i] = result;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    OperateResult ret= melsecComponent.WriteDouble(textBox8.Text, val);
                    if (ret.IsSuccess) MessageBox.Show("Send successful !");
                    else MessageBox.Show("Send fail !");
                }
                else MessageBox.Show("Data format error");
            }
            else
            {
                if (double.TryParse(textBox7.Text, out double val))
                {
                    OperateResult ret = melsecComponent.WriteDouble(textBox8.Text, val);
                    if (ret.IsSuccess)
                        MessageBox.Show("Send successful !");
                    else
                        MessageBox.Show("Send fail !");
                }
                else
                    MessageBox.Show("Data format error");
            }
        }

        private void button_write_string_Click(object sender, EventArgs e)
        {
            OperateResult ret= melsecComponent.WriteString(textBox8.Text, textBox7.Text);
            if (ret.IsSuccess) MessageBox.Show("Send successful !");
            else MessageBox.Show("Send fail !");
        }
    }
}
