using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessCenterApp
{
    

    public partial class AddMember : Form
    {
        
        public AddMember()
        {
            InitializeComponent();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            uyeAdiTxtbox.Clear();
            maskedTextBox1.Clear();
            yasTextbox.Clear();
            tutarTxtbox.Clear();
            zamanlamaCmb.ResetText();
            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage2 mainPage = new MainPage2();
            mainPage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void yasTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(yasTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen Yalnızca Sayı Giriniz!");
                yasTextbox.Text = yasTextbox.Text.Remove(yasTextbox.Text.Length - 1);
            }
        }

        private void tutarTxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zamanlamaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(zamanlamaCmb.SelectedIndex == 0)
            {
                tutarTxtbox.Text = "1500";
            }
            else
            {
                tutarTxtbox.Text = "1000";
            }
        }

        private void uyeAdiTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeAdiTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tutarTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
