using System;
using System.Windows.Forms;
using PatientsInfo.Entities.Data;
namespace PatientsInfo.Window {
	static class Program {
		public static DataContext dataContext = new DataContext();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			dataContext.CreateTestingData();
			Functional.Sort.People.people = dataContext.dataSet.People;
			Functional.Sort.Diseases.diseases = dataContext.dataSet.Diseases;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FMain(dataContext));
			//Application.Run(new FCreatePatient(dataContext));
		}
	}
}
