using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PatientsInfo.Entities;

namespace Functional {
	public static partial class Sort {
		public static class People {
			public static IEnumerable<Person> people { get; set; }
			public static readonly bool[] statusSort = new bool[9];
			public static readonly Action[,] actions = {
				{OrderById, OrderByDescendingId},
				{OrderByFullName, OrderByDescendingFullName},
				{OrderByDateBirth, OrderByDescendingDateBirth},
				{OrderByDiseaseOnsetDate, OrderByDescendingDiseaseOnsetDate},
				{OrderByGender, OrderByDescendingGender},
				{OrderByHealthStatus, OrderByDescendingHealthStatus},
				{OrderByPhoneNumber, OrderByDescendingPhoneNumber},
				{OrderByResidenceAddress, OrderByDescendingResidenceAddress},
				{OrderByTypeBlood, OrderByDescendingTypeBlood},
			};

			public static void ActionSort(DataGridView dgv, int columnIndex) {
				if (columnIndex < actions.Length) {
					bool status = statusSort[columnIndex] = statusSort[columnIndex];

					actions[columnIndex, status ? 0 : 1]();

					dgv.DataSource = people.ToList();
				}
			}

			public static void OrderById() => people = people.OrderBy(e => e.Id);
			public static void OrderByFullName() => people = people.OrderBy(e => e.FullName);
			public static void OrderByDateBirth() => people = people.OrderBy(e => e.DateBirth);
			public static void OrderByDiseaseOnsetDate() => people = people.OrderBy(e => e.DiseaseOnsetDate);
			public static void OrderByGender() => people = people.OrderBy(e => e.FullName).OrderBy(e => e.Gender);
			public static void OrderByHealthStatus() => people = people.OrderBy(e => e.HealthStatus);
			public static void OrderByPhoneNumber() => people = people.OrderBy(e => e.PhoneNumber);
			public static void OrderByResidenceAddress() => people = people.OrderBy(e => e.ResidenceAddress);
			public static void OrderByTypeBlood() => people = people.OrderBy(e => e.TypeBlood);

			public static void OrderByDescendingId() => people = people.OrderByDescending(e => e.Id);
			public static void OrderByDescendingFullName() => people = people.OrderByDescending(e => e.FullName);
			public static void OrderByDescendingDateBirth() => people = people.OrderByDescending(e => e.DateBirth);
			public static void OrderByDescendingDiseaseOnsetDate() => people = people.OrderByDescending(e => e.DiseaseOnsetDate);
			public static void OrderByDescendingGender() => people = people.OrderByDescending(e => e.FullName).OrderByDescending(e => e.Gender);
			public static void OrderByDescendingHealthStatus() => people = people.OrderByDescending(e => e.HealthStatus);
			public static void OrderByDescendingPhoneNumber() => people = people.OrderByDescending(e => e.PhoneNumber);
			public static void OrderByDescendingResidenceAddress() => people = people.OrderByDescending(e => e.ResidenceAddress);
			public static void OrderByDescendingTypeBlood() => people = people.OrderByDescending(e => e.TypeBlood);
		}

		public static class Diseases {
			public static IEnumerable<Disease> diseases { get; set; }
			public static readonly bool[] statusSort = new bool[2];

			public static readonly Action[,] actions = {
				{OrderByName, OrderByDescendingName},
				{OrderByCodeICD, OrderByDescendingCodeICD}
			};

			public static void ActionSort(DataGridView dgv, int columnIndex) {
				if (columnIndex < statusSort.Length) {
					bool status = statusSort[columnIndex] = !statusSort[columnIndex];

					actions[columnIndex, status ? 0 : 1]();

					dgv.DataSource = diseases.ToList();
				}
			}

			public static void OrderByName() => diseases = diseases.OrderBy(e => e.Name);
			public static void OrderByCodeICD() => diseases = diseases.OrderBy(e => e.CodeICD);
			public static void OrderByDescendingName() => diseases = diseases.OrderByDescending(e => e.Name);
			public static void OrderByDescendingCodeICD() => diseases = diseases.OrderByDescending(e => e.CodeICD);
		}
	}
}
