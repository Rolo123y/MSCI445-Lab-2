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
        }

        // This submits the details of the password and sends the email.
        private void button3_Click(object sender, EventArgs e)
        {
            this.password = Password_Textbox.Text;

            if (!String.IsNullOrEmpty(this.password))
            {
                send_Email(this.from, this.to, this.subject, this.body, this.username, this.password);
                this.Close();
            }
            else
            {
                Password_Response.ForeColor = Color.Red;
                Password_Response.Text = "Password cannot be null or empty";
            }
        }

        // This closes the password form.
        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // Makes the written password hidden.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password_Textbox.PasswordChar = '*';
        }
    }
}
