
namespace smtpmailLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToEmail = new System.Windows.Forms.TextBox();
            this.SubjectLine = new System.Windows.Forms.TextBox();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailReporter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToEmail
            // 
            this.ToEmail.Location = new System.Drawing.Point(165, 72);
            this.ToEmail.Multiline = true;
            this.ToEmail.Name = "ToEmail";
            this.ToEmail.Size = new System.Drawing.Size(269, 28);
            this.ToEmail.TabIndex = 0;

            // 
            // SubjectLine
            // 
            this.SubjectLine.Location = new System.Drawing.Point(165, 168);
            this.SubjectLine.Multiline = true;
            this.SubjectLine.Name = "SubjectLine";
            this.SubjectLine.Size = new System.Drawing.Size(387, 27);
            this.SubjectLine.TabIndex = 2;

            // 
            // EmailBody
            // 
            this.EmailBody.Location = new System.Drawing.Point(165, 214);
            this.EmailBody.Multiline = true;
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(387, 154);
            this.EmailBody.TabIndex = 3;

            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(165, 117);
            this.FromEmail.Multiline = true;
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(269, 28);
            this.FromEmail.TabIndex = 4;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Body";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailReporter
            // 
            this.EmailReporter.AutoSize = true;
            this.EmailReporter.Location = new System.Drawing.Point(50, 440);
            this.EmailReporter.Name = "EmailReporter";
            this.EmailReporter.Size = new System.Drawing.Size(0, 20);
            this.EmailReporter.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 492);
            this.Controls.Add(this.EmailReporter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.SubjectLine);
            this.Controls.Add(this.ToEmail);
            this.Name = "Form1";
            this.Text = "Email Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToEmail;
        private System.Windows.Forms.TextBox SubjectLine;
        private System.Windows.Forms.TextBox EmailBody;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmailReporter;
    }
}

