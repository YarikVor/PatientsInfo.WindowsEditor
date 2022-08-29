using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RegexExpressions.RegexExpressions;
using System.Text.RegularExpressions;
using PatientsInfo.Entities;

namespace PatientsInfo.Window {
	public partial class FCreateDisease : Form {

		PatientsInfo.Entities.Data.DataSet dataSet;
		public FCreateDisease(PatientsInfo.Entities.Data.DataSet dataSet) : this() {
			this.dataSet = dataSet;
			labelTextAddDiseaseId.Text = (Disease.IDCounter + 1).ToString();
		}

		public static Disease Disease;

		private FCreateDisease() {
			InitializeComponent();
		}

		public FCreateDisease(Disease disease) : this() {
			labelTitle.Text = this.Text = toolStripStatusInputText.Text = "Edit Diseases";
			Disease = disease;
			labelTextAddDiseaseId.Text = disease.Id.ToString();
			textBoxDiseasesName.Text = disease.Name;
			textBoxDiseasesICD.Text = disease.CodeICD;
			textBoxDiseasesDescription.Text = disease.Description;
		}


		private void toolStripButton1_Click(object sender, EventArgs e) {
			toolStripStatusInputText.Text = "";
			toolStripStatusInputText.ForeColor = Color.Red;
			if (RCodeICD.IsMatch(textBoxDiseasesICD.Text) == false) {
				textBoxDiseasesICD.ForeColor = Color.Red;
				toolStripStatusInputText.Text += "Error format \"ICD\". Ex: R12, R44.1 or Y03";
			} else {
				if (dataSet == null) {
					Disease.Name = textBoxDiseasesName.Text;
					Disease.CodeICD = textBoxDiseasesICD.Text;
					Disease.Description = textBoxDiseasesDescription.Text;
				} else {
					dataSet.Diseases.Add(new Disease(textBoxDiseasesName.Text, textBoxDiseasesICD.Text, textBoxDiseasesDescription.Text));	
				}
				this.Close();
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
