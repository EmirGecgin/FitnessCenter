namespace FitnessCenterApp
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.cikisLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tutarTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uyeAdiSoyadiTxt = new System.Windows.Forms.TextBox();
            this.odemeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.odeButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.araButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisLabel
            // 
            this.cikisLabel.AutoSize = true;
            this.cikisLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisLabel.Location = new System.Drawing.Point(838, 9);
            this.cikisLabel.Name = "cikisLabel";
            this.cikisLabel.Size = new System.Drawing.Size(35, 38);
            this.cikisLabel.TabIndex = 9;
            this.cikisLabel.Text = "X";
            this.cikisLabel.Click += new System.EventHandler(this.cikisLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(388, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ödemeler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "FITNESS CENTER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(20, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tutar:";
            // 
            // tutarTxt
            // 
            this.tutarTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutarTxt.Location = new System.Drawing.Point(25, 290);
            this.tutarTxt.MaxLength = 4;
            this.tutarTxt.Multiline = true;
            this.tutarTxt.Name = "tutarTxt";
            this.tutarTxt.Size = new System.Drawing.Size(163, 32);
            this.tutarTxt.TabIndex = 12;
            this.tutarTxt.TextChanged += new System.EventHandler(this.tutarTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Üye Adı Soyadı:";
            // 
            // uyeAdiSoyadiTxt
            // 
            this.uyeAdiSoyadiTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeAdiSoyadiTxt.Location = new System.Drawing.Point(25, 227);
            this.uyeAdiSoyadiTxt.Multiline = true;
            this.uyeAdiSoyadiTxt.Name = "uyeAdiSoyadiTxt";
            this.uyeAdiSoyadiTxt.Size = new System.Drawing.Size(163, 32);
            this.uyeAdiSoyadiTxt.TabIndex = 10;
            this.uyeAdiSoyadiTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyeAdiSoyadiTxt_KeyPress);
            // 
            // odemeDateTimePicker
            // 
            this.odemeDateTimePicker.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.odemeDateTimePicker.Location = new System.Drawing.Point(25, 166);
            this.odemeDateTimePicker.Name = "odemeDateTimePicker";
            this.odemeDateTimePicker.Size = new System.Drawing.Size(163, 30);
            this.odemeDateTimePicker.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ödeme Ayı:";
            // 
            // odeButton
            // 
            this.odeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odeButton.ForeColor = System.Drawing.Color.Brown;
            this.odeButton.Location = new System.Drawing.Point(25, 395);
            this.odeButton.Name = "odeButton";
            this.odeButton.Size = new System.Drawing.Size(163, 39);
            this.odeButton.TabIndex = 22;
            this.odeButton.Text = "Öde";
            this.odeButton.UseVisualStyleBackColor = true;
            this.odeButton.Click += new System.EventHandler(this.odeButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.Brown;
            this.temizleButton.Location = new System.Drawing.Point(25, 449);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(163, 39);
            this.temizleButton.TabIndex = 21;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.Color.Brown;
            this.geriButton.Location = new System.Drawing.Point(683, 451);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(152, 37);
            this.geriButton.TabIndex = 23;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 329);
            this.dataGridView1.TabIndex = 41;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FitnessCenterApp.Properties.Resources._360_F_331996996_la12k9wp49oTnfyEUWVVHbrXmSyXTfT4_PhotoRoom_png_PhotoRoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 220);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.ForeColor = System.Drawing.Color.Brown;
            this.araButton.Location = new System.Drawing.Point(25, 341);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(163, 39);
            this.araButton.TabIndex = 51;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(881, 500);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.odeButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.odemeDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tutarTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uyeAdiSoyadiTxt);
            this.Controls.Add(this.cikisLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cikisLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tutarTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uyeAdiSoyadiTxt;
        private System.Windows.Forms.DateTimePicker odemeDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button odeButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button araButton;
    }
}