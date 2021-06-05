using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace smtpmailLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(""); //YOUR EMAIL-ADDRESS
                msg.To.Add(ToEmail.Text);
                msg.Subject = SubjectLine.Text;
                msg.Body = EmailBody.Text;

                SmtpClient smt = new SmtpClient("mansci-445.uwaterloo.ca", 587);
                smt.EnableSsl = false;

                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = ""; // YOUR USERNAME
                ntcd.Password = ""; // YOUR PASSWORD

                smt.Credentials = ntcd;
                smt.Send(msg);
                MessageBox.Show("Your Mail is sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
