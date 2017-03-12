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
    public partial class randevuAyarla : Form
    {
        DataClasses1DataContext database = new DataClasses1DataContext();
        CUSTOMER cust = new CUSTOMER();
        DATETIME dt;
        string currentService = null;

        public randevuAyarla()
        {
            InitializeComponent();
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            var query1 = from CUSTOMER c in database.CUSTOMERs
                         where c.tcNo == Convert.ToInt64(tcTextBox.Text)
                         select c;
            foreach (CUSTOMER c in query1)
                cust = c;

            var query = from SERVICE s in database.SERVICEs
                        where s.custId == cust.id
                        select s;
            foreach (SERVICE s in query)
                islemlerComboBox.Items.Add(s.servName);
        }

        private void islemlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentService = islemlerComboBox.SelectedItem.ToString();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            dt = new DATETIME();
            dt.serviceName = this.currentService;
            int query = database.DATETIMEs.Count();

            dt.num = query + 1;
            dt.custId = cust.id;
            dt.time = timePicker.Value.TimeOfDay;
            dt.date = randevuMonthCalendar.SelectionRange.Start.Date;
            database.DATETIMEs.InsertOnSubmit(dt);
            database.SubmitChanges();
            dt = null;
            tcTextBox.Clear();
            islemlerComboBox.Text = "";
            islemlerComboBox.Items.Clear();
            panel1.Visible = false;                
            islemlerComboBox.SelectedIndex = -1;
        }
    }
}
