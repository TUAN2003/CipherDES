﻿namespace WinFormsEncryptionDES
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textBox_data = new System.Windows.Forms.RichTextBox();
            this.label_data = new System.Windows.Forms.Label();
            this.label_ciphertext = new System.Windows.Forms.Label();
            this.textBox_ciphertext = new System.Windows.Forms.RichTextBox();
            this.button_detail = new System.Windows.Forms.Button();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.radioButton_isKeyText = new System.Windows.Forms.RadioButton();
            this.radioButton_isKeyHex = new System.Windows.Forms.RadioButton();
            this.radioButton_isHex = new System.Windows.Forms.RadioButton();
            this.radioButton_isText = new System.Windows.Forms.RadioButton();
            this.groupBox_keyType = new System.Windows.Forms.GroupBox();
            this.groupBox_plainTextType = new System.Windows.Forms.GroupBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.groupBox_keyType.SuspendLayout();
            this.groupBox_plainTextType.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_encrypt
            // 
            this.button_encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encrypt.Location = new System.Drawing.Point(147, 326);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(175, 70);
            this.button_encrypt.TabIndex = 0;
            this.button_encrypt.Text = "Encrypt To Hex";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textBox_data
            // 
            this.textBox_data.Font = new System.Drawing.Font("Fira Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data.Location = new System.Drawing.Point(12, 99);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(310, 137);
            this.textBox_data.TabIndex = 1;
            this.textBox_data.Text = "";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(143, 72);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(47, 24);
            this.label_data.TabIndex = 3;
            this.label_data.Text = "Data";
            // 
            // label_ciphertext
            // 
            this.label_ciphertext.AutoSize = true;
            this.label_ciphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ciphertext.Location = new System.Drawing.Point(464, 72);
            this.label_ciphertext.Name = "label_ciphertext";
            this.label_ciphertext.Size = new System.Drawing.Size(108, 24);
            this.label_ciphertext.TabIndex = 4;
            this.label_ciphertext.Text = "Cipher Text";
            // 
            // textBox_ciphertext
            // 
            this.textBox_ciphertext.Font = new System.Drawing.Font("Fira Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ciphertext.Location = new System.Drawing.Point(357, 99);
            this.textBox_ciphertext.Name = "textBox_ciphertext";
            this.textBox_ciphertext.Size = new System.Drawing.Size(310, 137);
            this.textBox_ciphertext.TabIndex = 5;
            this.textBox_ciphertext.Text = "";
            // 
            // button_detail
            // 
            this.button_detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detail.ForeColor = System.Drawing.Color.Red;
            this.button_detail.Location = new System.Drawing.Point(573, 360);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(94, 36);
            this.button_detail.TabIndex = 6;
            this.button_detail.Text = "Detail";
            this.button_detail.UseVisualStyleBackColor = true;
            this.button_detail.Click += new System.EventHandler(this.button_detail_Click);
            // 
            // textBox_key
            // 
            this.textBox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_key.Font = new System.Drawing.Font("Fira Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.ForeColor = System.Drawing.Color.Red;
            this.textBox_key.Location = new System.Drawing.Point(57, 14);
            this.textBox_key.MaxLength = 16;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(265, 31);
            this.textBox_key.TabIndex = 7;
            this.textBox_key.Text = "133457799BBCDFF1";
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_key.ForeColor = System.Drawing.Color.Black;
            this.label_key.Location = new System.Drawing.Point(12, 16);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(42, 24);
            this.label_key.TabIndex = 8;
            this.label_key.Text = "Key";
            // 
            // radioButton_isKeyText
            // 
            this.radioButton_isKeyText.AutoSize = true;
            this.radioButton_isKeyText.Location = new System.Drawing.Point(6, 19);
            this.radioButton_isKeyText.Name = "radioButton_isKeyText";
            this.radioButton_isKeyText.Size = new System.Drawing.Size(46, 17);
            this.radioButton_isKeyText.TabIndex = 9;
            this.radioButton_isKeyText.Text = "Text";
            this.radioButton_isKeyText.UseVisualStyleBackColor = true;
            this.radioButton_isKeyText.CheckedChanged += new System.EventHandler(this.radioButton_isKeyText_CheckedChanged);
            // 
            // radioButton_isKeyHex
            // 
            this.radioButton_isKeyHex.AutoSize = true;
            this.radioButton_isKeyHex.Checked = true;
            this.radioButton_isKeyHex.Location = new System.Drawing.Point(57, 19);
            this.radioButton_isKeyHex.Name = "radioButton_isKeyHex";
            this.radioButton_isKeyHex.Size = new System.Drawing.Size(44, 17);
            this.radioButton_isKeyHex.TabIndex = 10;
            this.radioButton_isKeyHex.TabStop = true;
            this.radioButton_isKeyHex.Text = "Hex";
            this.radioButton_isKeyHex.UseVisualStyleBackColor = true;
            this.radioButton_isKeyHex.CheckedChanged += new System.EventHandler(this.radioButton_isKeyHex_CheckedChanged);
            // 
            // radioButton_isHex
            // 
            this.radioButton_isHex.AutoSize = true;
            this.radioButton_isHex.Location = new System.Drawing.Point(58, 23);
            this.radioButton_isHex.Name = "radioButton_isHex";
            this.radioButton_isHex.Size = new System.Drawing.Size(44, 17);
            this.radioButton_isHex.TabIndex = 12;
            this.radioButton_isHex.Text = "Hex";
            this.radioButton_isHex.UseVisualStyleBackColor = true;
            // 
            // radioButton_isText
            // 
            this.radioButton_isText.AutoSize = true;
            this.radioButton_isText.Checked = true;
            this.radioButton_isText.Location = new System.Drawing.Point(6, 23);
            this.radioButton_isText.Name = "radioButton_isText";
            this.radioButton_isText.Size = new System.Drawing.Size(46, 17);
            this.radioButton_isText.TabIndex = 11;
            this.radioButton_isText.TabStop = true;
            this.radioButton_isText.Text = "Text";
            this.radioButton_isText.UseVisualStyleBackColor = true;
            // 
            // groupBox_keyType
            // 
            this.groupBox_keyType.Controls.Add(this.radioButton_isKeyHex);
            this.groupBox_keyType.Controls.Add(this.radioButton_isKeyText);
            this.groupBox_keyType.Location = new System.Drawing.Point(328, 7);
            this.groupBox_keyType.Name = "groupBox_keyType";
            this.groupBox_keyType.Size = new System.Drawing.Size(107, 44);
            this.groupBox_keyType.TabIndex = 13;
            this.groupBox_keyType.TabStop = false;
            this.groupBox_keyType.Text = "KeyType";
            // 
            // groupBox_plainTextType
            // 
            this.groupBox_plainTextType.Controls.Add(this.radioButton_isHex);
            this.groupBox_plainTextType.Controls.Add(this.radioButton_isText);
            this.groupBox_plainTextType.Location = new System.Drawing.Point(12, 242);
            this.groupBox_plainTextType.Name = "groupBox_plainTextType";
            this.groupBox_plainTextType.Size = new System.Drawing.Size(110, 49);
            this.groupBox_plainTextType.TabIndex = 14;
            this.groupBox_plainTextType.TabStop = false;
            this.groupBox_plainTextType.Text = "DataType";
            // 
            // button_decrypt
            // 
            this.button_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decrypt.Location = new System.Drawing.Point(357, 326);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(175, 70);
            this.button_decrypt.TabIndex = 15;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(679, 413);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.groupBox_plainTextType);
            this.Controls.Add(this.groupBox_keyType);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.textBox_ciphertext);
            this.Controls.Add(this.label_ciphertext);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.button_encrypt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEncyptionStandard";
            this.groupBox_keyType.ResumeLayout(false);
            this.groupBox_keyType.PerformLayout();
            this.groupBox_plainTextType.ResumeLayout(false);
            this.groupBox_plainTextType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.RichTextBox textBox_data;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_ciphertext;
        private System.Windows.Forms.RichTextBox textBox_ciphertext;
        private System.Windows.Forms.Button button_detail;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.RadioButton radioButton_isKeyText;
        private System.Windows.Forms.RadioButton radioButton_isKeyHex;
        private System.Windows.Forms.RadioButton radioButton_isHex;
        private System.Windows.Forms.RadioButton radioButton_isText;
        private System.Windows.Forms.GroupBox groupBox_keyType;
        private System.Windows.Forms.GroupBox groupBox_plainTextType;
        private System.Windows.Forms.Button button_decrypt;
    }
}

