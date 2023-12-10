namespace FitnessCenterApp
{
    partial class MemberShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberShow));
            this.uyeleriListeleLabel = new System.Windows.Forms.Label();
            this.baslikLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciTxtbox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeleriListeleLabel
            // 
            this.uyeleriListeleLabel.AutoSize = true;
            this.uyeleriListeleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeleriListeleLabel.ForeColor = System.Drawing.Color.Brown;
            this.uyeleriListeleLabel.Location = new System.Drawing.Point(329, 47);
            this.uyeleriListeleLabel.Name = "uyeleriListeleLabel";
            this.uyeleriListeleLabel.Size = new System.Drawing.Size(197, 38);
            this.uyeleriListeleLabel.TabIndex = 5;
            this.uyeleriListeleLabel.Text = "Üyeleri Listele";
            // 
            // baslikLabel
            // 
            this.baslikLabel.AutoSize = true;
            this.baslikLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikLabel.ForeColor = System.Drawing.Color.Brown;
            this.baslikLabel.Location = new System.Drawing.Point(308, 9);
            this.baslikLabel.Name = "baslikLabel";
            this.baslikLabel.Size = new System.Drawing.Size(250, 38);
            this.baslikLabel.TabIndex = 4;
            this.baslikLabel.Text = "FITNESS CENTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(807, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 337);
            this.dataGridView1.TabIndex = 41;
            // 
            // kullaniciTxtbox
            // 
            this.kullaniciTxtbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTxtbox.Location = new System.Drawing.Point(229, 108);
            this.kullaniciTxtbox.Multiline = true;
            this.kullaniciTxtbox.Name = "kullaniciTxtbox";
            this.kullaniciTxtbox.Size = new System.Drawing.Size(163, 35);
            this.kullaniciTxtbox.TabIndex = 42;
            this.kullaniciTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciTxtbox_KeyPress);
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.ForeColor = System.Drawing.Color.Brown;
            this.araButton.Location = new System.Drawing.Point(413, 108);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(80, 35);
            this.araButton.TabIndex = 43;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            // 
            // temizleButton
            // 
            this.temizleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.Brown;
            this.temizleButton.Location = new System.Drawing.Point(499, 108);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(109, 35);
            this.temizleButton.TabIndex = 44;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.Color.Brown;
            this.geriButton.Location = new System.Drawing.Point(368, 492);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(113, 38);
            this.geriButton.TabIndex = 45;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FitnessCenterApp.Properties.Resources._360_F_331996996_la12k9wp49oTnfyEUWVVHbrXmSyXTfT4_PhotoRoom_png_PhotoRoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // MemberShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(850, 542);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.kullaniciTxtbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uyeleriListeleLabel);
            this.Controls.Add(this.baslikLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberShow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uyeleriListeleLabel;
        private System.Windows.Forms.Label baslikLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kullaniciTxtbox;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}