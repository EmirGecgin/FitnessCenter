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
    public partial class MemberShow : Form
    {
        public MemberShow()
        {
            InitializeComponent();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            kullaniciTxtbox.Clear();
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

        private void kullaniciTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
