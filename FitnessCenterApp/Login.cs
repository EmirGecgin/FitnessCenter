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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            if(kullaniciAdiTxt.Text == "admin" && parolaTxt.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı!");
                MainPage2 mainPage = new MainPage2();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!");
            }
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            kullaniciAdiTxt.Clear();
            parolaTxt.Clear();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void cikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
