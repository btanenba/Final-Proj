namespace Final_Proj
{
    partial class MainMenu
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
            this.payButton = new System.Windows.Forms.Button();
            this.newPurchaseButton = new System.Windows.Forms.Button();
            this.displayError = new System.Windows.Forms.Label();
            this.checkPurchases = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(293, 48);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(217, 57);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Pay Balance";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // newPurchaseButton
            // 
            this.newPurchaseButton.Location = new System.Drawing.Point(293, 132);
            this.newPurchaseButton.Name = "newPurchaseButton";
            this.newPurchaseButton.Size = new System.Drawing.Size(216, 55);
            this.newPurchaseButton.TabIndex = 1;
            this.newPurchaseButton.Text = "New Purchase";
            this.newPurchaseButton.UseVisualStyleBackColor = true;
            this.newPurchaseButton.Click += new System.EventHandler(this.newPurchaseButton_Click);
            // 
            // displayError
            // 
            this.displayError.AutoSize = true;
            this.displayError.ForeColor = System.Drawing.Color.Red;
            this.displayError.Location = new System.Drawing.Point(531, 151);
            this.displayError.Name = "displayError";
            this.displayError.Size = new System.Drawing.Size(0, 17);
            this.displayError.TabIndex = 2;
            // 
            // checkPurchases
            // 
            this.checkPurchases.Location = new System.Drawing.Point(293, 219);
            this.checkPurchases.Name = "checkPurchases";
            this.checkPurchases.Size = new System.Drawing.Size(216, 52);
            this.checkPurchases.TabIndex = 3;
            this.checkPurchases.Text = "Check Purchases";
            this.checkPurchases.UseVisualStyleBackColor = true;
            this.checkPurchases.Click += new System.EventHandler(this.checkPurchases_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(293, 307);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(218, 52);
            this.finish.TabIndex = 4;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.checkPurchases);
            this.Controls.Add(this.displayError);
            this.Controls.Add(this.newPurchaseButton);
            this.Controls.Add(this.payButton);
            this.Name = "MainMenu";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button newPurchaseButton;
        private System.Windows.Forms.Label displayError;
        private System.Windows.Forms.Button checkPurchases;
        private System.Windows.Forms.Button finish;
    }
}