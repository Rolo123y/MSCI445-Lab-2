using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace smtpmailLab
{
    public partial class Form2 : Form
    {
        private String password;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.password = textBox1.Text;
            
            this.Close();
            MessageBox.Show(password);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.password = "MSCI445-Lab4-smtp-Cancelled";
            
            this.Close();
            MessageBox.Show(password);
        }

        public String getPassword()
        {
            return this.password;
        }

    }
}
