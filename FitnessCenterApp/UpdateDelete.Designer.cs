namespace FitnessCenterApp
{
    partial class UpdateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDelete));
            this.geriButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.zamanlamaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aylikTutarTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uyeAdiSoyadiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyelerLbl = new System.Windows.Forms.Label();
            this.telMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kadinRadioButton = new System.Windows.Forms.RadioButton();
            this.erkekRadioButton = new System.Windows.Forms.RadioButton();
            this.cikisLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriButton
            // 
            this.geriButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.Color.Brown;
            this.geriButton.Location = new System.Drawing.Point(772, 504);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(121, 44);
            this.geriButton.TabIndex = 38;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.Brown;
            this.temizleButton.Location = new System.Drawing.Point(18, 510);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(163, 41);
            this.temizleButton.TabIndex = 37;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.ForeColor = System.Drawing.Color.Brown;
            this.ekleButton.Location = new System.Drawing.Point(17, 463);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(164, 41);
            this.ekleButton.TabIndex = 36;
            this.ekleButton.Text = "Güncelle";
            this.ekleButton.UseVisualStyleBackColor = true;
            // 
            // zamanlamaComboBox
            // 
            this.zamanlamaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanlamaComboBox.FormattingEnabled = true;
            this.zamanlamaComboBox.Items.AddRange(new object[] {
            "Sınırsız",
            "07:00-09:00",
            "09:00-11:00",
            "11:00-13:00",
            "13:00-15:00",
            "15:00-17:00",
            "17:00-19:00",
            "19:00-21:00",
            "21:00-23:00"});
            this.zamanlamaComboBox.Location = new System.Drawing.Point(14, 241);
            this.zamanlamaComboBox.Name = "zamanlamaComboBox";
            this.zamanlamaComboBox.Size = new System.Drawing.Size(163, 33);
            this.zamanlamaComboBox.TabIndex = 35;
            this.zamanlamaComboBox.SelectedIndexChanged += new System.EventHandler(this.zamanlamaComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(10, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Zamanlama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(10, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Aylık Tutar:";
            // 
            // aylikTutarTxt
            // 
            this.aylikTutarTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aylikTutarTxt.Location = new System.Drawing.Point(14, 374);
            this.aylikTutarTxt.MaxLength = 4;
            this.aylikTutarTxt.Multiline = true;
            this.aylikTutarTxt.Name = "aylikTutarTxt";
            this.aylikTutarTxt.ReadOnly = true;
            this.aylikTutarTxt.Size = new System.Drawing.Size(163, 32);
            this.aylikTutarTxt.TabIndex = 32;
            this.aylikTutarTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aylikTutarTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Yaş:";
            // 
            // yasTxt
            // 
            this.yasTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasTxt.Location = new System.Drawing.Point(17, 358);
            this.yasTxt.MaxLength = 2;
            this.yasTxt.Multiline = true;
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(163, 32);
            this.yasTxt.TabIndex = 28;
            this.yasTxt.TextChanged += new System.EventHandler(this.yasTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Üye Adı Soyadı:";
            // 
            // uyeAdiSoyadiTxt
            // 
            this.uyeAdiSoyadiTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeAdiSoyadiTxt.Location = new System.Drawing.Point(17, 98);
            this.uyeAdiSoyadiTxt.Multiline = true;
            this.uyeAdiSoyadiTxt.Name = "uyeAdiSoyadiTxt";
            this.uyeAdiSoyadiTxt.Size = new System.Drawing.Size(163, 32);
            this.uyeAdiSoyadiTxt.TabIndex = 24;
            this.uyeAdiSoyadiTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyeAdiSoyadiTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(318, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "Üye Güncelleme Silme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "FITNESS CENTER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 369);
            this.dataGridView1.TabIndex = 40;
            // 
            // uyelerLbl
            // 
            this.uyelerLbl.AutoSize = true;
            this.uyelerLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyelerLbl.ForeColor = System.Drawing.Color.Brown;
            this.uyelerLbl.Location = new System.Drawing.Point(474, 101);
            this.uyelerLbl.Name = "uyelerLbl";
            this.uyelerLbl.Size = new System.Drawing.Size(228, 25);
            this.uyelerLbl.TabIndex = 41;
            this.uyelerLbl.Text = "Silinecek Üyeye Tıklayınız";
            // 
            // telMaskedTextBox
            // 
            this.telMaskedTextBox.Location = new System.Drawing.Point(17, 161);
            this.telMaskedTextBox.Mask = "(999) 000-0000";
            this.telMaskedTextBox.Name = "telMaskedTextBox";
            this.telMaskedTextBox.Size = new System.Drawing.Size(163, 22);
            this.telMaskedTextBox.TabIndex = 42;
            // 
            // kadinRadioButton
            // 
            this.kadinRadioButton.AutoSize = true;
            this.kadinRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadinRadioButton.ForeColor = System.Drawing.Color.Brown;
            this.kadinRadioButton.Location = new System.Drawing.Point(106, 228);
            this.kadinRadioButton.Name = "kadinRadioButton";
            this.kadinRadioButton.Size = new System.Drawing.Size(83, 29);
            this.kadinRadioButton.TabIndex = 47;
            this.kadinRadioButton.TabStop = true;
            this.kadinRadioButton.Text = "Kadın";
            this.kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // erkekRadioButton
            // 
            this.erkekRadioButton.AutoSize = true;
            this.erkekRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekRadioButton.ForeColor = System.Drawing.Color.Brown;
            this.erkekRadioButton.Location = new System.Drawing.Point(17, 228);
            this.erkekRadioButton.Name = "erkekRadioButton";
            this.erkekRadioButton.Size = new System.Drawing.Size(83, 29);
            this.erkekRadioButton.TabIndex = 46;
            this.erkekRadioButton.TabStop = true;
            this.erkekRadioButton.Text = "Erkek";
            this.erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // cikisLabel
            // 
            this.cikisLabel.AutoSize = true;
            this.cikisLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisLabel.ForeColor = System.Drawing.Color.Brown;
            this.cikisLabel.Location = new System.Drawing.Point(903, 9);
            this.cikisLabel.Name = "cikisLabel";
            this.cikisLabel.Size = new System.Drawing.Size(41, 43);
            this.cikisLabel.TabIndex = 48;
            this.cikisLabel.Text = "X";
            this.cikisLabel.Click += new System.EventHandler(this.cikisLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.aylikTutarTxt);
            this.groupBox1.Controls.Add(this.zamanlamaComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 415);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(183, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 32);
            this.button1.TabIndex = 50;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(956, 563);
            this.Controls.Add(this.cikisLabel);
            this.Controls.Add(this.kadinRadioButton);
            this.Controls.Add(this.erkekRadioButton);
            this.Controls.Add(this.telMaskedTextBox);
            this.Controls.Add(this.uyelerLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yasTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uyeAdiSoyadiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.ComboBox zamanlamaComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aylikTutarTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uyeAdiSoyadiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label uyelerLbl;
        private System.Windows.Forms.MaskedTextBox telMaskedTextBox;
        private System.Windows.Forms.RadioButton kadinRadioButton;
        private System.Windows.Forms.RadioButton erkekRadioButton;
        private System.Windows.Forms.Label cikisLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}