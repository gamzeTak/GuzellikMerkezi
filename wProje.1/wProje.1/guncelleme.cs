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
    public partial class guncelleme : Form
    {
        DataClasses1DataContext database = new DataClasses1DataContext();
        CUSTOMER cust = new CUSTOMER();
        SERVICE serv = new SERVICE();
        string employeeName;        
        string servName;

        public guncelleme()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            if (treeView1.SelectedNode.Index == 0)
                groupBox1.Visible = true;
            else 
                groupBox2.Visible = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Index == 0)
            { 
                if (isimSoyisimTextBox.Text!="")
                    cust.name = isimSoyisimTextBox.Text;
                if (meslekTextBox.Text != "")
                    cust.job = meslekTextBox.Text;
                if (cepTelTextBox.Text != "")
                    cust.phone = Convert.ToInt64(cepTelTextBox.Text);
            }
            else
            {
                int query = database.SERVICEs.Count();
                SERVICE newService = new SERVICE();

                newService.num = query+1;
                newService.custId = cust.id;
                newService.servName = servName;
                newService.empName = employeeName;
                database.SERVICEs.InsertOnSubmit(newService);
            }
            database.SubmitChanges();
            MessageBox.Show("Kayıt tamamlandı!");
            groupBox5.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            tcNoTextBox.Clear();
            isimSoyisimTextBox.Clear();
            meslekTextBox.Clear();
            cepTelTextBox.Clear();
            checkedListBox1.ClearSelected();
        }

        private void araButton_Click(object sender, EventArgs e)
        {  
            var query1 = from CUSTOMER c  in database.CUSTOMERs
                        where c.tcNo == Convert.ToInt64(tcNoTextBox.Text)
                        select c;
            foreach (CUSTOMER c in query1)
                cust = c;

            var query2 = from SERVICE s in database.SERVICEs
                         where s.custId == cust.id
                         select s;
            foreach (SERVICE s in query2)
                serv = s;

            if (query1 == null)
                MessageBox.Show("Böyle bir müşteri bulunmamaktadır!");
            else
                groupBox5.Visible = true;

            tcNoTextBox.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                servName += " " + checkedListBox1.CheckedItems[i].ToString();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var query = from DATETIME d in database.DATETIMEs
                        where d.custId == cust.id
                        select d;

            foreach (DATETIME dt in query)
                database.DATETIMEs.DeleteOnSubmit(dt);

            database.CUSTOMERs.DeleteOnSubmit(cust);
            database.SERVICEs.DeleteOnSubmit(serv);
            database.SubmitChanges();
            tcNoTextBox.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            servName = comboBox1.SelectedItem.ToString();
            if (servName == "Epilasyon" || servName == "Sir" || servName == "Ağda")
                groupBox3.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeName = comboBox2.SelectedItem.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tcNoTextBox.Clear();
            groupBox1.Visible = false;
            groupBox5.Visible = false;
        }
    }
}
