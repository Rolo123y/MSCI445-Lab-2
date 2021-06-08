
namespace SMTP_Email_Lab
{
    partial class Form1
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
            this.To_Email = new System.Windows.Forms.Label();
            this.From_Email = new System.Windows.Forms.Label();
            this.Subject_Email = new System.Windows.Forms.Label();
            this.Body_Email = new System.Windows.Forms.Label();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.ToEmail = new System.Windows.Forms.TextBox();
            this.EmailSubject = new System.Windows.Forms.TextBox();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.Send_Email = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // To_Email
            // 
            this.To_Email.AutoSize = true;
            this.To_Email.Location = new System.Drawing.Point(36, 42);
            this.To_Email.Name = "To_Email";
            this.To_Email.Size = new System.Drawing.Size(25, 17);
            this.To_Email.TabIndex = 0;
            this.To_Email.Text = "To";
            // 
            // From_Email
            // 
            this.From_Email.AutoSize = true;
            this.From_Email.Location = new System.Drawing.Point(36, 81);
            this.From_Email.Name = "From_Email";
            this.From_Email.Size = new System.Drawing.Size(40, 17);
            this.From_Email.TabIndex = 1;
            this.From_Email.Text = "From";
            // 
            // Subject_Email
            // 
            this.Subject_Email.AutoSize = true;
            this.Subject_Email.Location = new System.Drawing.Point(30, 126);
            this.Subject_Email.Name = "Subject_Email";
            this.Subject_Email.Size = new System.Drawing.Size(55, 17);
            this.Subject_Email.TabIndex = 2;
            this.Subject_Email.Text = "Subject";
            // 
            // Body_Email
            // 
            this.Body_Email.AutoSize = true;
            this.Body_Email.Location = new System.Drawing.Point(36, 177);
            this.Body_Email.Name = "Body_Email";
            this.Body_Email.Size = new System.Drawing.Size(40, 17);
            this.Body_Email.TabIndex = 3;
            this.Body_Email.Text = "Body";
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(99, 39);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(271, 22);
            this.FromEmail.TabIndex = 4;
            // 
            // ToEmail
            // 
            this.ToEmail.Location = new System.Drawing.Point(99, 78);
            this.ToEmail.Name = "ToEmail";
            this.ToEmail.Size = new System.Drawing.Size(271, 22);
            this.ToEmail.TabIndex = 5;
            // 
            // EmailSubject
            // 
            this.EmailSubject.Location = new System.Drawing.Point(99, 123);
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.Size = new System.Drawing.Size(326, 22);
            this.EmailSubject.TabIndex = 6;
            // 
            // EmailBody
            // 
            this.EmailBody.Location = new System.Drawing.Point(99, 177);
            this.EmailBody.Multiline = true;
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(326, 150);
            this.EmailBody.TabIndex = 7;
            // 
            // Send_Email
            // 
            this.Send_Email.Location = new System.Drawing.Point(394, 39);
            this.Send_Email.Name = "Send_Email";
            this.Send_Email.Size = new System.Drawing.Size(164, 38);
            this.Send_Email.TabIndex = 8;
            this.Send_Email.Text = "Send";
            this.Send_Email.UseVisualStyleBackColor = true;
            this.Send_Email.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Response
            // 
            this.Response.AutoSize = true;
            this.Response.Location = new System.Drawing.Point(96, 347);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(0, 17);
            this.Response.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(580, 403);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Send_Email);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.EmailSubject);
            this.Controls.Add(this.ToEmail);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.Body_Email);
            this.Controls.Add(this.Subject_Email);
            this.Controls.Add(this.From_Email);
            this.Controls.Add(this.To_Email);
            this.Name = "Form1";
            this.Text = "Email Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label To_Email;
        private System.Windows.Forms.Label From_Email;
        private System.Windows.Forms.Label Subject_Email;
        private System.Windows.Forms.Label Body_Email;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.TextBox ToEmail;
        private System.Windows.Forms.TextBox EmailSubject;
        private System.Windows.Forms.TextBox EmailBody;
        private System.Windows.Forms.Button Send_Email;
        private System.Windows.Forms.Label Response;

        #endregion
    }
}

