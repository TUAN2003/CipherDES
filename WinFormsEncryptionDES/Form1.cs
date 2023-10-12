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
        //0x133457799BBCDFF1
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            string key = this.textBox_key.Text.Trim();
            string data = this.textBox_data.Text.Trim();
            bool isKeyHex = radioButton_isKeyHex.Checked;
            bool isDataHex =radioButton_isHex.Checked;
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
        private void button_detail_Click(object sender, EventArgs e)
        {
            Form2 form = null;
            foreach(Form item in System.Windows.Forms.Application.OpenForms)
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
        private bool CheckInput(string input,bool isHex)
        {
            return true;
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
            int length = key.Length;
            if(length != 8)
            {
                throw new Exception("length != 8");
            }
            byte[] bytes = Encoding.ASCII.GetBytes(key);
            string hex = BitConverter.ToString(bytes).Replace("-", "");
            return UInt64.Parse(hex, NumberStyles.HexNumber);
        }
        private void button_decrypt_Click(object sender, EventArgs e)
        {
            string key = this.textBox_key.Text.Trim();
            string cipherText = this.textBox_ciphertext.Text.Trim();
            bool isKeyHex = radioButton_isKeyHex.Checked;
            if (!CheckKey(key, isKeyHex))
            {
                return;
            }
            _des.IsDataHex = true;
            _des.Data = cipherText;
            this.textBox_data.Text = _des.DeCode(!this.radioButton_isHex.Checked);
        }

        private void radioButton_isKeyText_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_key.MaxLength = 8;
            string s = this.textBox_key.Text;
            if (s.Length > 8)
                this.textBox_key.Text = s.Substring(0, 8);
        }

        private void radioButton_isKeyHex_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_key.MaxLength = 16;
        }
    }
}
