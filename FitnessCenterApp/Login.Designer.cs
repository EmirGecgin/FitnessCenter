namespace FitnessCenterApp
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.baslik = new System.Windows.Forms.Label();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.parolaTxt = new System.Windows.Forms.TextBox();
            this.parolaPic = new System.Windows.Forms.PictureBox();
            this.kullaniciPic = new System.Windows.Forms.PictureBox();
            this.logoPicbox = new System.Windows.Forms.PictureBox();
            this.girisButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.cikisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parolaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.BackColor = System.Drawing.Color.Transparent;
            this.baslik.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.Color.Brown;
            this.baslik.Location = new System.Drawing.Point(285, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(250, 38);
            this.baslik.TabIndex = 1;
            this.baslik.Text = "FITNESS CENTER";
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(431, 149);
            this.kullaniciAdiTxt.Multiline = true;
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(278, 43);
            this.kullaniciAdiTxt.TabIndex = 2;
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(426, 117);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(142, 29);
            this.kullaniciAdiLabel.TabIndex = 4;
            this.kullaniciAdiLabel.Text = "Kullanıcı Adı:";
            this.kullaniciAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaLabel.ForeColor = System.Drawing.Color.Brown;
            this.parolaLabel.Location = new System.Drawing.Point(426, 239);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(83, 29);
            this.parolaLabel.TabIndex = 5;
            this.parolaLabel.Text = "Parola:";
            // 
            // parolaTxt
            // 
            this.parolaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaTxt.Location = new System.Drawing.Point(431, 271);
            this.parolaTxt.MaxLength = 8;
            this.parolaTxt.Multiline = true;
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.PasswordChar = '*';
            this.parolaTxt.Size = new System.Drawing.Size(278, 43);
            this.parolaTxt.TabIndex = 6;
            // 
            // parolaPic
            // 
            this.parolaPic.Image = global::FitnessCenterApp.Properties.Resources.password_28;
            this.parolaPic.Location = new System.Drawing.Point(705, 271);
            this.parolaPic.Name = "parolaPic";
            this.parolaPic.Size = new System.Drawing.Size(52, 43);
            this.parolaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.parolaPic.TabIndex = 8;
            this.parolaPic.TabStop = false;
            // 
            // kullaniciPic
            // 
            this.kullaniciPic.Image = global::FitnessCenterApp.Properties.Resources.User_icon_BLACK_01;
            this.kullaniciPic.Location = new System.Drawing.Point(705, 149);
            this.kullaniciPic.Name = "kullaniciPic";
            this.kullaniciPic.Size = new System.Drawing.Size(52, 43);
            this.kullaniciPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kullaniciPic.TabIndex = 7;
            this.kullaniciPic.TabStop = false;
            // 
            // logoPicbox
            // 
            this.logoPicbox.Image = global::FitnessCenterApp.Properties.Resources._360_F_331996996_la12k9wp49oTnfyEUWVVHbrXmSyXTfT4_PhotoRoom_png_PhotoRoom;
            this.logoPicbox.Location = new System.Drawing.Point(12, 50);
            this.logoPicbox.Name = "logoPicbox";
            this.logoPicbox.Size = new System.Drawing.Size(359, 322);
            this.logoPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicbox.TabIndex = 0;
            this.logoPicbox.TabStop = false;
            // 
            // girisButon
            // 
            this.girisButon.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.ForeColor = System.Drawing.Color.Brown;
            this.girisButon.Location = new System.Drawing.Point(442, 343);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(104, 46);
            this.girisButon.TabIndex = 9;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // silButon
            // 
            this.silButon.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButon.ForeColor = System.Drawing.Color.Brown;
            this.silButon.Location = new System.Drawing.Point(589, 343);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(104, 46);
            this.silButon.TabIndex = 10;
            this.silButon.Text = "Sil";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // cikisLabel
            // 
            this.cikisLabel.AutoSize = true;
            this.cikisLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisLabel.ForeColor = System.Drawing.Color.Brown;
            this.cikisLabel.Location = new System.Drawing.Point(747, 9);
            this.cikisLabel.Name = "cikisLabel";
            this.cikisLabel.Size = new System.Drawing.Size(41, 43);
            this.cikisLabel.TabIndex = 11;
            this.cikisLabel.Text = "X";
            this.cikisLabel.Click += new System.EventHandler(this.cikisLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikisLabel);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.parolaPic);
            this.Controls.Add(this.kullaniciPic);
            this.Controls.Add(this.parolaTxt);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.kullaniciAdiLabel);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.logoPicbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.parolaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicbox;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.TextBox parolaTxt;
        private System.Windows.Forms.PictureBox kullaniciPic;
        private System.Windows.Forms.PictureBox parolaPic;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Label cikisLabel;
    }
}

