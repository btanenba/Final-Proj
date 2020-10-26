namespace Final_Proj
{
    partial class PayBalanceForm
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
            this.displayBalance = new System.Windows.Forms.Label();
            this.enterPayment = new System.Windows.Forms.TextBox();
            this.submitPayment = new System.Windows.Forms.Button();
            this.displayMessage = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBalance
            // 
            this.displayBalance.AutoSize = true;
            this.displayBalance.Location = new System.Drawing.Point(221, 95);
            this.displayBalance.Name = "displayBalance";
            this.displayBalance.Size = new System.Drawing.Size(0, 17);
            this.displayBalance.TabIndex = 0;
            // 
            // enterPayment
            // 
            this.enterPayment.Location = new System.Drawing.Point(190, 144);
            this.enterPayment.Name = "enterPayment";
            this.enterPayment.Size = new System.Drawing.Size(223, 22);
            this.enterPayment.TabIndex = 1;
            this.enterPayment.Text = "Enter Payment";
            this.enterPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitPayment
            // 
            this.submitPayment.Location = new System.Drawing.Point(463, 144);
            this.submitPayment.Name = "submitPayment";
            this.submitPayment.Size = new System.Drawing.Size(173, 53);
            this.submitPayment.TabIndex = 2;
            this.submitPayment.Text = "Submit";
            this.submitPayment.UseVisualStyleBackColor = true;
            this.submitPayment.Click += new System.EventHandler(this.submitPayment_Click);
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Location = new System.Drawing.Point(201, 256);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(0, 17);
            this.displayMessage.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(182, 301);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(206, 52);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Back to Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(435, 301);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(201, 51);
            this.finish.TabIndex = 5;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // PayBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.submitPayment);
            this.Controls.Add(this.enterPayment);
            this.Controls.Add(this.displayBalance);
            this.Name = "PayBalanceForm";
            this.Text = "PayBalanceForm";
            this.Load += new System.EventHandler(this.PayBalanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayBalance;
        private System.Windows.Forms.TextBox enterPayment;
        private System.Windows.Forms.Button submitPayment;
        private System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button finish;
    }
}