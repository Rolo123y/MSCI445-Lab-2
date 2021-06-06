
namespace smtpmailLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmit = new System.Windows.Forms.Button();
            this.PasswordCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(67, 146);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(371, 39);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // PasswordSubmit
            // 
            this.PasswordSubmit.Location = new System.Drawing.Point(67, 299);
            this.PasswordSubmit.Name = "PasswordSubmit";
            this.PasswordSubmit.Size = new System.Drawing.Size(150, 46);
            this.PasswordSubmit.TabIndex = 2;
            this.PasswordSubmit.Text = "Submit";
            this.PasswordSubmit.UseVisualStyleBackColor = true;
            this.PasswordSubmit.Click += new System.EventHandler(this.PasswordSubmit_Click);
            // 
            // PasswordCancel
            // 
            this.PasswordCancel.Location = new System.Drawing.Point(347, 299);
            this.PasswordCancel.Name = "PasswordCancel";
            this.PasswordCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordCancel.Size = new System.Drawing.Size(150, 46);
            this.PasswordCancel.TabIndex = 3;
            this.PasswordCancel.Text = "Cancel";
            this.PasswordCancel.UseVisualStyleBackColor = true;
            this.PasswordCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordCancel);
            this.Controls.Add(this.PasswordSubmit);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button PasswordSubmit;
        private System.Windows.Forms.Button PasswordCancel;
    }
}