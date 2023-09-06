namespace PatientsForm
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientManagementDataSet = new PatientsForm.PatientManagementDataSet();
            this.insertBtn = new System.Windows.Forms.Button();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new PatientsForm.PatientManagementDataSetTableAdapters.PatientsTableAdapter();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Dob,
            this.GenderID,
            this.Phone,
            this.Address,
            this.PersonalID,
            this.EMail});
            this.dataGridView1.DataSource = this.patientManagementDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // patientManagementDataSetBindingSource
            // 
            this.patientManagementDataSetBindingSource.DataSource = this.patientManagementDataSet;
            this.patientManagementDataSetBindingSource.Position = 0;
            // 
            // patientManagementDataSet
            // 
            this.patientManagementDataSet.DataSetName = "PatientManagementDataSet";
            this.patientManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertBtn
            // 
            this.insertBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertBtn.Image = ((System.Drawing.Image)(resources.GetObject("insertBtn.Image")));
            this.insertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.Location = new System.Drawing.Point(27, 43);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(86, 23);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.Text = "დამატება";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientManagementDataSetBindingSource;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.patientManagementDataSetBindingSource;
            // 
            // patientsBindingSource2
            // 
            this.patientsBindingSource2.DataMember = "Patients";
            this.patientsBindingSource2.DataSource = this.patientManagementDataSetBindingSource;
            // 
            // patientsBindingSource3
            // 
            this.patientsBindingSource3.DataMember = "Patients";
            this.patientsBindingSource3.DataSource = this.patientManagementDataSetBindingSource;
            // 
            // editBtn
            // 
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(110, 43);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(106, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "რედაქტირება";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(213, 43);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(66, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "წაშლა";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "პაციენტის გვარი სახელი";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // Dob
            // 
            this.Dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dob.DataPropertyName = "Dob";
            this.Dob.HeaderText = "დაბ თარიღი";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            this.Dob.Width = 120;
            // 
            // GenderID
            // 
            this.GenderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GenderID.DataPropertyName = "GenderName";
            this.GenderID.HeaderText = "სქესი";
            this.GenderID.Name = "GenderID";
            this.GenderID.ReadOnly = true;
            this.GenderID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GenderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "მობ ნომერი";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "მისამართი";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 140;
            // 
            // PersonalID
            // 
            this.PersonalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PersonalID.DataPropertyName = "PersonalID";
            this.PersonalID.HeaderText = "პირადი ნომერი";
            this.PersonalID.Name = "PersonalID";
            this.PersonalID.ReadOnly = true;
            this.PersonalID.Width = 130;
            // 
            // EMail
            // 
            this.EMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Width = 170;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 375);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "პაციენტები";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientManagementDataSetBindingSource;
        private PatientManagementDataSet patientManagementDataSet;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientManagementDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private System.Windows.Forms.BindingSource patientsBindingSource3;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
    }
}

