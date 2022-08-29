
namespace PatientsInfo.Window {
	partial class FCreateDisease {
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
			this.toolStripStatusInputText = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.labelTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTextAddDiseaseId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxDiseasesName = new System.Windows.Forms.TextBox();
			this.textBoxDiseasesICD = new System.Windows.Forms.MaskedTextBox();
			this.textBoxDiseasesDescription = new System.Windows.Forms.TextBox();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInputText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 287);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(622, 26);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusInputText
			// 
			this.toolStripStatusInputText.Name = "toolStripStatusInputText";
			this.toolStripStatusInputText.Size = new System.Drawing.Size(92, 20);
			this.toolStripStatusInputText.Text = "Add Disease";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 260);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(622, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::PatientsInfo.Window.Properties.Resources._13;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Add";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
			// labelTitle
			// 
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(622, 37);
			this.labelTitle.TabIndex = 3;
			this.labelTitle.Text = "Add Disease";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelTextAddDiseaseId, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDiseasesName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDiseasesICD, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDiseasesDescription, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 223);
			this.tableLayoutPanel1.TabIndex = 4;
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
			// labelTextAddDiseaseId
			// 
			this.labelTextAddDiseaseId.AutoSize = true;
			this.labelTextAddDiseaseId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTextAddDiseaseId.Location = new System.Drawing.Point(158, 0);
			this.labelTextAddDiseaseId.Name = "labelTextAddDiseaseId";
			this.labelTextAddDiseaseId.Size = new System.Drawing.Size(461, 30);
			this.labelTextAddDiseaseId.TabIndex = 1;
			this.labelTextAddDiseaseId.Text = "labelTextAddDiseaseId";
			this.labelTextAddDiseaseId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Right;
			this.label3.Location = new System.Drawing.Point(107, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Right;
			this.label4.Location = new System.Drawing.Point(122, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "ICD";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Right;
			this.label5.Location = new System.Drawing.Point(73, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 135);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxDiseasesName
			// 
			this.textBoxDiseasesName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDiseasesName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDiseasesName.Location = new System.Drawing.Point(158, 33);
			this.textBoxDiseasesName.Name = "textBoxDiseasesName";
			this.textBoxDiseasesName.Size = new System.Drawing.Size(461, 22);
			this.textBoxDiseasesName.TabIndex = 5;
			// 
			// textBoxDiseasesICD
			// 
			this.textBoxDiseasesICD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDiseasesICD.Location = new System.Drawing.Point(158, 63);
			this.textBoxDiseasesICD.Name = "textBoxDiseasesICD";
			this.textBoxDiseasesICD.Size = new System.Drawing.Size(461, 22);
			this.textBoxDiseasesICD.TabIndex = 6;
			// 
			// textBoxDiseasesDescription
			// 
			this.textBoxDiseasesDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDiseasesDescription.Location = new System.Drawing.Point(158, 93);
			this.textBoxDiseasesDescription.Multiline = true;
			this.textBoxDiseasesDescription.Name = "textBoxDiseasesDescription";
			this.textBoxDiseasesDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxDiseasesDescription.Size = new System.Drawing.Size(461, 129);
			this.textBoxDiseasesDescription.TabIndex = 7;
			// 
			// FCreateDisease
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 313);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FCreateDisease";
			this.Text = "Add Disease";
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
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTextAddDiseaseId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDiseasesName;
		private System.Windows.Forms.MaskedTextBox textBoxDiseasesICD;
		private System.Windows.Forms.TextBox textBoxDiseasesDescription;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInputText;
	}
}