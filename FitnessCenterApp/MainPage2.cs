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
    public partial class MainPage2 : Form
    {

        int sayac = 0;
        int timer2 = 0;
        private int currentIndex = 0;
        Image[] pictureDizi = { Image.FromFile("C:\\Users\\copro\\OneDrive\\Masaüstü\\istanbul-spor-salonu-0-1500x500.jpg"), Image.FromFile("C:\\Users\\copro\\OneDrive\\Masaüstü\\ankara-spor-salonu-1-1500x500.jpg"),Image.FromFile("C:\\Users\\copro\\OneDrive\\Masaüstü\\macfit_cadde_spor_salonu_13.jpg") };
        
        public MainPage2()
        {

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainPage2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tarihStatusStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainPage2_Load(object sender, EventArgs e)
        {
            DateTime dateTime;
            dateTime = DateTime.Now;
            tarihStatusStripLabel.Text = dateTime.ToString(); 
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void uyeEkleButton_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
            
            
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            UpdateDelete updateDelete = new UpdateDelete();
            updateDelete.Show();
            this.Hide();
        }

        private void uyeListeleButton_Click(object sender, EventArgs e)
        {
            MemberShow memberShow = new MemberShow();
            memberShow.Show();
            this.Hide();
        }

        private void odemeButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void olcumButton_Click(object sender, EventArgs e)
        {
            PhysicUpdate physicUpdate = new PhysicUpdate();
            physicUpdate.Show();
            this.Hide();
        }

        private void cikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihStatusStripLabel.Text = DateTime.Now.ToString();
            

            sayac++;
            if(sayac == 5)
            {
                pictureBox1.Image = pictureDizi[currentIndex];
                currentIndex = (currentIndex + 1) % pictureDizi.Length;
                sayac = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}
