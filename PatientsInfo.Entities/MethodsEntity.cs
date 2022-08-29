using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsInfo.Entities {
	public static partial class MethodsEntity {
		public static Person Clone(this Person o) {
			return new Person() {
				Comment = o.Comment,
				TypeBlood = o.TypeBlood,
				DateBirth = o.DateBirth,
				DiseaseOnsetDate = o.DiseaseOnsetDate,
				FullName = o.FullName ,
				Gender = o.Gender ,
				HealthStatus = o.HealthStatus ,
				PhoneNumber = o.PhoneNumber,
				ResidenceAddress = o.ResidenceAddress
			};
		}

		public static Disease Clone(this Disease o) {
			return new Disease() {
				Name = o.Name,
				Description = o.Description,
				CodeICD = o.CodeICD
			};
		}

		public static Patient Clone(this Patient o) {
			return new Patient() {
				Comment = o.Comment,
				disease = o.disease,
				IsSick = o.IsSick,
				Person = o.Person
			};
		}
	}
}
