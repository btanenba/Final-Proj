namespace Final_Proj
{
    partial class LoginForm
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.displayError = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(296, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(196, 22);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(294, 155);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(198, 22);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(294, 218);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(197, 40);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // displayError
            // 
            this.displayError.AutoSize = true;
            this.displayError.ForeColor = System.Drawing.Color.Red;
            this.displayError.Location = new System.Drawing.Point(534, 230);
            this.displayError.Name = "displayError";
            this.displayError.Size = new System.Drawing.Size(0, 17);
            this.displayError.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(202, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(205, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.displayError);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label displayError;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

