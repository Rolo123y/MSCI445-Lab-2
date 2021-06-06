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

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}
        private String GetPassword(String Userid)
        {
                Form2 secondForm = new Form2();
                secondForm.Show();
                String password = secondForm.getPassword();
                return password;
        }

        private void send_Email(String Form_from, String Form_to, String Form_subject, String Form_body, String username, String password)
        {
            if (password != "MSCI445-Lab4-smtp-Cancelled")
            {
                try
                {
                    // Create a new message with the details
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(Form_from);
                    msg.To.Add(Form_to);
                    msg.Subject = Form_subject;
                    msg.Body = Form_body;

                    SmtpClient smt = new SmtpClient("mansci-445.uwaterloo.ca", 587);
                    smt.EnableSsl = false;

                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = username;
                    ntcd.Password = password;

                    smt.Credentials = ntcd;
                    smt.Send(msg);

                    EmailReporter.ForeColor = Color.Green;
                    EmailReporter.Text = "Your Mail is sent: " + password;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    EmailReporter.Text = "Unable to send your email: " + password;
                }
            }
            else
            {
                EmailReporter.Text = "Password entry cancelled! " + password;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get all the relevant data from the form
            String Form_from = FromEmail.Text;
            String Form_to = ToEmail.Text;
            String Form_subject = SubjectLine.Text;
            String Form_body = EmailBody.Text;
            String username = "r2nasim"; // YOUR USERNAME
            String password = GetPassword(username);

            send_Email(Form_from, Form_to, Form_subject, Form_body, username, password);

        }
    }
}
