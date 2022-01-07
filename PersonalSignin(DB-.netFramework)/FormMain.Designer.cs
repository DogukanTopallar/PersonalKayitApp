
namespace Personal_SignIn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbSignIn = new System.Windows.Forms.GroupBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.lblJob = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPerSurname = new System.Windows.Forms.Label();
            this.lblPerName = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbPerSurname = new System.Windows.Forms.TextBox();
            this.tbPerName = new System.Windows.Forms.TextBox();
            this.tbPerID = new System.Windows.Forms.TextBox();
            this.lblPerID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGrapsh = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaritalStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDataBaseDataSet = new PersonalSignin_DB_.netFramework_.PersonalDataBaseDataSet();
            this.table_PersonalTableAdapter = new PersonalSignin_DB_.netFramework_.PersonalDataBaseDataSetTableAdapters.Table_PersonalTableAdapter();
            this.lblRadioButtonStatus = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbSignIn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSignIn
            // 
            this.grbSignIn.Controls.Add(this.lblSalary);
            this.grbSignIn.Controls.Add(this.maskedTextBox1);
            this.grbSignIn.Controls.Add(this.rbSingle);
            this.grbSignIn.Controls.Add(this.rbMarried);
            this.grbSignIn.Controls.Add(this.lblJob);
            this.grbSignIn.Controls.Add(this.cbCity);
            this.grbSignIn.Controls.Add(this.lblCity);
            this.grbSignIn.Controls.Add(this.lblPerSurname);
            this.grbSignIn.Controls.Add(this.lblPerName);
            this.grbSignIn.Controls.Add(this.tbJob);
            this.grbSignIn.Controls.Add(this.tbPerSurname);
            this.grbSignIn.Controls.Add(this.tbPerName);
            this.grbSignIn.Controls.Add(this.tbPerID);
            this.grbSignIn.Controls.Add(this.lblPerID);
            this.grbSignIn.Location = new System.Drawing.Point(12, 12);
            this.grbSignIn.Name = "grbSignIn";
            this.grbSignIn.Size = new System.Drawing.Size(327, 319);
            this.grbSignIn.TabIndex = 0;
            this.grbSignIn.TabStop = false;
            this.grbSignIn.Text = "Personal Sign in";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(70, 195);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(61, 19);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(150, 192);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 27);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(236, 225);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(73, 23);
            this.rbSingle.TabIndex = 7;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(150, 225);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(87, 23);
            this.rbMarried.TabIndex = 6;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(92, 257);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(39, 19);
            this.lblJob.TabIndex = 11;
            this.lblJob.Text = "Job:";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(150, 159);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(159, 27);
            this.cbCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(88, 162);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 19);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // lblPerSurname
            // 
            this.lblPerSurname.AutoSize = true;
            this.lblPerSurname.Location = new System.Drawing.Point(48, 129);
            this.lblPerSurname.Name = "lblPerSurname";
            this.lblPerSurname.Size = new System.Drawing.Size(83, 19);
            this.lblPerSurname.TabIndex = 7;
            this.lblPerSurname.Text = "Surname:";
            // 
            // lblPerName
            // 
            this.lblPerName.AutoSize = true;
            this.lblPerName.Location = new System.Drawing.Point(71, 96);
            this.lblPerName.Name = "lblPerName";
            this.lblPerName.Size = new System.Drawing.Size(60, 19);
            this.lblPerName.TabIndex = 6;
            this.lblPerName.Text = "Name:";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(150, 254);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(159, 27);
            this.tbJob.TabIndex = 8;
            // 
            // tbPerSurname
            // 
            this.tbPerSurname.Location = new System.Drawing.Point(150, 126);
            this.tbPerSurname.Name = "tbPerSurname";
            this.tbPerSurname.Size = new System.Drawing.Size(159, 27);
            this.tbPerSurname.TabIndex = 3;
            // 
            // tbPerName
            // 
            this.tbPerName.Location = new System.Drawing.Point(150, 93);
            this.tbPerName.Name = "tbPerName";
            this.tbPerName.Size = new System.Drawing.Size(159, 27);
            this.tbPerName.TabIndex = 2;
            // 
            // tbPerID
            // 
            this.tbPerID.Location = new System.Drawing.Point(150, 60);
            this.tbPerID.Name = "tbPerID";
            this.tbPerID.Size = new System.Drawing.Size(159, 27);
            this.tbPerID.TabIndex = 1;
            // 
            // lblPerID
            // 
            this.lblPerID.AutoSize = true;
            this.lblPerID.Location = new System.Drawing.Point(31, 63);
            this.lblPerID.Name = "lblPerID";
            this.lblPerID.Size = new System.Drawing.Size(100, 19);
            this.lblPerID.TabIndex = 0;
            this.lblPerID.Text = "Personal ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnGrapsh);
            this.groupBox1.Controls.Add(this.btnStatistic);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Location = new System.Drawing.Point(346, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGrapsh
            // 
            this.btnGrapsh.Location = new System.Drawing.Point(37, 252);
            this.btnGrapsh.Name = "btnGrapsh";
            this.btnGrapsh.Size = new System.Drawing.Size(126, 27);
            this.btnGrapsh.TabIndex = 6;
            this.btnGrapsh.Text = "Graphs";
            this.btnGrapsh.UseVisualStyleBackColor = true;
            this.btnGrapsh.Click += new System.EventHandler(this.btnGrapsh_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(37, 219);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(126, 27);
            this.btnStatistic.TabIndex = 5;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(37, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(37, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(37, 54);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 27);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // grbResults
            // 
            this.grbResults.Controls.Add(this.dataGridView1);
            this.grbResults.Location = new System.Drawing.Point(12, 337);
            this.grbResults.Name = "grbResults";
            this.grbResults.Size = new System.Drawing.Size(905, 202);
            this.grbResults.TabIndex = 2;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perSalaryDataGridViewTextBoxColumn,
            this.perMaritalStatusDataGridViewCheckBoxColumn,
            this.perJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePersonalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(899, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 76;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "PerName";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "PerName";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.HeaderText = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            this.perSurnameDataGridViewTextBoxColumn.Width = 128;
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "PerCity";
            this.perCityDataGridViewTextBoxColumn.HeaderText = "PerCity";
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            // 
            // perSalaryDataGridViewTextBoxColumn
            // 
            this.perSalaryDataGridViewTextBoxColumn.DataPropertyName = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.HeaderText = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.Name = "perSalaryDataGridViewTextBoxColumn";
            // 
            // perMaritalStatusDataGridViewCheckBoxColumn
            // 
            this.perMaritalStatusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perMaritalStatusDataGridViewCheckBoxColumn.DataPropertyName = "PerMaritalStatus";
            this.perMaritalStatusDataGridViewCheckBoxColumn.HeaderText = "PerMaritalStatus";
            this.perMaritalStatusDataGridViewCheckBoxColumn.Name = "perMaritalStatusDataGridViewCheckBoxColumn";
            this.perMaritalStatusDataGridViewCheckBoxColumn.Width = 141;
            // 
            // perJobDataGridViewTextBoxColumn
            // 
            this.perJobDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.perJobDataGridViewTextBoxColumn.DataPropertyName = "PerJob";
            this.perJobDataGridViewTextBoxColumn.HeaderText = "PerJob";
            this.perJobDataGridViewTextBoxColumn.Name = "perJobDataGridViewTextBoxColumn";
            // 
            // tablePersonalBindingSource
            // 
            this.tablePersonalBindingSource.DataMember = "Table_Personal";
            this.tablePersonalBindingSource.DataSource = this.personalDataBaseDataSet;
            // 
            // personalDataBaseDataSet
            // 
            this.personalDataBaseDataSet.DataSetName = "PersonalDataBaseDataSet";
            this.personalDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_PersonalTableAdapter
            // 
            this.table_PersonalTableAdapter.ClearBeforeFill = true;
            // 
            // lblRadioButtonStatus
            // 
            this.lblRadioButtonStatus.AutoSize = true;
            this.lblRadioButtonStatus.Location = new System.Drawing.Point(719, 312);
            this.lblRadioButtonStatus.Name = "lblRadioButtonStatus";
            this.lblRadioButtonStatus.Size = new System.Drawing.Size(0, 19);
            this.lblRadioButtonStatus.TabIndex = 4;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(583, 313);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(56, 19);
            this.lblMaritalStatus.TabIndex = 5;
            this.lblMaritalStatus.Text = "label1";
            this.lblMaritalStatus.TextChanged += new System.EventHandler(this.lblMaritalStatus_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalSignin_DB_.netFramework_.Properties.Resources.EntireHilariousGypsymoth_size_restricted;
            this.pictureBox1.Location = new System.Drawing.Point(600, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(929, 551);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblRadioButtonStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbSignIn);
            this.Font = new System.Drawing.Font("SolidWorks GDT", 12F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSignIn.ResumeLayout(false);
            this.grbSignIn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSignIn;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPerSurname;
        private System.Windows.Forms.Label lblPerName;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbPerSurname;
        private System.Windows.Forms.TextBox tbPerName;
        private System.Windows.Forms.TextBox tbPerID;
        private System.Windows.Forms.Label lblPerID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGrapsh;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonalSignin_DB_.netFramework_.PersonalDataBaseDataSet personalDataBaseDataSet;
        private System.Windows.Forms.BindingSource tablePersonalBindingSource;
        private PersonalSignin_DB_.netFramework_.PersonalDataBaseDataSetTableAdapters.Table_PersonalTableAdapter table_PersonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMaritalStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblRadioButtonStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Button btnSave;
    }
}

