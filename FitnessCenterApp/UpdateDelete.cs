using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenterApp
{

    public partial class UpdateDelete : Form
    {
        
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            uyeAdiSoyadiTxt.Clear();
            telMaskedTextBox.Clear();
            erkekRadioButton.Checked = false;
            kadinRadioButton.Checked = false;
            aylikTutarTxt.Clear();
            yasTxt.Clear();
            zamanlamaComboBox.ResetText();

        }

        private void cikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage2 mainPage = new MainPage2();
            mainPage.Show();
            this.Hide();
        }

        private void yasTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(yasTxt.Text, "[^1-9]"))
            {
                MessageBox.Show("Lütfen Yalnızca Sayı Giriniz!");
                yasTxt.Text = yasTxt.Text.Remove(yasTxt.Text.Length - 1);
            }
        }

        private void uyeAdiSoyadiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void zamanlamaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zamanlamaComboBox.SelectedIndex == 0)
            {
                aylikTutarTxt.Text = "1500";
            }
            else
            {
                aylikTutarTxt.Text = "1000";
            }
        }

        private void aylikTutarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
