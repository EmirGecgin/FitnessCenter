namespace FitnessCenterApp
{
    partial class MainPage2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikisLabel = new System.Windows.Forms.Label();
            this.uyeEkleButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.olcumButton = new System.Windows.Forms.Button();
            this.uyeListeleButton = new System.Windows.Forms.Button();
            this.odemeButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tarihStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPicbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cikisLabel);
            this.panel1.Controls.Add(this.logoPicbox);
            this.panel1.Controls.Add(this.uyeEkleButton);
            this.panel1.Controls.Add(this.guncelleButton);
            this.panel1.Controls.Add(this.olcumButton);
            this.panel1.Controls.Add(this.uyeListeleButton);
            this.panel1.Controls.Add(this.odemeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 81);
            this.panel1.TabIndex = 8;
            // 
            // cikisLabel
            // 
            this.cikisLabel.AutoSize = true;
            this.cikisLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisLabel.ForeColor = System.Drawing.Color.Brown;
            this.cikisLabel.Location = new System.Drawing.Point(1024, 18);
            this.cikisLabel.Name = "cikisLabel";
            this.cikisLabel.Size = new System.Drawing.Size(41, 43);
            this.cikisLabel.TabIndex = 8;
            this.cikisLabel.Text = "X";
            this.cikisLabel.Click += new System.EventHandler(this.cikisLabel_Click);
            // 
            // uyeEkleButton
            // 
            this.uyeEkleButton.BackColor = System.Drawing.Color.Transparent;
            this.uyeEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uyeEkleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeEkleButton.ForeColor = System.Drawing.Color.Brown;
            this.uyeEkleButton.Location = new System.Drawing.Point(190, 18);
            this.uyeEkleButton.Name = "uyeEkleButton";
            this.uyeEkleButton.Size = new System.Drawing.Size(124, 48);
            this.uyeEkleButton.TabIndex = 1;
            this.uyeEkleButton.Text = "Üye Ekle";
            this.uyeEkleButton.UseVisualStyleBackColor = false;
            this.uyeEkleButton.Click += new System.EventHandler(this.uyeEkleButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackColor = System.Drawing.Color.White;
            this.guncelleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.guncelleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.ForeColor = System.Drawing.Color.Brown;
            this.guncelleButton.Location = new System.Drawing.Point(349, 18);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(124, 48);
            this.guncelleButton.TabIndex = 2;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = false;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // olcumButton
            // 
            this.olcumButton.BackColor = System.Drawing.Color.White;
            this.olcumButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.olcumButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olcumButton.ForeColor = System.Drawing.Color.Brown;
            this.olcumButton.Location = new System.Drawing.Point(826, 18);
            this.olcumButton.Name = "olcumButton";
            this.olcumButton.Size = new System.Drawing.Size(124, 48);
            this.olcumButton.TabIndex = 5;
            this.olcumButton.Text = "Ölçüm";
            this.olcumButton.UseVisualStyleBackColor = false;
            this.olcumButton.Click += new System.EventHandler(this.olcumButton_Click);
            // 
            // uyeListeleButton
            // 
            this.uyeListeleButton.BackColor = System.Drawing.Color.White;
            this.uyeListeleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uyeListeleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeListeleButton.ForeColor = System.Drawing.Color.Brown;
            this.uyeListeleButton.Location = new System.Drawing.Point(512, 18);
            this.uyeListeleButton.Name = "uyeListeleButton";
            this.uyeListeleButton.Size = new System.Drawing.Size(124, 48);
            this.uyeListeleButton.TabIndex = 3;
            this.uyeListeleButton.Text = "Üye Listele";
            this.uyeListeleButton.UseVisualStyleBackColor = false;
            this.uyeListeleButton.Click += new System.EventHandler(this.uyeListeleButton_Click);
            // 
            // odemeButton
            // 
            this.odemeButton.BackColor = System.Drawing.Color.White;
            this.odemeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.odemeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeButton.ForeColor = System.Drawing.Color.Brown;
            this.odemeButton.Location = new System.Drawing.Point(672, 18);
            this.odemeButton.Name = "odemeButton";
            this.odemeButton.Size = new System.Drawing.Size(124, 48);
            this.odemeButton.TabIndex = 4;
            this.odemeButton.Text = "Ödeme";
            this.odemeButton.UseVisualStyleBackColor = false;
            this.odemeButton.Click += new System.EventHandler(this.odemeButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihStatusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1086, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tarihStatusStripLabel
            // 
            this.tarihStatusStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.tarihStatusStripLabel.ForeColor = System.Drawing.Color.Brown;
            this.tarihStatusStripLabel.Name = "tarihStatusStripLabel";
            this.tarihStatusStripLabel.Size = new System.Drawing.Size(151, 20);
            this.tarihStatusStripLabel.Text = "toolStripStatusLabel1";
            this.tarihStatusStripLabel.Click += new System.EventHandler(this.tarihStatusStripLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenterApp.Properties.Resources.ankara_spor_salonu_1_1500x500;
            this.pictureBox1.Location = new System.Drawing.Point(0, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logoPicbox
            // 
            this.logoPicbox.Image = global::FitnessCenterApp.Properties.Resources._360_F_331996996_la12k9wp49oTnfyEUWVVHbrXmSyXTfT4_PhotoRoom_png_PhotoRoom;
            this.logoPicbox.Location = new System.Drawing.Point(0, -19);
            this.logoPicbox.Name = "logoPicbox";
            this.logoPicbox.Size = new System.Drawing.Size(157, 122);
            this.logoPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicbox.TabIndex = 7;
            this.logoPicbox.TabStop = false;
            // 
            // MainPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1086, 535);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage2_FormClosing);
            this.Load += new System.EventHandler(this.MainPage2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPicbox;
        private System.Windows.Forms.Button uyeEkleButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button olcumButton;
        private System.Windows.Forms.Button uyeListeleButton;
        private System.Windows.Forms.Button odemeButton;
        private System.Windows.Forms.Label cikisLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tarihStatusStripLabel;
        private System.Windows.Forms.Timer timer1;
    }
}