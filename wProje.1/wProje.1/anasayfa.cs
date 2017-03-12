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
    public partial class anasayfa : Form
    {
        DataClasses1DataContext database = new DataClasses1DataContext();
        CUSTOMER cust = new CUSTOMER();

        public anasayfa()
        {
            InitializeComponent();
        }

        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            yeniUye yUye = new yeniUye();
            yUye.MdiParent = this;
            yUye.Show();
        }
        
        private void güncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            guncelleme f3 = new guncelleme();
            f3.MdiParent = this;
            f3.Show();
        }

        private void randevuAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            randevuAyarla f4 = new randevuAyarla();
            f4.MdiParent = this;
            f4.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void epilasyonSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Epilasyon") == true
                        select DATETIME;
            foreach(DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void ciltBakımSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear(); 
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Cilt Bakım") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void sirSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Sir") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void ağdaSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Ağda") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void kaşBıyıkSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Kaş - Bıyık") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void solaryumSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Solaryum") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void masajSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Masaj") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void makyajSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Kalıcı Makyaj") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void manikürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Manikür") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if(d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void pedikürSalonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            var query = from DATETIME in database.DATETIMEs
                        where DATETIME.serviceName.Contains("Pedikür") == true
                        select DATETIME;
            foreach (DATETIME d in query)
            {
                var query1 = from CUSTOMER in database.CUSTOMERs
                             where CUSTOMER.id == d.custId
                             select CUSTOMER;
                foreach (CUSTOMER c in query1)
                    cust = c;
                if (d.date == DateTime.Today.Date)
                {
                    string[] s = new string[3];
                    s[0] = cust.name;
                    s[1] = d.serviceName;
                    s[2] = d.time.ToString();
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.softderm.com");
        }                
    }
}
