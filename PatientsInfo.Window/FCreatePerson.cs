using System;
using System.Drawing;
using System.Windows.Forms;
using Methods;
using PatientsInfo.Entities;
using PatientsInfo.Entities.Data;
using static RegexExpressions.RegexExpressions;

namespace PatientsInfo.Window {
	public partial class FCreatePerson : Form {

		/// <summary>
		/// Повертає Patient
		/// </summary>
		public static Person Person;
		bool isEditor = false;

		public FCreatePerson(Person person){
			InitializeComponent();
			FCreatePerson.Person = person;
			isEditor = true;
			toolStripStatus.Text = labelHeader.Text = this.Text = "Add Person";
			toolStripStatus.Text = labelHeader.Text = this.Text = "Editor Person";
			labelTextId.Text = FCreatePerson.Person.Id.ToString();
			textBoxPersonFullName.Text = FCreatePerson.Person.FullName;
			textBoxPersonDescription.Text = FCreatePerson.Person.Comment;
			dateTimePickerDateBirthday.Value = FCreatePerson.Person.DateBirth;
			dateTimePickerOnsetDate.Value = FCreatePerson.Person.DiseaseOnsetDate;
			comboBoxPersonGender.SelectedIndex = (int)FCreatePerson.Person.Gender;
			comboBoxHealth.SelectedIndex = (int)FCreatePerson.Person.HealthStatus;
			comboBoxPatientBlood.Text = FCreatePerson.Person.TypeBlood;
			textBoxPersonAddress.Text = FCreatePerson.Person.ResidenceAddress;
			labelTextId.Text = FCreatePerson.Person.Id.ToString();
		}


		public FCreatePerson() {
			InitializeComponent();
			toolStripStatus.Text = labelHeader.Text = this.Text = "Add Person";
			Person = null;
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			toolStripStatus.Text = "";
			Entities.Enum.Gender gender;
			int countError = 0;

			toolStripStatus.ForeColor = Color.Red;

			if (RFullName.IsMatch(textBoxPersonFullName.Text)) {
				labelName.ForeColor = Color.Black;
			} else {
				toolStripStatus.Text += "[Error \"FullName\". Ex: Іванов Іван Іванович] ";
				labelName.ForeColor = Color.Red;
				countError++;
			}


			if (comboBoxPersonGender.SelectedIndex == -1) {
				labelGender.ForeColor = Color.Red;
				countError++;
				toolStripStatus.Text += "[Error \"Gender\": not selected]";
			} else {
				labelGender.ForeColor = Color.Black;
			}


			string number = textBoxPatientNumber.Text.DeleteChar(' ');

			if (RTypeBlood.IsMatch(comboBoxPatientBlood.Text)) {
				labelBlood.ForeColor = Color.Black;
			} else {
				labelBlood.ForeColor = Color.Red;
				countError++;
				toolStripStatus.Text += "[Error \"Blood type\": not selected]";
			}

			if (comboBoxHealth.SelectedIndex == -1) {
				labelHealth.ForeColor = Color.Red;
				countError++;
				toolStripStatus.Text += "[Error \"Health status\": not selected]";
			} else {
				labelHealth.ForeColor = Color.Black;
			}

			if (countError == 0) {
				if (isEditor) {
					Person.FullName = textBoxPersonFullName.Text;
					Person.Comment = textBoxPersonDescription.Text;
					Person.DateBirth = dateTimePickerDateBirthday.Value;
					Person.DiseaseOnsetDate = dateTimePickerOnsetDate.Value;
					Person.Gender = (Entities.Enum.Gender)comboBoxPersonGender.SelectedIndex;
					Person.HealthStatus = (Entities.Enum.HealthStatus)comboBoxHealth.SelectedIndex;
					Person.PhoneNumber = number;
					Person.ResidenceAddress = textBoxPersonAddress.Text;
					Person.TypeBlood = comboBoxPatientBlood.Text;
				} else {
					Person = new Person() {
						FullName = textBoxPersonFullName.Text,
						Comment = textBoxPersonDescription.Text,
						DateBirth = dateTimePickerDateBirthday.Value,
						DiseaseOnsetDate = dateTimePickerOnsetDate.Value,
						Gender = (Entities.Enum.Gender)comboBoxPersonGender.SelectedIndex,
						HealthStatus = (Entities.Enum.HealthStatus)comboBoxHealth.SelectedIndex,
						PhoneNumber = number,
						ResidenceAddress = textBoxPersonAddress.Text,
						TypeBlood = comboBoxPatientBlood.Text
					};				
				}

				this.Close();
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
