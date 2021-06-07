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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            // Get all the relevant data from the form
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FromEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Form_from = FromEmail.Text;
            
            String Form_to = ToEmail.Text;
            // check validity
            String Form_subject = EmailSubject.Text;
            String Form_body = EmailBody.Text;
            String username = Form_from.Split('@')[0]; // YOUR USERNAME

            try
            {
                MailAddress m = new MailAddress(Form_from);
                MailAddress m1 = new MailAddress(Form_to);


                // check if uwaterloo email is used
                if (Form_from.Contains("@uwaterloo.ca")) {
                    if (Form_to.Contains("@uwaterloo.ca"))
                    {
                        if ((String.IsNullOrEmpty(Form_subject) == false) & (String.IsNullOrEmpty(Form_body) == false))
                        {
                            Form2 frm2 = new Form2(Form_from, Form_to, Form_subject, Form_body, username, Response);
                            frm2.Show();
                        }

                        else
                        {
                            MessageBox.Show("Please enter the subject and/or body");
                        }

                    }

                    else
                    {
                        MessageBox.Show("You can only send to @uwaterloo.ca email address");
                    }
                    
                }
                    

                else
                {
                    MessageBox.Show("Please enter a uwaterloo.ca email address");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email");
            }


        }

    
    }
}
