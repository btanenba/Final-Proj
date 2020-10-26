namespace Final_Proj
{
    partial class PurchasesForm
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
            this.allPurchasesButton = new System.Windows.Forms.Button();
            this.dateRangeButton = new System.Windows.Forms.Button();
            this.priceRangeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.displayPurchases = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.to2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allPurchasesButton
            // 
            this.allPurchasesButton.Location = new System.Drawing.Point(566, 69);
            this.allPurchasesButton.Name = "allPurchasesButton";
            this.allPurchasesButton.Size = new System.Drawing.Size(185, 50);
            this.allPurchasesButton.TabIndex = 0;
            this.allPurchasesButton.Text = "See All Purchases";
            this.allPurchasesButton.UseVisualStyleBackColor = true;
            this.allPurchasesButton.Click += new System.EventHandler(this.allPurchasesButton_Click);
            // 
            // dateRangeButton
            // 
            this.dateRangeButton.Location = new System.Drawing.Point(566, 137);
            this.dateRangeButton.Name = "dateRangeButton";
            this.dateRangeButton.Size = new System.Drawing.Size(185, 50);
            this.dateRangeButton.TabIndex = 1;
            this.dateRangeButton.Text = "See Purchases in Specified Date Range";
            this.dateRangeButton.UseVisualStyleBackColor = true;
            this.dateRangeButton.Click += new System.EventHandler(this.dateRangeButton_Click);
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.Location = new System.Drawing.Point(566, 198);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(183, 50);
            this.priceRangeButton.TabIndex = 2;
            this.priceRangeButton.Text = "See Purchases in Specified Price range";
            this.priceRangeButton.UseVisualStyleBackColor = true;
            this.priceRangeButton.Click += new System.EventHandler(this.priceRangeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 3;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(273, 215);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(20, 17);
            this.to.TabIndex = 4;
            this.to.Text = "to";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 5;
            // 
            // displayPurchases
            // 
            this.displayPurchases.AutoSize = true;
            this.displayPurchases.Location = new System.Drawing.Point(86, 264);
            this.displayPurchases.Name = "displayPurchases";
            this.displayPurchases.Size = new System.Drawing.Size(0, 17);
            this.displayPurchases.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // to2
            // 
            this.to2.AutoSize = true;
            this.to2.Location = new System.Drawing.Point(273, 154);
            this.to2.Name = "to2";
            this.to2.Size = new System.Drawing.Size(20, 17);
            this.to2.TabIndex = 8;
            this.to2.Text = "to";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(332, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(566, 273);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(182, 50);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "Back to Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.to2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.displayPurchases);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.to);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priceRangeButton);
            this.Controls.Add(this.dateRangeButton);
            this.Controls.Add(this.allPurchasesButton);
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allPurchasesButton;
        private System.Windows.Forms.Button dateRangeButton;
        private System.Windows.Forms.Button priceRangeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label displayPurchases;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label to2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button mainMenu;
    }
}