﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wProje._1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string kullanici = "SOFTDERM";
            string parola = "123456";

            if (kullaniciAdiTextBox.Text == kullanici && parolaTextBox.Text == parola)
            {
                anasayfa f1 = new anasayfa();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış giriş yaptınız!");
        }
    }
}
