using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SMTP_Email_Lab
{
    public partial class Form2 : Form
    {
        private String password;
        private String from;
        private String to;
        private String subject;
        private String body;
        private String username;
        private Label EmailReporter;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String Form_from, String Form_to, String Form_subject, String Form_body, String username, Label EmailReporter)
        {
            InitializeComponent();
            this.from = Form_from;
            this.to = Form_to;
            this.subject = Form_subject;
            this.body = Form_body;
            this.username = username;
            this.EmailReporter = EmailReporter;

            //MessageBox.Show(username);
        }

        private void send_Email(String Form_from, String Form_to, String Form_subject, String Form_body, String username, String password)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                var basicCredential = new NetworkCredential(username, password);
                using (MailMessage msg = new MailMessage())
                {

                    smtpClient.Host = "mansci-445.uwaterloo.ca";
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    smtpClient.EnableSsl = false;
                    smtpClient.Port = 587;

                    msg.From = new MailAddress(Form_from);
                    msg.To.Add(Form_to);
                    msg.Subject = Form_subject;
                    msg.Body = Form_body;

                    try
                    {
                        smtpClient.Send(msg);
                        EmailReporter.ForeColor = Color.Green;
                        EmailReporter.Text = "Your Mail is sent!";
                    }
                    catch (Exception ex)
                    {
                        //Error, could not send the message
                        EmailReporter.ForeColor = Color.Red;
                        EmailReporter.Text = "Unable to send your email!";
                    }
                }
            }
            //try
            //{
            //    // Create a new message with the details
            //    MailMessage msg = new MailMessage();
            //    msg.From = new MailAddress(Form_from);
            //    msg.To.Add(Form_to);
            //    msg.Subject = Form_subject;
            //    msg.Body = Form_body;

            //    SmtpClient smt = new SmtpClient("mansci-445.uwaterloo.ca", 587);
            //    smt.EnableSsl = false;

            //    var ntcd = new NetworkCredential(username, password);
            //    //ntcd.UserName = username;
            //    //ntcd.Password = password;

            //    smt.UseDefaultCredentials = false;
                
            //    smt.Credentials = ntcd;
            //    smt.Send(msg);

            //    EmailReporter.ForeColor = Color.Green;
            //    EmailReporter.Text = "Your Mail is sent!";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    EmailReporter.ForeColor = Color.Red;
            //    EmailReporter.Text = "Unable to send your email!";
            //}
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(password);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            // MessageBox.Show(password);
        }


        private void Form2_Load_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button4_click(object sender, EventArgs e)
        {
            
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.password = textBox2.Text;

            send_Email(this.from, this.to, this.subject, this.body, this.username, this.password);
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.password = "MSCI445-Lab4-smtp-Cancelled";

            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
