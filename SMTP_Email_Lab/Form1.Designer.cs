
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.ToEmail = new System.Windows.Forms.TextBox();
            this.EmailSubject = new System.Windows.Forms.TextBox();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(171, 36);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(100, 31);
            this.FromEmail.TabIndex = 4;
            this.FromEmail.TextChanged += new System.EventHandler(this.FromEmail_TextChanged);
            // 
            // ToEmail
            // 
            this.ToEmail.Location = new System.Drawing.Point(171, 78);
            this.ToEmail.Name = "ToEmail";
            this.ToEmail.Size = new System.Drawing.Size(100, 31);
            this.ToEmail.TabIndex = 5;
            // 
            // EmailSubject
            // 
            this.EmailSubject.Location = new System.Drawing.Point(171, 163);
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.Size = new System.Drawing.Size(100, 31);
            this.EmailSubject.TabIndex = 6;
            // 
            // EmailBody
            // 
            this.EmailBody.Location = new System.Drawing.Point(171, 234);
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(100, 31);
            this.EmailBody.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Response
            // 
            this.Response.AutoSize = true;
            this.Response.Location = new System.Drawing.Point(175, 310);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(0, 25);
            this.Response.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(580, 373);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.EmailSubject);
            this.Controls.Add(this.ToEmail);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.TextBox ToEmail;
        private System.Windows.Forms.TextBox EmailSubject;
        private System.Windows.Forms.TextBox EmailBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Response;

        #endregion

        //private System.Windows.Forms.BindingSource bindingSource1;
        //private System.Windows.Forms.TextBox EmailBody;
        //private System.Windows.Forms.TextBox SubjectLine;
        //private System.Windows.Forms.TextBox FromEmail;
        //private System.Windows.Forms.TextBox ToEmail;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Button button1;
    }
}

