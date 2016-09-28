namespace WindowsFormsApplication3
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.UserDetails = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Label();
            this.CodeOfConduct = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SecretQuestion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserDetails
            // 
            this.UserDetails.AutoSize = true;
            this.UserDetails.BackColor = System.Drawing.Color.Transparent;
            this.UserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UserDetails.Location = new System.Drawing.Point(12, 68);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(114, 24);
            this.UserDetails.TabIndex = 0;
            this.UserDetails.Text = "User Details:";
            this.UserDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Username.Location = new System.Drawing.Point(40, 117);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(81, 18);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Password.Location = new System.Drawing.Point(40, 162);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 18);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Email.Location = new System.Drawing.Point(40, 207);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(107, 18);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Register.Location = new System.Drawing.Point(12, 18);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(124, 31);
            this.Register.TabIndex = 7;
            this.Register.Text = "Register!";
            this.Register.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CodeOfConduct
            // 
            this.CodeOfConduct.AutoSize = true;
            this.CodeOfConduct.BackColor = System.Drawing.Color.Transparent;
            this.CodeOfConduct.Location = new System.Drawing.Point(43, 362);
            this.CodeOfConduct.Name = "CodeOfConduct";
            this.CodeOfConduct.Size = new System.Drawing.Size(106, 17);
            this.CodeOfConduct.TabIndex = 8;
            this.CodeOfConduct.Text = "Code of Conduct";
            this.CodeOfConduct.UseVisualStyleBackColor = false;
            this.CodeOfConduct.Validating += new System.ComponentModel.CancelEventHandler(this.CodeOfConduct_Validating);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Submit.Location = new System.Drawing.Point(250, 356);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(113, 23);
            this.Submit.TabIndex = 9;
            this.Submit.Text = "Submit!";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // SecretQuestion
            // 
            this.SecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecretQuestion.FormattingEnabled = true;
            this.SecretQuestion.Items.AddRange(new object[] {
            "What is your mothers maiden name?",
            "What is your first pets name?",
            "What is your favourite colour?",
            "What is the model of your first car?"});
            this.SecretQuestion.Location = new System.Drawing.Point(165, 255);
            this.SecretQuestion.Name = "SecretQuestion";
            this.SecretQuestion.Size = new System.Drawing.Size(198, 21);
            this.SecretQuestion.TabIndex = 10;
            this.SecretQuestion.SelectedIndexChanged += new System.EventHandler(this.SecretQuestion_SelectedIndexChanged);
            this.SecretQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.SecretQuestion_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(40, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Secret Question:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(40, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Secret Answer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecretQuestion);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.CodeOfConduct);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UserDetails);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserDetails;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.CheckBox CodeOfConduct;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox SecretQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
    }
}

