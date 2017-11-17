namespace BankingApp
{
    partial class Deposit
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
            this.accNoBox = new System.Windows.Forms.TextBox();
            this.accNo = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountTypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // accNoBox
            // 
            this.accNoBox.Location = new System.Drawing.Point(123, 45);
            this.accNoBox.Name = "accNoBox";
            this.accNoBox.Size = new System.Drawing.Size(100, 20);
            this.accNoBox.TabIndex = 0;
            this.accNoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchConfirm);
            // 
            // accNo
            // 
            this.accNo.AutoSize = true;
            this.accNo.Location = new System.Drawing.Point(27, 48);
            this.accNo.Name = "accNo";
            this.accNo.Size = new System.Drawing.Size(90, 13);
            this.accNo.TabIndex = 1;
            this.accNo.Text = "Account Number:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(229, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchConfirm);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.balanceBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.genderBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.accountTypeBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(15, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 215);
            this.panel1.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(107, 172);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Deposit Amount:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(107, 146);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(108, 119);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Balance:";
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(108, 92);
            this.genderBox.Name = "genderBox";
            this.genderBox.ReadOnly = true;
            this.genderBox.Size = new System.Drawing.Size(100, 20);
            this.genderBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // accountTypeBox
            // 
            this.accountTypeBox.Location = new System.Drawing.Point(108, 66);
            this.accountTypeBox.Name = "accountTypeBox";
            this.accountTypeBox.ReadOnly = true;
            this.accountTypeBox.Size = new System.Drawing.Size(100, 20);
            this.accountTypeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(108, 38);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.accNo);
            this.Controls.Add(this.accNoBox);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accNoBox;
        private System.Windows.Forms.Label accNo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
    }
}