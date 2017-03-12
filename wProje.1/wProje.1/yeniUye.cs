using System;
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
    public partial class yeniUye : Form
    {
        string sName;
        float ucret ;
        char sex;
      
        public yeniUye()
        {
            InitializeComponent();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            CUSTOMER cust=new CUSTOMER();
            SERVICE serv = new SERVICE();

            int query = database.CUSTOMERs.Count();
            
            cust.id = query + 1;
            cust.tcNo = Convert.ToInt64(tcTextBox.Text);
            cust.name = adTextBox.Text;
            cust.bDate = dTarihiDateTimePicker.Value;
            cust.job = meslekTextBox.Text;
            cust.phone = Convert.ToInt64(telTextBox.Text);
            cust.sex = sex;
            cust.regDate = kTarihiDateTimePicker.Value;

            int query1 = database.SERVICEs.Count();
            
            serv.num = query1 + 1;
            serv.custId = query+1;            
            serv.servName = sName;
            serv.empName = comboBox1.GetItemText(comboBox1.SelectedItem);
            serv.price = ucret;

            database.CUSTOMERs.InsertOnSubmit(cust);
            database.SERVICEs.InsertOnSubmit(serv);
            database.SubmitChanges();

            groupBox1.Visible = false;

            MessageBox.Show("Kayıt tamamlandı!");

            tcTextBox.Clear();
            adTextBox.Clear();
            meslekTextBox.Clear();
            telTextBox.Clear();
            textBox1.Clear();
            panel3.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            numericUpDown1.Value = 0;
            aciklamaTextBox.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sName = listBox1.Text;

            if (sName == "Epilasyon" || sName == "Sir" || sName == "Ağda")
                groupBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sName += " " + checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sName += " " + checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sName += " " + checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sName += " " + checkBox4.Text;
        }

        private void indirimliRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ucret = Convert.ToInt32(textBox1.Text);
            panel3.Visible = true;
        }

        private void indirimsizRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
            ucret = Convert.ToInt32(textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = 'K';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = 'E';
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ucret -= ucret*(((float)(numericUpDown1.Value)) / 100);
        }                     
    }
}
