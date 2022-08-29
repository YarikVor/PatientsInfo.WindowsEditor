
namespace PatientsInfo.Window {
	partial class FCreatePatient {
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
			this.labelHeader = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelPerson = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTextId = new System.Windows.Forms.Label();
			this.labelSick = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.radioButtonYes = new System.Windows.Forms.RadioButton();
			this.radioButtonNo = new System.Windows.Forms.RadioButton();
			this.radioButtonUnknown = new System.Windows.Forms.RadioButton();
			this.textBoxPerson = new System.Windows.Forms.TextBox();
			this.listBoxPeople = new System.Windows.Forms.ListBox();
			this.labelDisease = new System.Windows.Forms.Label();
			this.textBoxDiseases = new System.Windows.Forms.TextBox();
			this.listBoxDiseases = new System.Windows.Forms.ListBox();
			this.textBoxPersonDescription = new System.Windows.Forms.TextBox();
			this.toolStripButtonPersonAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelHeader
			// 
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(622, 37);
			this.labelHeader.TabIndex = 5;
			this.labelHeader.Text = "Add Patient";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatus
			// 
			this.toolStripStatus.Name = "toolStripStatus";
			this.toolStripStatus.Size = new System.Drawing.Size(86, 20);
			this.toolStripStatus.Text = "Add Patient";
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
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelPerson, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelTextId, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelSick, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPerson, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.listBoxPeople, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelDisease, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDiseases, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.listBoxDiseases, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPersonDescription, 1, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 343);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelDescription.Location = new System.Drawing.Point(73, 208);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(79, 135);
			this.labelDescription.TabIndex = 13;
			this.labelDescription.Text = "Description";
			this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelPerson
			// 
			this.labelPerson.AutoSize = true;
			this.labelPerson.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelPerson.Location = new System.Drawing.Point(58, 64);
			this.labelPerson.Name = "labelPerson";
			this.labelPerson.Size = new System.Drawing.Size(94, 30);
			this.labelPerson.TabIndex = 7;
			this.labelPerson.Text = "Person Name";
			this.labelPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// labelSick
			// 
			this.labelSick.AutoSize = true;
			this.labelSick.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelSick.Location = new System.Drawing.Point(110, 30);
			this.labelSick.Name = "labelSick";
			this.labelSick.Size = new System.Drawing.Size(42, 34);
			this.labelSick.TabIndex = 3;
			this.labelSick.Text = "Sick?";
			this.labelSick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.radioButtonYes);
			this.flowLayoutPanel1.Controls.Add(this.radioButtonNo);
			this.flowLayoutPanel1.Controls.Add(this.radioButtonUnknown);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 33);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 28);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// radioButtonYes
			// 
			this.radioButtonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonYes.AutoSize = true;
			this.radioButtonYes.Checked = true;
			this.radioButtonYes.Location = new System.Drawing.Point(3, 3);
			this.radioButtonYes.Name = "radioButtonYes";
			this.radioButtonYes.Size = new System.Drawing.Size(53, 21);
			this.radioButtonYes.TabIndex = 0;
			this.radioButtonYes.TabStop = true;
			this.radioButtonYes.Text = "Yes";
			this.radioButtonYes.UseVisualStyleBackColor = true;
			// 
			// radioButtonNo
			// 
			this.radioButtonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNo.AutoSize = true;
			this.radioButtonNo.Location = new System.Drawing.Point(62, 3);
			this.radioButtonNo.Name = "radioButtonNo";
			this.radioButtonNo.Size = new System.Drawing.Size(47, 21);
			this.radioButtonNo.TabIndex = 1;
			this.radioButtonNo.Text = "No";
			this.radioButtonNo.UseVisualStyleBackColor = true;
			// 
			// radioButtonUnknown
			// 
			this.radioButtonUnknown.AutoSize = true;
			this.radioButtonUnknown.Location = new System.Drawing.Point(115, 3);
			this.radioButtonUnknown.Name = "radioButtonUnknown";
			this.radioButtonUnknown.Size = new System.Drawing.Size(87, 21);
			this.radioButtonUnknown.TabIndex = 2;
			this.radioButtonUnknown.Text = "Unknown";
			this.radioButtonUnknown.UseVisualStyleBackColor = true;
			// 
			// textBoxPerson
			// 
			this.textBoxPerson.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPerson.Location = new System.Drawing.Point(158, 67);
			this.textBoxPerson.MaxLength = 40;
			this.textBoxPerson.Name = "textBoxPerson";
			this.textBoxPerson.Size = new System.Drawing.Size(461, 22);
			this.textBoxPerson.TabIndex = 8;
			this.textBoxPerson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// listBoxPeople
			// 
			this.listBoxPeople.FormattingEnabled = true;
			this.listBoxPeople.ItemHeight = 16;
			this.listBoxPeople.Location = new System.Drawing.Point(158, 97);
			this.listBoxPeople.Name = "listBoxPeople";
			this.listBoxPeople.Size = new System.Drawing.Size(461, 36);
			this.listBoxPeople.TabIndex = 9;
			this.listBoxPeople.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// labelDisease
			// 
			this.labelDisease.AutoSize = true;
			this.labelDisease.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelDisease.Location = new System.Drawing.Point(86, 136);
			this.labelDisease.Name = "labelDisease";
			this.labelDisease.Size = new System.Drawing.Size(66, 30);
			this.labelDisease.TabIndex = 10;
			this.labelDisease.Text = "Diseases";
			this.labelDisease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxDiseases
			// 
			this.textBoxDiseases.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDiseases.Location = new System.Drawing.Point(158, 139);
			this.textBoxDiseases.MaxLength = 40;
			this.textBoxDiseases.Name = "textBoxDiseases";
			this.textBoxDiseases.Size = new System.Drawing.Size(461, 22);
			this.textBoxDiseases.TabIndex = 11;
			this.textBoxDiseases.TextChanged += new System.EventHandler(this.textBoxDiseases_TextChanged);
			this.textBoxDiseases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDiseases_KeyDown);
			// 
			// listBoxDiseases
			// 
			this.listBoxDiseases.FormattingEnabled = true;
			this.listBoxDiseases.ItemHeight = 16;
			this.listBoxDiseases.Location = new System.Drawing.Point(158, 169);
			this.listBoxDiseases.Name = "listBoxDiseases";
			this.listBoxDiseases.Size = new System.Drawing.Size(461, 36);
			this.listBoxDiseases.TabIndex = 12;
			this.listBoxDiseases.SelectedIndexChanged += new System.EventHandler(this.listBoxDiseases_SelectedIndexChanged);
			// 
			// textBoxPersonDescription
			// 
			this.textBoxPersonDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPersonDescription.Location = new System.Drawing.Point(158, 211);
			this.textBoxPersonDescription.Multiline = true;
			this.textBoxPersonDescription.Name = "textBoxPersonDescription";
			this.textBoxPersonDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxPersonDescription.Size = new System.Drawing.Size(461, 129);
			this.textBoxPersonDescription.TabIndex = 15;
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
			this.toolStripButtonPersonAdd.Click += new System.EventHandler(this.toolStripButtonPersonAdd_Click);
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
			// FCreatePatient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.labelHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FCreatePatient";
			this.Text = "Add Patient";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonPersonAdd;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTextId;
		private System.Windows.Forms.Label labelSick;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.RadioButton radioButtonYes;
		private System.Windows.Forms.RadioButton radioButtonNo;
		private System.Windows.Forms.RadioButton radioButtonUnknown;
		private System.Windows.Forms.Label labelPerson;
		private System.Windows.Forms.TextBox textBoxPerson;
		private System.Windows.Forms.ListBox listBoxPeople;
		private System.Windows.Forms.Label labelDisease;
		private System.Windows.Forms.TextBox textBoxDiseases;
		private System.Windows.Forms.ListBox listBoxDiseases;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxPersonDescription;
	}
}