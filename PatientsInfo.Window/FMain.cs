using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PatientsInfo.Entities;
using PatientsInfo.Entities.Data;
using FileIO;

namespace PatientsInfo.Window {
	public partial class FMain : Form {
		DataContext dataContext;

		ulong? IDEntity;
		int Row = 0;

		TabPage[] _tabPage;

		public FMain(DataContext dataContext) {
			this.dataContext = dataContext;
			InitializeComponent();

			UpdateTableDisease();
			UpdateTablePeople();

			CreateTablePatients();

			_tabPage = new TabPage[] {
				tabPagePeople,
				tabPageDiseases,
				tabPagePatients
			};
		}

		public void CreateTablePatients() {

			dataGridViewPatients.Columns.Add("Id", "Id");
			dataGridViewPatients.Columns.Add("PersonName", "PersonName");
			dataGridViewPatients.Columns.Add("DiseaseName", "DiseaseName");
			dataGridViewPatients.Columns.Add("IsSick", "Sick");
			dataGridViewPatients.Columns.Add("Comment", "Comment");

			UpdateTablePatients();
		}

		public void UpdateTablePatients() {
			dataGridViewPatients.Rows.Clear();
			foreach (var el in dataContext.dataSet.Patients) {
				dataGridViewPatients.Rows.Add(new object[] { el.Id, el.Person?.FullName, el.disease.Name, el.IsSick.ToString(), el.Comment });
			}
			UpdateLabelCount();
		}

		public void UpdateTableDisease() {
			dataGridViewDiseases.DataSource = typeof(List<Disease>);
			dataGridViewDiseases.DataSource = dataContext.dataSet.Diseases;
			UpdateLabelCount();
		}

		public void UpdateTablePeople() {
			dataGridViewPeople.DataSource = typeof(List<Person>);
			dataGridViewPeople.DataSource = dataContext.dataSet.People;
			UpdateLabelCount();
		}

		public void UpdateLabelCount() {
			toolStripStatusLabelCountInfo.Text = $"People: {dataContext.People.Count()} | Diseases: {dataContext.Diseases.Count()} | Patients {dataContext.Patients.Count()}";
		}

		public void BottomEnablePeople(bool enable) {
			toolStripButtonPeopleDelete.Enabled =
				toolStripButtonPeopleClone.Enabled =
					toolStripButtonPeopleEdit.Enabled = enable;
		}

		public void BottomEnableDiseases(bool enable) {
			toolStripButtonDiseasesClone.Enabled =
				toolStripButtonDiseasesEdit.Enabled =
					toolStripButtonDiseasesDelete.Enabled = enable;
		}
		public void BottomEnablePatients(bool enable) {
			toolStripButtonPatientsClone.Enabled =
				toolStripButtonPatientsEditor.Enabled =
					toolStripButtonDeletePatients.Enabled = enable;
		}

		public void UpdateAllTable() {
			UpdateTablePatients();
			UpdateTableDisease();
			UpdateTablePeople();
		}

		private void dataGridViewPeople_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e) {
			bool status = Functional.Sort.People.statusSort[e.ColumnIndex] = !Functional.Sort.People.statusSort[e.ColumnIndex];

			Functional.Sort.People.actions[e.ColumnIndex, status ? 0 : 1]();

			dataGridViewPeople.DataSource = Functional.Sort.People.people.ToList();

		}


		private void dataGridViewDiseases_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			Functional.Sort.Diseases.ActionSort(dataGridViewDiseases, e.ColumnIndex);
		}

		private void dataGridViewPatients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			IDEntity = Convert.ToUInt64(dataGridViewPatients[0, e.RowIndex].Value);
			BottomEnablePatients(true);
			Row = e.RowIndex;
		}

		private void dataGridViewPeople_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			IDEntity = Convert.ToUInt64(dataGridViewPeople[0, e.RowIndex].Value);
			BottomEnablePeople(true);
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {

			Person person = dataContext.People.FirstOrDefault(el => el.Id == IDEntity);

			var patientsDelete = dataContext.Patients.Where(el => el.Person == person);

			var resMessageStatus = MessageBox.Show($"Видалити об'єкт{person.FullName} та залежні записи: {string.Join(", ", patientsDelete.Select(el => el.disease?.Name))}", string.Empty, MessageBoxButtons.YesNo);

			if (resMessageStatus == DialogResult.Yes) {
				foreach (var el in patientsDelete.ToList()) {
					dataContext.dataSet.Patients.Remove(el);
				}
				dataContext.dataSet.People.Remove(person);
				IDEntity = null;

				BottomEnablePeople(false);

				UpdateTablePeople();

				dataGridViewPatients.Rows.Clear();
				foreach (var el in dataContext.dataSet.Patients) {
					dataGridViewPatients.Rows.Add(new object[] { el.Id, el.Person?.FullName, el.disease.Name, el.IsSick.ToString(), el.Comment });
				}
			}

		}

		private void toolSripButtonDiseasesDelete_Click(object sender, EventArgs e) {
			Disease disease = dataContext.Diseases.FirstOrDefault(el => el.Id == IDEntity);

			var patientsDelete = dataContext.Patients.Where(el => el.disease == disease);

			var resMessageStatus = MessageBox.Show($"Видалити об'єкт {disease.Name} та залежні записи - {patientsDelete.Count()}", string.Empty, MessageBoxButtons.YesNo);

			if (resMessageStatus == DialogResult.Yes) {
				foreach (var el in patientsDelete.ToList()) {
					dataContext.dataSet.Patients.Remove(el);
				}
				dataContext.dataSet.Diseases.Remove(disease);
				IDEntity = null;

				BottomEnableDiseases(false);

				UpdateTableDisease();
				UpdateTablePatients();
			}
		}

		private void dataGridViewDiseases_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			IDEntity = Convert.ToUInt64(dataGridViewPeople[0, e.RowIndex].Value);
			BottomEnableDiseases(true);
		}

		private void toolStripButtonDeletePatients_Click(object sender, EventArgs e) {
			Patient patient = dataContext.Patients.FirstOrDefault(el => el.Id == IDEntity);

			var resMessageStatus = MessageBox.Show($"Видалити об'єкт?", string.Empty, MessageBoxButtons.YesNo);

			if (resMessageStatus == DialogResult.Yes && patient != null) {
				dataContext.dataSet.Patients.Remove(patient);

				dataGridViewPatients.Rows.RemoveAt(Row);

			}
			BottomEnablePatients(false);
			IDEntity = null;
		}

		private void clearAllDataToolStripMenuItem_Click(object sender, EventArgs e) {
			dataContext.Clear();

			UpdateAllTable();
		}

		private void createTestDataToolStripMenuItem_Click(object sender, EventArgs e) {
			dataContext.CreateTestingData();

			UpdateAllTable();
		}

		private void toolStripButtonDiseasesCreate_Click(object sender, EventArgs e) {
			(new FCreateDisease(dataContext.dataSet)).ShowDialog();
			UpdateTableDisease();
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			new FCreatePerson().ShowDialog();
			if (FCreatePerson.Person != null) {
				dataContext.dataSet.People.Add(FCreatePerson.Person);
				UpdateTablePeople();			
			}
		}


		private void toolStripButtonDiseasesClone_Click(object sender, EventArgs e) {
			Disease disease = dataContext.Diseases.FirstOrDefault(el => el.Id == IDEntity);
			dataContext.dataSet.Diseases.Add(disease.Clone());
			UpdateTableDisease();
		}

		private void toolStripButtonPatientsClone_Click(object sender, EventArgs e) {
			Patient patient = dataContext.Patients.FirstOrDefault(el => el.Id == IDEntity);
			dataContext.dataSet.Patients.Add(patient.Clone());
			UpdateTablePatients();
		}

		private void BasicControl_SelectedIndexChanged(object sender, EventArgs e) {
			BottomEnablePeople(false);
			BottomEnableDiseases(false);
			BottomEnablePatients(false);

			IDEntity = 0;
		}


		private void BasicControl_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				if (BasicControl.GetTabRect(BasicControl.SelectedIndex).Contains(new Point(e.X, e.Y))) {
					contextMenuStrip1.Show(BasicControl, e.X, e.Y);
				}
			}
		}


		private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
			BasicControl.TabPages.Remove(BasicControl.SelectedTab);
		}


		private void openPeopleToolStripMenuItem_Click(object sender, EventArgs e) {
			if (BasicControl.TabPages.IndexOf(_tabPage[0]) == -1)
				BasicControl.TabPages.Add(_tabPage[0]);
		}

		private void openDiseasesToolStripMenuItem_Click(object sender, EventArgs e) {
			if (BasicControl.TabPages.IndexOf(_tabPage[1]) == -1)
				BasicControl.TabPages.Add(_tabPage[1]);
		}

		private void openPacientToolStripMenuItem_Click(object sender, EventArgs e) {
			if (BasicControl.TabPages.IndexOf(_tabPage[2]) == -1)
				BasicControl.TabPages.Add(_tabPage[2]);
		}


		private void openAllTabsToolStripMenuItem_Click(object sender, EventArgs e) {
			for (int i = 0; i < _tabPage.Length; i++) {
				if (BasicControl.TabPages.IndexOf(_tabPage[i]) == -1)
					BasicControl.TabPages.Add(_tabPage[i]);
			}
		}

		private void closeAllTabsToolStripMenuItem_Click(object sender, EventArgs e) {
			BasicControl.TabPages.Clear();
		}

		private void closeAllTabsButActiveToolStripMenuItem_Click(object sender, EventArgs e) {
			var temp = BasicControl.SelectedTab;
			BasicControl.TabPages.Clear();
			BasicControl.TabPages.Add(temp);
		}

		private void toolStripButtonPeopleEdit_Click(object sender, EventArgs e) {
			Person person = dataContext.People.FirstOrDefault(el => el.Id == IDEntity);
			(new FCreatePerson(person)).ShowDialog();
		}

		private void toolStripButton1_Click_1(object sender, EventArgs e) {
			Person person = dataContext.People.FirstOrDefault(el => el.Id == IDEntity);
			dataContext.dataSet.People.Add(person.Clone());
			UpdateTablePeople();
		}

		private void toolStripButtonDiseasesEdit_Click(object sender, EventArgs e) {
			Disease d = dataContext.Diseases.FirstOrDefault(el => el.Id == IDEntity);
			(new FCreateDisease(d)).ShowDialog();
			UpdateTableDisease();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			var status = MessageBox.Show("Do you really want to quit?", "", MessageBoxButtons.OKCancel);
			if (status == DialogResult.OK) {
				this.Close();
			}
		}

		private void newFileToolStripMenuItem_Click(object sender, EventArgs e) {
			var status = MessageBox.Show("Do you really want to create a new table, leaving the old one?", "", MessageBoxButtons.OKCancel);
			if (status == DialogResult.OK) {
				Patient.KeyCount = 1;
				Person.PersonalNumberCount = 1;
				Disease.IDCounter = 1;
				dataContext.Clear();
				UpdateAllTable();
			}
		}

		private void toolStripButtonPatientsCreate_Click(object sender, EventArgs e) {
			(new FCreatePatient(dataContext)).ShowDialog();
			UpdateTablePatients();
		}

		private void toolStripButton1_Click_2(object sender, EventArgs e) {
			Patient p = dataContext.Patients.FirstOrDefault(el => el.Id == IDEntity);
			(new FCreatePatient(dataContext, p)).ShowDialog();
			UpdateTablePatients();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			(new AboutBox1()).ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e) {
			var filePath = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
				openFileDialog.Filter = "XML (*.xml)|*.xml|Binary (*.bs)|*.bs";
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK) {
					//Get the path of specified file
					AppSettings.Settings.lastFilePath = filePath = openFileDialog.FileName;
					//Read the contents of the file into a stream

					try {
						switch (Path.GetExtension(openFileDialog.FileName)) {
							case ".xml":
								dataContext.Restart();
								FileIO.FileIO.xml.Load(dataContext.dataSet, filePath);
								break;
							case ".bs":
								dataContext.Restart();
								FileIO.FileIO.binary.Load(dataContext.dataSet, filePath);
								break;
						}
					} catch (Exception ex) {
						DialogResult res = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					UpdateAllTable();
				}
			}
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			var filePath = string.Empty;
			using (SaveFileDialog dialog = new SaveFileDialog()) {
				dialog.Filter = "XML (*.xml)|*.xml|Binary (*.bs)|*.bs";
				dialog.RestoreDirectory = true;

				if (dialog.ShowDialog() == DialogResult.OK) {
					AppSettings.Settings.lastFilePath = filePath = dialog.FileName;
				}
			}

			try {
				switch (Path.GetExtension(filePath)) {
					case ".xml":
						FileIO.FileIO.xml.Save(dataContext.dataSet, filePath);
						break;
					case ".bs":
						FileIO.FileIO.binary.Save(dataContext.dataSet, filePath);
						break;
				}
			}
			catch (Exception ex) {
				DialogResult res = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void closePeopleToolStripMenuItem_Click(object sender, EventArgs e) {
			BasicControl.TabPages.Remove(_tabPage[0]);
		}

		private void closeDiseasesToolStripMenuItem_Click(object sender, EventArgs e) {
			BasicControl.TabPages.Remove(_tabPage[1]);
		}

		private void closePacientToolStripMenuItem_Click(object sender, EventArgs e) {
			BasicControl.TabPages.Remove(_tabPage[2]);
		}
	}
}
