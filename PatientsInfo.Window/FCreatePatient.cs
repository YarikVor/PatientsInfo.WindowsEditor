using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientsInfo.Entities.Data;
using PatientsInfo.Entities;
using Methods;
namespace PatientsInfo.Window {
	public partial class FCreatePatient : Form {
		System.Timers.Timer timerPerson = new System.Timers.Timer(1000);
		System.Timers.Timer timerDisease = new System.Timers.Timer(1000);
		Person person = null;
		Disease disease = null;

		Person[] listHelpPeople;
		Disease[] listHelpDiseases;
		Patient patient;
		DataContext dataContext;

		bool isEditor = false;
		public FCreatePatient(DataContext dataContext) : this() {
			this.dataContext = dataContext;
			labelTextId.Text = Patient.KeyCount.ToString();
		}

		public FCreatePatient(DataContext dataContext, Patient patient) : this() {
			this.dataContext = dataContext;
			isEditor = true;
			this.patient = patient;
			person = patient.Person;
			disease = patient.disease;
			this.Text = labelHeader.Text = toolStripStatus.Text = "Edit Patients";
			labelTextId.Text = patient.Id.ToString();
			textBoxDiseases.Text = disease.Name;
			textBoxPerson.Text = person.FullName;
			textBoxPersonDescription.Text = person.Comment;
			if (patient.IsSick == null) {
				radioButtonUnknown.Checked = true;
			} else if (patient.IsSick == true) {
				radioButtonYes.Checked = true;
			} else {
				radioButtonUnknown.Checked = true;
			}
		}

		private FCreatePatient() {
			InitializeComponent();

			timerPerson.Elapsed += new System.Timers.ElapsedEventHandler(EventEditorPerson);
			timerDisease.Elapsed += new System.Timers.ElapsedEventHandler(EventEditorDisease);
		}
		private void EventEditorPerson(object sender, System.Timers.ElapsedEventArgs e) {
			labelPerson.Invoke(new Action(ShowPerson));
		}

		private void EventEditorDisease(object sender, System.Timers.ElapsedEventArgs e) {
			labelPerson.Invoke(new Action(ShowDisease));
		}

		private void ShowPerson() {
			if (string.IsNullOrEmpty(textBoxPerson.Text) == false) {
				listBoxPeople.Items.Clear();
				listHelpPeople = dataContext.People.Reverse().OrderByDescending(el => el.FullName.Approximately(textBoxPerson.Text)).Take(2).ToArray();
				listBoxPeople.Items.AddRange(listHelpPeople.Select(el => el.FullName).ToArray());
			}
			timerPerson.Stop();
		}

		private void ShowDisease() {
			if (string.IsNullOrEmpty(textBoxDiseases.Text) == false) {
				listBoxDiseases.Items.Clear();
				listHelpDiseases = dataContext.Diseases.Reverse().OrderByDescending(el => el.Name.Approximately(textBoxDiseases.Text)).Take(2).ToArray();
				listBoxDiseases.Items.AddRange(listHelpDiseases.Select(el => el.Name).ToArray());
			}
			timerDisease.Stop();
		}


		private void textBox1_TextChanged(object sender, EventArgs e){
			timerPerson.Stop();
			timerPerson.Start();
		}

		private void textBoxPersonFullName_KeyDown(object sender, KeyEventArgs e) {
			timerPerson.Stop();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			person = listHelpPeople[listBoxPeople.SelectedIndex];
			textBoxPerson.Text = person.FullName;
		}

		private void listBoxDiseases_SelectedIndexChanged(object sender, EventArgs e) {
			disease = listHelpDiseases[listBoxDiseases.SelectedIndex];
			textBoxDiseases.Text = disease.Name;
		}

		private void textBoxDiseases_KeyDown(object sender, KeyEventArgs e) {
			timerDisease.Stop();
		}

		private void textBoxDiseases_TextChanged(object sender, EventArgs e) {
			timerDisease.Stop();
			timerDisease.Start();
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void toolStripButtonPersonAdd_Click(object sender, EventArgs e) {
			int countError = 0;
			toolStripStatus.ForeColor = Color.Red;
			toolStripStatus.Text = "";

			if (disease == null) {
				labelDisease.ForeColor = Color.Red;
				countError++;
				toolStripStatus.Text += "[Error \"disease\"] ";
			} else {
				labelDisease.ForeColor = Color.Black;
			}

			if (person == null) {
				labelPerson.ForeColor = Color.Red;
				countError++;
				toolStripStatus.Text += "[Error \"person\"] ";
			} else {
				labelPerson.ForeColor = Color.Black;
			}

			if (countError == 0) {
				if (isEditor) {
					patient.disease = disease;
					patient.IsSick = radioButtonYes.Checked ? true : radioButtonNo.Checked ? false : (bool?)null;
					patient.Person = person;
					patient.Comment = textBoxPersonDescription.Text;
				} else {
					dataContext.Patients.Add(new Patient() {
						IsSick = radioButtonYes.Checked ? true : radioButtonNo.Checked ? false : (bool?)null,
						disease = this.disease,
						Person = person,
						Comment = textBoxPersonDescription.Text
					});
				}
				this.Close();
			}
		}
	}
}
