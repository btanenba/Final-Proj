namespace Final_Proj
{
    partial class PurchaseForm
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
            this.products = new System.Windows.Forms.CheckedListBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(31, 21);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(498, 395);
            this.products.TabIndex = 0;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(579, 31);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(187, 51);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.products);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox products;
        private System.Windows.Forms.Button purchaseButton;
    }
}