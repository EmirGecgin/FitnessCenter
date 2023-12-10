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
    public partial class PhysicUpdate : Form
    {
        public PhysicUpdate()
        {
            InitializeComponent();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage2 mainPage = new MainPage2();
            mainPage.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            uyeAdiTxt.Clear();
            kgNumericUpDown.ResetText();
            boyNumericUpDown.ResetText();
            yagTxt.Clear();
            gogusNumericUpDown4.ResetText();
            vkiTxt.Clear();
            omuzNumericUpDown5.ResetText();
            kolNumericUpDown6.ResetText();
            bacakNumericUpDown8.ResetText();
            kalcaNumericUpDown7.ResetText();
            belNumericUpDown3.ResetText();
        }

        private void boyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double boyMetre = Convert.ToDouble(boyNumericUpDown.Value/100);
            double vki = Convert.ToDouble(kgNumericUpDown.Value) / Math.Pow(boyMetre, 2);
            vkiTxt.Text= vki.ToString();
        }

        private void PhysicUpdate_Load(object sender, EventArgs e)
        {
            uyeAdiTxt.Clear();
            kgNumericUpDown.ResetText();
            boyNumericUpDown.ResetText();
            yagTxt.Clear();
            gogusNumericUpDown4.ResetText();
            vkiTxt.Clear();
            omuzNumericUpDown5.ResetText();
            kolNumericUpDown6.ResetText();
            bacakNumericUpDown8.ResetText();
            kalcaNumericUpDown7.ResetText();
            belNumericUpDown3.ResetText();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vkiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bacakNumericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void kalcaNumericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void kolNumericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void omuzNumericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gogusNumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void belNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kgNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void araButton_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void yagTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(yagTxt.Text, "[^1-9]"))
            {
                MessageBox.Show("Lütfen Yalnızca Sayı Giriniz!");
                yagTxt.Text = yagTxt.Text.Remove(yagTxt.Text.Length - 1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uyeAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void uyeAdiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
