using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsEncryptionDES
{
    public partial class Form1 : Form
    {
        private DESAlgorithm _des;

        public Form1()
        {
            InitializeComponent();
            _des = new DESAlgorithm();
        }
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            string key = this.textBox_key.Text.Trim();
            string data = this.textBox_data.Text.Trim();
            bool isKeyHex = radioButton_isKeyHex.Checked;
            bool isDataHex = radioButton_isHex.Checked;
            EncodeDES(key,data,isKeyHex,isDataHex);
        }
        private void button_detail_Click(object sender, EventArgs e)
        {
            Form2 form = null;
            foreach(Form item in Application.OpenForms)
            {
                if (item.Name.Equals("Form2") && item is WinFormsEncryptionDES.Form2)
                {
                    form = item as Form2;
                }
            }
            form = form ?? new Form2(_des);
            form.Show();
            form.Activate();
        }
        private bool CheckKey(string key,bool isHex)
        {
            try
            {
                if (isHex)
                {
                    _des.Key = UInt64.Parse(key, NumberStyles.HexNumber);
                }
                else
                {
                    _des.Key = ConvertTextToHex(key);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private UInt64 ConvertTextToHex(string key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            string hex = BitConverter.ToString(bytes).Replace("-", "").PadRight(16,'0');
            return UInt64.Parse(hex, NumberStyles.HexNumber);
        }
        private void button_decrypt_Click(object sender, EventArgs e)
        {
            string key = this.textBox_key.Text.Trim();
            string cipherText = this.textBox_ciphertext.Text.Trim();
            bool isKeyHex = radioButton_isKeyHex.Checked;
            DecodeDES(key, cipherText, isKeyHex);
        }
        private void radioButton_isKeyText_Click(object sender, EventArgs e)
        {
            string s = this.textBox_key.Text;
            this.textBox_key.MaxLength = 8;
            if (s.Length > 8)
                this.textBox_key.Text = s.Substring(0, 8);
        }
        private void radioButton_isKeyHex_Click(object sender, EventArgs e)
        {
            this.textBox_key.MaxLength = 16;
        }
        private void EncodeDES(string key,string data,bool isKeyHex,bool isDataHex)
        {
            if (!CheckKey(key, isKeyHex))
            {
                MessageBox.Show("Key không hợp lệ", "Lỗi định dạng key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _des.IsDataHex = isDataHex;
            try
            {
                _des.Data = data;
            }
            catch (Exception)
            {
                if (isDataHex)
                {
                    MessageBox.Show("mã hex không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            this.textBox_ciphertext.Text = _des.EnCode();
        }
        private void DecodeDES(string key, string data, bool isKeyHex)
        {
            if (!CheckKey(key, isKeyHex))
            {
                return;
            }
            _des.IsDataHex = true;
            _des.Data = data;
            this.textBox_data.Text = _des.DeCode(!this.radioButton_isHex.Checked);
        }
    }
}
