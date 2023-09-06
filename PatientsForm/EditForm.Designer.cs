namespace PatientsForm
{
    partial class EditForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileNumber = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.personalIDLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personalIDTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(406, 371);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "უკან";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(73, 230);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(67, 13);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "მისამართი";
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Location = new System.Drawing.Point(73, 181);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(70, 13);
            this.mobileNumber.TabIndex = 21;
            this.mobileNumber.Text = "მობ ნომერი";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(73, 132);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(35, 13);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "სქესი";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(73, 81);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(76, 13);
            this.dob.TabIndex = 19;
            this.dob.Text = "დაბ თარიღი";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(73, 37);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(142, 13);
            this.fullName.TabIndex = 18;
            this.fullName.Text = "პაციენტის გვარი სახელი";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(255, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "დამახსოვრება";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(255, 223);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(272, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(255, 174);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(272, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(255, 124);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(272, 21);
            this.genderComboBox.TabIndex = 3;
            // 
            // dobdateTimePicker
            // 
            this.dobdateTimePicker.Location = new System.Drawing.Point(255, 74);
            this.dobdateTimePicker.Name = "dobdateTimePicker";
            this.dobdateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.dobdateTimePicker.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(255, 30);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // personalIDLabel
            // 
            this.personalIDLabel.AutoSize = true;
            this.personalIDLabel.Location = new System.Drawing.Point(73, 273);
            this.personalIDLabel.Name = "personalIDLabel";
            this.personalIDLabel.Size = new System.Drawing.Size(91, 13);
            this.personalIDLabel.TabIndex = 24;
            this.personalIDLabel.Text = "პირადი ნომერი";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(73, 315);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(33, 13);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "EMail";
            // 
            // personalIDTextBox
            // 
            this.personalIDTextBox.Location = new System.Drawing.Point(255, 266);
            this.personalIDTextBox.Name = "personalIDTextBox";
            this.personalIDTextBox.Size = new System.Drawing.Size(272, 20);
            this.personalIDTextBox.TabIndex = 6;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(255, 308);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(272, 20);
            this.eMailTextBox.TabIndex = 7;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 427);
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
            this.Name = "EditForm";
            this.Text = "პაციენტის რედაქტირება";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label mobileNumber;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dobdateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label personalIDLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox personalIDTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
    }
}