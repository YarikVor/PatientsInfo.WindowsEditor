
namespace PatientsInfo.Window {
	partial class FCreatePerson {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelHeader = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.comboBoxPersonGender = new System.Windows.Forms.ComboBox();
			this.dateTimePickerOnsetDate = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxPatientNumber = new System.Windows.Forms.MaskedTextBox();
			this.textBoxPersonDescription = new System.Windows.Forms.TextBox();
			this.textBoxPersonFullName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelTextId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.dateTimePickerDateBirthday = new System.Windows.Forms.DateTimePicker();
			this.labelGender = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelHealth = new System.Windows.Forms.Label();
			this.labelBlood = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxPersonAddress = new System.Windows.Forms.TextBox();
			this.comboBoxPatientBlood = new System.Windows.Forms.ComboBox();
			this.comboBoxHealth = new System.Windows.Forms.ComboBox();
			this.toolStripButtonPersonAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 407);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(622, 26);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatus
			// 
			this.toolStripStatus.Name = "toolStripStatus";
			this.toolStripStatus.Size = new System.Drawing.Size(84, 20);
			this.toolStripStatus.Text = "Add Person";
			// 
			// labelHeader
			// 
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(622, 37);
			this.labelHeader.TabIndex = 4;
			this.labelHeader.Text = "Add Person";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPersonAdd,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 380);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(622, 27);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// comboBoxPersonGender
			// 
			this.comboBoxPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxPersonGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPersonGender.FormattingEnabled = true;
			this.comboBoxPersonGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBoxPersonGender.Location = new System.Drawing.Point(158, 123);
			this.comboBoxPersonGender.Name = "comboBoxPersonGender";
			this.comboBoxPersonGender.Size = new System.Drawing.Size(461, 24);
			this.comboBoxPersonGender.TabIndex = 13;
			// 
			// dateTimePickerOnsetDate
			// 
			this.dateTimePickerOnsetDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerOnsetDate.Location = new System.Drawing.Point(158, 63);
			this.dateTimePickerOnsetDate.MaxDate = new System.DateTime(2022, 5, 18, 0, 0, 0, 0);
			this.dateTimePickerOnsetDate.Name = "dateTimePickerOnsetDate";
			this.dateTimePickerOnsetDate.Size = new System.Drawing.Size(461, 22);
			this.dateTimePickerOnsetDate.TabIndex = 10;
			this.dateTimePickerOnsetDate.Value = new System.DateTime(2022, 5, 18, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Right;
			this.label7.Location = new System.Drawing.Point(59, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 30);
			this.label7.TabIndex = 9;
			this.label7.Text = "Date birthday";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxPatientNumber
			// 
			this.textBoxPatientNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPatientNumber.Location = new System.Drawing.Point(158, 153);
			this.textBoxPatientNumber.Mask = "+000000000000";
			this.textBoxPatientNumber.Name = "textBoxPatientNumber";
			this.textBoxPatientNumber.Size = new System.Drawing.Size(461, 22);
			this.textBoxPatientNumber.TabIndex = 6;
			// 
			// textBoxPersonDescription
			// 
			this.textBoxPersonDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPersonDescription.Location = new System.Drawing.Point(158, 273);
			this.textBoxPersonDescription.Multiline = true;
			this.textBoxPersonDescription.Name = "textBoxPersonDescription";
			this.textBoxPersonDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxPersonDescription.Size = new System.Drawing.Size(461, 67);
			this.textBoxPersonDescription.TabIndex = 7;
			// 
			// textBoxPersonFullName
			// 
			this.textBoxPersonFullName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPersonFullName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPersonFullName.Location = new System.Drawing.Point(158, 33);
			this.textBoxPersonFullName.MaxLength = 40;
			this.textBoxPersonFullName.Name = "textBoxPersonFullName";
			this.textBoxPersonFullName.Size = new System.Drawing.Size(461, 22);
			this.textBoxPersonFullName.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Right;
			this.label5.Location = new System.Drawing.Point(73, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 73);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Right;
			this.label4.Location = new System.Drawing.Point(74, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "Onset date";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelName.Location = new System.Drawing.Point(85, 30);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(67, 30);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "FullName";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTextId
			// 
			this.labelTextId.AutoSize = true;
			this.labelTextId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTextId.Location = new System.Drawing.Point(158, 0);
			this.labelTextId.Name = "labelTextId";
			this.labelTextId.Size = new System.Drawing.Size(461, 30);
			this.labelTextId.TabIndex = 1;
			this.labelTextId.Text = "labelTextAddDiseaseId";
			this.labelTextId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Right;
			this.label2.Location = new System.Drawing.Point(131, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelNumber.Location = new System.Drawing.Point(51, 150);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(101, 30);
			this.labelNumber.TabIndex = 8;
			this.labelNumber.Text = "Phone number";
			this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePickerDateBirthday
			// 
			this.dateTimePickerDateBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerDateBirthday.Location = new System.Drawing.Point(158, 93);
			this.dateTimePickerDateBirthday.MaxDate = new System.DateTime(2022, 5, 18, 0, 0, 0, 0);
			this.dateTimePickerDateBirthday.Name = "dateTimePickerDateBirthday";
			this.dateTimePickerDateBirthday.Size = new System.Drawing.Size(461, 22);
			this.dateTimePickerDateBirthday.TabIndex = 11;
			this.dateTimePickerDateBirthday.Value = new System.DateTime(2022, 5, 18, 0, 0, 0, 0);
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelGender.Location = new System.Drawing.Point(96, 120);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(56, 30);
			this.labelGender.TabIndex = 12;
			this.labelGender.Text = "Gender";
			this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.Controls.Add(this.labelHealth, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelBlood, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelGender, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateBirthday, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelNumber, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelTextId, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPersonFullName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPersonDescription, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPatientNumber, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerOnsetDate, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxPersonGender, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPersonAddress, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxPatientBlood, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxHealth, 1, 8);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 343);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// labelHealth
			// 
			this.labelHealth.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelHealth.AutoSize = true;
			this.labelHealth.Location = new System.Drawing.Point(61, 246);
			this.labelHealth.Name = "labelHealth";
			this.labelHealth.Size = new System.Drawing.Size(91, 17);
			this.labelHealth.TabIndex = 18;
			this.labelHealth.Text = "Health status";
			// 
			// labelBlood
			// 
			this.labelBlood.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelBlood.AutoSize = true;
			this.labelBlood.Location = new System.Drawing.Point(77, 216);
			this.labelBlood.Name = "labelBlood";
			this.labelBlood.Size = new System.Drawing.Size(75, 17);
			this.labelBlood.TabIndex = 16;
			this.labelBlood.Text = "Blood type";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 186);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(130, 17);
			this.label9.TabIndex = 14;
			this.label9.Text = "Residence address";
			// 
			// textBoxPersonAddress
			// 
			this.textBoxPersonAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPersonAddress.Location = new System.Drawing.Point(158, 183);
			this.textBoxPersonAddress.MaxLength = 127;
			this.textBoxPersonAddress.Name = "textBoxPersonAddress";
			this.textBoxPersonAddress.Size = new System.Drawing.Size(461, 22);
			this.textBoxPersonAddress.TabIndex = 15;
			this.textBoxPersonAddress.UseWaitCursor = true;
			// 
			// comboBoxPatientBlood
			// 
			this.comboBoxPatientBlood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxPatientBlood.FormattingEnabled = true;
			this.comboBoxPatientBlood.ImeMode = System.Windows.Forms.ImeMode.On;
			this.comboBoxPatientBlood.Items.AddRange(new object[] {
            "",
            "I+",
            "II+",
            "III+",
            "IV+",
            "I-",
            "II-",
            "III-",
            "IV-"});
			this.comboBoxPatientBlood.Location = new System.Drawing.Point(158, 213);
			this.comboBoxPatientBlood.Name = "comboBoxPatientBlood";
			this.comboBoxPatientBlood.Size = new System.Drawing.Size(461, 24);
			this.comboBoxPatientBlood.TabIndex = 17;
			// 
			// comboBoxHealth
			// 
			this.comboBoxHealth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxHealth.FormattingEnabled = true;
			this.comboBoxHealth.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Satisfactory",
            "Moderate",
            "Severe",
            "Extremely"});
			this.comboBoxHealth.Location = new System.Drawing.Point(158, 243);
			this.comboBoxHealth.Name = "comboBoxHealth";
			this.comboBoxHealth.Size = new System.Drawing.Size(461, 24);
			this.comboBoxHealth.TabIndex = 19;
			// 
			// toolStripButtonPersonAdd
			// 
			this.toolStripButtonPersonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPersonAdd.Image = global::PatientsInfo.Window.Properties.Resources._13;
			this.toolStripButtonPersonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPersonAdd.Name = "toolStripButtonPersonAdd";
			this.toolStripButtonPersonAdd.Size = new System.Drawing.Size(29, 24);
			this.toolStripButtonPersonAdd.Text = "toolStripButton1";
			this.toolStripButtonPersonAdd.ToolTipText = "Add";
			this.toolStripButtonPersonAdd.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::PatientsInfo.Window.Properties.Resources._33;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Cancel";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// FCreatePerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.labelHeader);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FCreatePerson";
			this.Text = "Add Person";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonPersonAdd;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ComboBox comboBoxPersonGender;
		private System.Windows.Forms.DateTimePicker dateTimePickerOnsetDate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox textBoxPatientNumber;
		private System.Windows.Forms.TextBox textBoxPersonDescription;
		private System.Windows.Forms.TextBox textBoxPersonFullName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelTextId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateBirthday;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelHealth;
		private System.Windows.Forms.Label labelBlood;
		private System.Windows.Forms.TextBox textBoxPersonAddress;
		private System.Windows.Forms.ComboBox comboBoxPatientBlood;
		private System.Windows.Forms.ComboBox comboBoxHealth;
	}
}