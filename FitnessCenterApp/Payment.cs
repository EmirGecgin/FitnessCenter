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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            uyeAdiSoyadiTxt.Clear();
            tutarTxt.Clear();
            odemeDateTimePicker.ResetText();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage2 mainPage = new MainPage2();
            mainPage.Show();
            this.Hide();
        }

        private void cikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void odeButton_Click(object sender, EventArgs e)
        {

        }

        private void uyeAdiSoyadiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tutarTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tutarTxt.Text, "[^1-9]"))
            {
                MessageBox.Show("Lütfen Yalnızca Sayı Giriniz!");
                tutarTxt.Text = tutarTxt.Text.Remove(tutarTxt.Text.Length - 1);
            }
        }
    }
}
