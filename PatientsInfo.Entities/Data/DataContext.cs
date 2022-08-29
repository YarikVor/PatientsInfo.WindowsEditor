using System.Collections.Generic;

using Methods;

namespace PatientsInfo.Entities.Data {
	public partial class DataContext {
		public readonly DataSet dataSet = new DataSet();

		public ICollection<Person> People {
			get { return dataSet.People; }
		}

		public ICollection<Patient> Patients {
			get => dataSet.Patients;
		}

		public ICollection<Disease> Diseases {
			get => dataSet.Diseases;
		}

		public override string ToString() {
			return string.Concat("Інформація про \"Облік пацієнтів\"",
				People.ToLineList("Особи"),
				Patients.ToLineList("Пацієнти"),
				Diseases.ToLineList("Захворювання"));
		}
		/// <summary>
		/// Очищення вмісту сутностей
		/// </summary>
		public void Clear() {
			People.Clear();
			Patients.Clear();
			Diseases.Clear();
		}
		/// <summary>
		/// Створення тестових даних
		/// </summary>
		public void CreateTestingData() {
			CreateDiseases();
			CreatePeople();
			CreatePatients();
		}

		public void Restart() {
			Patient.KeyCount = 1;
			Person.PersonalNumberCount = 1;
			Disease.IDCounter = 1;
			this.Clear();
		}
	}
}
