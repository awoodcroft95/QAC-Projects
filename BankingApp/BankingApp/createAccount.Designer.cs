namespace BankingApp
{
    partial class CreateNewAccount
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingsRadButton = new System.Windows.Forms.RadioButton();
            this.currentRadButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.femaleRadButton = new System.Windows.Forms.RadioButton();
            this.maleRadButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingsRadButton);
            this.groupBox1.Controls.Add(this.currentRadButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // savingsRadButton
            // 
            this.savingsRadButton.AutoSize = true;
            this.savingsRadButton.Location = new System.Drawing.Point(7, 44);
            this.savingsRadButton.Name = "savingsRadButton";
            this.savingsRadButton.Size = new System.Drawing.Size(63, 17);
            this.savingsRadButton.TabIndex = 1;
            this.savingsRadButton.TabStop = true;
            this.savingsRadButton.Text = "Savings";
            this.savingsRadButton.UseVisualStyleBackColor = true;
            // 
            // currentRadButton
            // 
            this.currentRadButton.AutoSize = true;
            this.currentRadButton.Location = new System.Drawing.Point(7, 20);
            this.currentRadButton.Name = "currentRadButton";
            this.currentRadButton.Size = new System.Drawing.Size(59, 17);
            this.currentRadButton.TabIndex = 0;
            this.currentRadButton.TabStop = true;
            this.currentRadButton.Text = "Current";
            this.currentRadButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.femaleRadButton);
            this.groupBox2.Controls.Add(this.maleRadButton);
            this.groupBox2.Location = new System.Drawing.Point(138, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // femaleRadButton
            // 
            this.femaleRadButton.AutoSize = true;
            this.femaleRadButton.Location = new System.Drawing.Point(7, 44);
            this.femaleRadButton.Name = "femaleRadButton";
            this.femaleRadButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadButton.TabIndex = 1;
            this.femaleRadButton.TabStop = true;
            this.femaleRadButton.Text = "Female";
            this.femaleRadButton.UseVisualStyleBackColor = true;
            // 
            // maleRadButton
            // 
            this.maleRadButton.AutoSize = true;
            this.maleRadButton.Location = new System.Drawing.Point(7, 20);
            this.maleRadButton.Name = "maleRadButton";
            this.maleRadButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadButton.TabIndex = 0;
            this.maleRadButton.TabStop = true;
            this.maleRadButton.Text = "Male";
            this.maleRadButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateNewAccount";
            this.Text = "Create New Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton savingsRadButton;
        private System.Windows.Forms.RadioButton currentRadButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton femaleRadButton;
        private System.Windows.Forms.RadioButton maleRadButton;
        private System.Windows.Forms.Button button1;
    }
}

