namespace PatientsForm
{
    partial class InsertForm
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.dobdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.fullName = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.mobileNumber = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.personalIDTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personalIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(249, 47);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // dobdateTimePicker
            // 
            this.dobdateTimePicker.Location = new System.Drawing.Point(249, 91);
            this.dobdateTimePicker.Name = "dobdateTimePicker";
            this.dobdateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.dobdateTimePicker.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(249, 141);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(272, 21);
            this.genderComboBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(249, 191);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(272, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(249, 240);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(272, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(236, 406);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "დამახსოვრება";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(67, 54);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(142, 13);
            this.fullName.TabIndex = 6;
            this.fullName.Text = "პაციენტის გვარი სახელი";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(67, 98);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(76, 13);
            this.dob.TabIndex = 7;
            this.dob.Text = "დაბ თარიღი";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(67, 149);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(35, 13);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "სქესი";
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Location = new System.Drawing.Point(67, 198);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(70, 13);
            this.mobileNumber.TabIndex = 9;
            this.mobileNumber.Text = "მობ ნომერი";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(67, 247);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(67, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "მისამართი";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(400, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "უკან";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(249, 328);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(272, 20);
            this.eMailTextBox.TabIndex = 6;
            // 
            // personalIDTextBox
            // 
            this.personalIDTextBox.Location = new System.Drawing.Point(249, 286);
            this.personalIDTextBox.Name = "personalIDTextBox";
            this.personalIDTextBox.Size = new System.Drawing.Size(272, 20);
            this.personalIDTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(67, 335);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(33, 13);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "EMail";
            // 
            // personalIDLabel
            // 
            this.personalIDLabel.AutoSize = true;
            this.personalIDLabel.Location = new System.Drawing.Point(67, 293);
            this.personalIDLabel.Name = "personalIDLabel";
            this.personalIDLabel.Size = new System.Drawing.Size(91, 13);
            this.personalIDLabel.TabIndex = 28;
            this.personalIDLabel.Text = "პირადი ნომერი";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.personalIDTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.personalIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dobdateTimePicker);
            this.Controls.Add(this.fullNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertForm";
            this.Text = "პაციენტის დამატება";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DateTimePicker dobdateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label mobileNumber;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox personalIDTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label personalIDLabel;
    }
}