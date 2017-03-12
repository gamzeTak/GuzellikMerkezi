namespace wProje._1
{
    partial class randevuAyarla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.islemlerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.randevuMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(111, 24);
            this.tcTextBox.MaxLength = 11;
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(100, 20);
            this.tcTextBox.TabIndex = 1;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(231, 22);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(75, 23);
            this.araButton.TabIndex = 2;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.kaydetButton);
            this.panel1.Controls.Add(this.islemlerComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.randevuMonthCalendar);
            this.panel1.Location = new System.Drawing.Point(34, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 272);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(305, 97);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(93, 20);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = new System.DateTime(2016, 12, 26, 16, 46, 0, 0);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(323, 157);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 3;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // islemlerComboBox
            // 
            this.islemlerComboBox.FormattingEnabled = true;
            this.islemlerComboBox.Location = new System.Drawing.Point(111, 30);
            this.islemlerComboBox.Name = "islemlerComboBox";
            this.islemlerComboBox.Size = new System.Drawing.Size(121, 21);
            this.islemlerComboBox.TabIndex = 2;
            this.islemlerComboBox.SelectedIndexChanged += new System.EventHandler(this.islemlerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlemler";
            // 
            // randevuMonthCalendar
            // 
            this.randevuMonthCalendar.Location = new System.Drawing.Point(27, 75);
            this.randevuMonthCalendar.MinDate = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            this.randevuMonthCalendar.Name = "randevuMonthCalendar";
            this.randevuMonthCalendar.TabIndex = 0;
            // 
            // randevuAyarla
            // 
            this.AcceptButton = this.araButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(595, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.label1);
            this.Name = "randevuAyarla";
            this.Text = "Randevu Ayarla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar randevuMonthCalendar;
        private System.Windows.Forms.ComboBox islemlerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.DateTimePicker timePicker;

    }
}