namespace WindowsFormsApplication3
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cSI3304_Assignment_2DataSet = new WindowsFormsApplication3.CSI3304_Assignment_2DataSet();
            this.cSI3304Assignment2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumerTableAdapter = new WindowsFormsApplication3.CSI3304_Assignment_2DataSetTableAdapters.ConsumerTableAdapter();
            this.consumerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cSI3304_Assignment_2DataSet1 = new WindowsFormsApplication3.CSI3304_Assignment_2DataSet1();
            this.cSI3304Assignment2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.consumerTableAdapter1 = new WindowsFormsApplication3.CSI3304_Assignment_2DataSet1TableAdapters.ConsumerTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SecretQuestion = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UserDetails = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consumerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304_Assignment_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304Assignment2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304_Assignment_2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304Assignment2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(45, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users";
            // 
            // cSI3304_Assignment_2DataSet
            // 
            this.cSI3304_Assignment_2DataSet.DataSetName = "CSI3304_Assignment_2DataSet";
            this.cSI3304_Assignment_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSI3304Assignment2DataSetBindingSource
            // 
            this.cSI3304Assignment2DataSetBindingSource.DataSource = this.cSI3304_Assignment_2DataSet;
            this.cSI3304Assignment2DataSetBindingSource.Position = 0;
            // 
            // consumerBindingSource
            // 
            this.consumerBindingSource.DataMember = "Consumer";
            this.consumerBindingSource.DataSource = this.cSI3304Assignment2DataSetBindingSource;
            // 
            // consumerTableAdapter
            // 
            this.consumerTableAdapter.ClearBeforeFill = true;
            // 
            // consumerBindingSource1
            // 
            this.consumerBindingSource1.DataMember = "Consumer";
            this.consumerBindingSource1.DataSource = this.cSI3304Assignment2DataSetBindingSource;
            // 
            // cSI3304_Assignment_2DataSet1
            // 
            this.cSI3304_Assignment_2DataSet1.DataSetName = "CSI3304_Assignment_2DataSet1";
            this.cSI3304_Assignment_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSI3304Assignment2DataSet1BindingSource
            // 
            this.cSI3304Assignment2DataSet1BindingSource.DataSource = this.cSI3304_Assignment_2DataSet1;
            this.cSI3304Assignment2DataSet1BindingSource.Position = 0;
            // 
            // consumerBindingSource2
            // 
            this.consumerBindingSource2.DataMember = "Consumer";
            this.consumerBindingSource2.DataSource = this.cSI3304Assignment2DataSet1BindingSource;
            // 
            // consumerTableAdapter1
            // 
            this.consumerTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 308);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(101, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Secret Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(101, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Secret Question:";
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
            this.SecretQuestion.Location = new System.Drawing.Point(226, 254);
            this.SecretQuestion.Name = "SecretQuestion";
            this.SecretQuestion.Size = new System.Drawing.Size(198, 21);
            this.SecretQuestion.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Email.Location = new System.Drawing.Point(101, 206);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(107, 18);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email Address:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Password.Location = new System.Drawing.Point(101, 161);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 18);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Username.Location = new System.Drawing.Point(101, 116);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(81, 18);
            this.Username.TabIndex = 15;
            this.Username.Text = "Username:";
            // 
            // UserDetails
            // 
            this.UserDetails.AutoSize = true;
            this.UserDetails.BackColor = System.Drawing.Color.Transparent;
            this.UserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UserDetails.Location = new System.Drawing.Point(73, 67);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(114, 24);
            this.UserDetails.TabIndex = 14;
            this.UserDetails.Text = "User Details:";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Submit.Location = new System.Drawing.Point(514, 113);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(113, 23);
            this.Submit.TabIndex = 25;
            this.Submit.Text = "Add";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(514, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.secretQuestionDataGridViewTextBoxColumn,
            this.secretAnswerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consumerBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(104, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // consumerBindingSource3
            // 
            this.consumerBindingSource3.DataMember = "Consumer";
            this.consumerBindingSource3.DataSource = this.cSI3304Assignment2DataSet1BindingSource;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // secretQuestionDataGridViewTextBoxColumn
            // 
            this.secretQuestionDataGridViewTextBoxColumn.DataPropertyName = "Secret_Question";
            this.secretQuestionDataGridViewTextBoxColumn.HeaderText = "Secret_Question";
            this.secretQuestionDataGridViewTextBoxColumn.Name = "secretQuestionDataGridViewTextBoxColumn";
            this.secretQuestionDataGridViewTextBoxColumn.Width = 150;
            // 
            // secretAnswerDataGridViewTextBoxColumn
            // 
            this.secretAnswerDataGridViewTextBoxColumn.DataPropertyName = "Secret_Answer";
            this.secretAnswerDataGridViewTextBoxColumn.HeaderText = "Secret_Answer";
            this.secretAnswerDataGridViewTextBoxColumn.Name = "secretAnswerDataGridViewTextBoxColumn";
            this.secretAnswerDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecretQuestion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304_Assignment_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304Assignment2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304_Assignment_2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSI3304Assignment2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cSI3304Assignment2DataSetBindingSource;
        private CSI3304_Assignment_2DataSet cSI3304_Assignment_2DataSet;
        private System.Windows.Forms.BindingSource consumerBindingSource;
        private CSI3304_Assignment_2DataSetTableAdapters.ConsumerTableAdapter consumerTableAdapter;
        private System.Windows.Forms.BindingSource consumerBindingSource1;
        private System.Windows.Forms.BindingSource cSI3304Assignment2DataSet1BindingSource;
        private CSI3304_Assignment_2DataSet1 cSI3304_Assignment_2DataSet1;
        private System.Windows.Forms.BindingSource consumerBindingSource2;
        private CSI3304_Assignment_2DataSet1TableAdapters.ConsumerTableAdapter consumerTableAdapter1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SecretQuestion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label UserDetails;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretQuestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consumerBindingSource3;
    }
}