
namespace SMTP_Email_Lab
{
    partial class Form2
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
            this.Submit_Pass_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Pass_label = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Pass_Button
            // 
            this.Submit_Pass_Button.Location = new System.Drawing.Point(31, 123);
            this.Submit_Pass_Button.Name = "Submit_Pass_Button";
            this.Submit_Pass_Button.Size = new System.Drawing.Size(83, 33);
            this.Submit_Pass_Button.TabIndex = 0;
            this.Submit_Pass_Button.Text = "Submit";
            this.Submit_Pass_Button.UseVisualStyleBackColor = true;
            this.Submit_Pass_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(256, 123);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(83, 33);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Location = new System.Drawing.Point(28, 26);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(184, 17);
            this.Pass_label.TabIndex = 2;
            this.Pass_label.Text = "Please enter your password";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(31, 57);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(308, 22);
            this.Password_Textbox.TabIndex = 3;
            this.Password_Textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Password_Response
            // 
            this.Password_Response.AutoSize = true;
            this.Password_Response.Location = new System.Drawing.Point(28, 91);
            this.Password_Response.Name = "Password_Response";
            this.Password_Response.Size = new System.Drawing.Size(0, 17);
            this.Password_Response.TabIndex = 4;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(362, 181);
            this.Controls.Add(this.Password_Response);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Pass_Button);
            this.Name = "Form2";
            this.Text = "Password Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit_Pass_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label Password_Response;
    }
}