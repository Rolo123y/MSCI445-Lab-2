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

namespace SMTP_Email_Lab
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

        // Send button is clicked on the Email Form.
        private void button1_Click_1(object sender, EventArgs e)
        {
            String Form_from = FromEmail.Text;
            String Form_to = ToEmail.Text;
            String Form_subject = EmailSubject.Text;
            String Form_body = EmailBody.Text;
            String username = Form_from.Split('@')[0];

            try
            {
                // Check to see if the To and From emails are real.
                MailAddress m = new MailAddress(Form_from);
                MailAddress m1 = new MailAddress(Form_to);

                // Check if uwaterloo email is used
                if (Form_from.Contains("@uwaterloo.ca")) {
                    if (Form_to.Contains("@uwaterloo.ca"))
                    {
                        // Subject and Body cannot be empty
                        if ((String.IsNullOrEmpty(Form_subject) == false) & (String.IsNullOrEmpty(Form_body) == false))
                        {
                            Response.Text = "";
                            Form2 frm2 = new Form2(Form_from, Form_to, Form_subject, Form_body, username, Response);
                            frm2.Show();
                        }
                        else
                        {
                            Response.ForeColor = Color.Red;
                            Response.Text = "Please enter the subject and/or body; they cannot be empty";
                        }
                    }
                    else
                    {
                        Response.ForeColor = Color.Red;
                        Response.Text = "You can only send to @uwaterloo.ca email address";
                    }
                }
                else
                {
                    Response.ForeColor = Color.Red;
                    Response.Text = "Please enter a @uwaterloo.ca email address";
                }
            }
            catch (FormatException)
            {
                Response.ForeColor = Color.Red;
                Response.Text = "Invalid email";
            }
        }
    }
}
