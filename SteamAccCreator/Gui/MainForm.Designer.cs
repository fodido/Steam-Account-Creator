namespace SteamAccCreator.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.nmbrAmountAccounts = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkRandomMail = new System.Windows.Forms.CheckBox();
            this.pnlSettings = new System.Windows.Forms.GroupBox();
            this.chkWriteIntoFile = new System.Windows.Forms.CheckBox();
            this.chkAutoVerifyMail = new System.Windows.Forms.CheckBox();
            this.chkRandomAlias = new System.Windows.Forms.CheckBox();
            this.chkRandomPass = new System.Windows.Forms.CheckBox();
            this.pnlCreation = new System.Windows.Forms.GroupBox();
            this.dataAccounts = new System.Windows.Forms.DataGridView();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAmountAccounts)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.pnlCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(94, 97);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(206, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(94, 45);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(206, 20);
            this.txtAlias.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(94, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(206, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(34, 48);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(32, 13);
            this.lblAlias.TabIndex = 12;
            this.lblAlias.Text = "Alias:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(34, 74);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(33, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Pass:";
            // 
            // nmbrAmountAccounts
            // 
            this.nmbrAmountAccounts.Location = new System.Drawing.Point(97, 19);
            this.nmbrAmountAccounts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbrAmountAccounts.Name = "nmbrAmountAccounts";
            this.nmbrAmountAccounts.Size = new System.Drawing.Size(41, 20);
            this.nmbrAmountAccounts.TabIndex = 14;
            this.nmbrAmountAccounts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbrAmountAccounts.ValueChanged += new System.EventHandler(this.nmbrAmountAccounts_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(50, 21);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(41, 13);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Create:";
            // 
            // chkRandomMail
            // 
            this.chkRandomMail.AutoSize = true;
            this.chkRandomMail.Location = new System.Drawing.Point(53, 45);
            this.chkRandomMail.Name = "chkRandomMail";
            this.chkRandomMail.Size = new System.Drawing.Size(88, 17);
            this.chkRandomMail.TabIndex = 16;
            this.chkRandomMail.Text = "Random Mail";
            this.chkRandomMail.UseVisualStyleBackColor = true;
            this.chkRandomMail.CheckedChanged += new System.EventHandler(this.ChkRandomMail_CheckedChanged);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.chkWriteIntoFile);
            this.pnlSettings.Controls.Add(this.chkAutoVerifyMail);
            this.pnlSettings.Controls.Add(this.chkRandomAlias);
            this.pnlSettings.Controls.Add(this.chkRandomPass);
            this.pnlSettings.Controls.Add(this.nmbrAmountAccounts);
            this.pnlSettings.Controls.Add(this.chkRandomMail);
            this.pnlSettings.Controls.Add(this.lblAmount);
            this.pnlSettings.Location = new System.Drawing.Point(15, 12);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(332, 96);
            this.pnlSettings.TabIndex = 17;
            this.pnlSettings.TabStop = false;
            this.pnlSettings.Text = "Settings";
            // 
            // chkWriteIntoFile
            // 
            this.chkWriteIntoFile.AutoSize = true;
            this.chkWriteIntoFile.Location = new System.Drawing.Point(159, 19);
            this.chkWriteIntoFile.Name = "chkWriteIntoFile";
            this.chkWriteIntoFile.Size = new System.Drawing.Size(117, 17);
            this.chkWriteIntoFile.TabIndex = 20;
            this.chkWriteIntoFile.Text = "Write Data Into File";
            this.chkWriteIntoFile.UseVisualStyleBackColor = true;
            this.chkWriteIntoFile.CheckedChanged += new System.EventHandler(this.ChkWriteIntoFile_CheckedChanged);
            // 
            // chkAutoVerifyMail
            // 
            this.chkAutoVerifyMail.AutoSize = true;
            this.chkAutoVerifyMail.Enabled = false;
            this.chkAutoVerifyMail.Location = new System.Drawing.Point(159, 45);
            this.chkAutoVerifyMail.Name = "chkAutoVerifyMail";
            this.chkAutoVerifyMail.Size = new System.Drawing.Size(99, 17);
            this.chkAutoVerifyMail.TabIndex = 19;
            this.chkAutoVerifyMail.Text = "Auto Mail Verify";
            this.chkAutoVerifyMail.UseVisualStyleBackColor = true;
            this.chkAutoVerifyMail.CheckedChanged += new System.EventHandler(this.ChkAutoVerifyMail_CheckedChanged);
            // 
            // chkRandomAlias
            // 
            this.chkRandomAlias.AutoSize = true;
            this.chkRandomAlias.Location = new System.Drawing.Point(159, 68);
            this.chkRandomAlias.Name = "chkRandomAlias";
            this.chkRandomAlias.Size = new System.Drawing.Size(91, 17);
            this.chkRandomAlias.TabIndex = 18;
            this.chkRandomAlias.Text = "Random Alias";
            this.chkRandomAlias.UseVisualStyleBackColor = true;
            this.chkRandomAlias.CheckedChanged += new System.EventHandler(this.ChkRandomAlias_CheckedChanged);
            // 
            // chkRandomPass
            // 
            this.chkRandomPass.AutoSize = true;
            this.chkRandomPass.Location = new System.Drawing.Point(53, 68);
            this.chkRandomPass.Name = "chkRandomPass";
            this.chkRandomPass.Size = new System.Drawing.Size(92, 17);
            this.chkRandomPass.TabIndex = 18;
            this.chkRandomPass.Text = "Random Pass";
            this.chkRandomPass.UseVisualStyleBackColor = true;
            this.chkRandomPass.CheckedChanged += new System.EventHandler(this.ChkRandomPass_CheckedChanged);
            // 
            // pnlCreation
            // 
            this.pnlCreation.Controls.Add(this.btnCreateAccount);
            this.pnlCreation.Controls.Add(this.lblPass);
            this.pnlCreation.Controls.Add(this.lblAlias);
            this.pnlCreation.Controls.Add(this.txtPass);
            this.pnlCreation.Controls.Add(this.txtEmail);
            this.pnlCreation.Controls.Add(this.txtAlias);
            this.pnlCreation.Controls.Add(this.lblEmail);
            this.pnlCreation.Location = new System.Drawing.Point(15, 114);
            this.pnlCreation.Name = "pnlCreation";
            this.pnlCreation.Size = new System.Drawing.Size(332, 132);
            this.pnlCreation.TabIndex = 18;
            this.pnlCreation.TabStop = false;
            // 
            // dataAccounts
            // 
            this.dataAccounts.AllowUserToAddRows = false;
            this.dataAccounts.AllowUserToDeleteRows = false;
            this.dataAccounts.AllowUserToResizeColumns = false;
            this.dataAccounts.AllowUserToResizeRows = false;
            this.dataAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMail,
            this.colAlias,
            this.colPass,
            this.colStatus});
            this.dataAccounts.Location = new System.Drawing.Point(364, 12);
            this.dataAccounts.MultiSelect = false;
            this.dataAccounts.Name = "dataAccounts";
            this.dataAccounts.ReadOnly = true;
            this.dataAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataAccounts.RowHeadersVisible = false;
            this.dataAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccounts.Size = new System.Drawing.Size(534, 234);
            this.dataAccounts.TabIndex = 19;
            // 
            // colMail
            // 
            this.colMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMail.Frozen = true;
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            this.colMail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMail.Width = 32;
            // 
            // colAlias
            // 
            this.colAlias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAlias.Frozen = true;
            this.colAlias.HeaderText = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.ReadOnly = true;
            this.colAlias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAlias.Width = 35;
            // 
            // colPass
            // 
            this.colPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPass.Frozen = true;
            this.colPass.HeaderText = "Pass";
            this.colPass.Name = "colPass";
            this.colPass.ReadOnly = true;
            this.colPass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPass.Width = 36;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Location = new System.Drawing.Point(15, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 39);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Writing";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User:Pass Formatting",
            "Original Formatting"});
            this.comboBox1.Location = new System.Drawing.Point(390, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "User:Pass Formatting";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(288, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(181, 15);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 17);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "Custom Directory";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(57, 15);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(79, 17);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Write Email";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 42);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proxy Support";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 22);
            this.button2.TabIndex = 27;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Working: ?";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(264, 16);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(150, 16);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Proxy Support";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "By: Scytex       Edit By: SpookedOnion\r\n                                       ag" +
    "entsix1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataAccounts);
            this.Controls.Add(this.pnlCreation);
            this.Controls.Add(this.pnlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Steam Account Creator";
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAmountAccounts)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlCreation.ResumeLayout(false);
            this.pnlCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.NumericUpDown nmbrAmountAccounts;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox chkRandomMail;
        private System.Windows.Forms.GroupBox pnlSettings;
        private System.Windows.Forms.CheckBox chkWriteIntoFile;
        private System.Windows.Forms.CheckBox chkAutoVerifyMail;
        private System.Windows.Forms.CheckBox chkRandomAlias;
        private System.Windows.Forms.CheckBox chkRandomPass;
        private System.Windows.Forms.GroupBox pnlCreation;
        private System.Windows.Forms.DataGridView dataAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

