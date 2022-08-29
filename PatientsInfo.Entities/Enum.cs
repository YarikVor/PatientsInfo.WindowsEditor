namespace PatientsInfo.Entities {
	public static class Enum {
		public static string[] HealthStatusName = {
			"Excellent",
			"Good",
			"Satisfactory",
			"Moderate",
			"Severe",
			"Extremely"
		};



		public static string[] GenderName = {
			"Male",
			"Female"
		};



		/// <summary>
		/// Стать
		/// </summary>
		public enum Gender : byte{
			Male,  // Чоловік
			Female // Жінка
		};

		/// <summary>
		/// Життєві показники
		/// </summary>
		public enum HealthStatus : byte {
			/// <summary> Відмінний </summary>
			Excellent,
			/// <summary> Добрий </summary>
			Good,
			/// <summary> Задовільний </summary>
			Satisfactory,
			/// <summary> Середньої важкості </summary>
			Moderate,     // Середньої важкості
			/// <summary> Важкий </summary>
			Severe,
			/// <summary> Вкрай важкий </summary>
			Extremely     
		};

		public static bool TryParseHealthStatus(this ref HealthStatus status, string text) {
			for (int i = 0; i < HealthStatusName.Length; i++) {
				if (text == HealthStatusName[i]){
					status = (HealthStatus)i;
					return true;
				}
			}
			return false;
		}

		public static bool TryParseGender(this ref Gender g, string text) {
			for (int i = 0; i < GenderName.Length; i++) {
				if (text == GenderName[i]) {
					g = (Gender)i;
					return true;
				}
			}
			return false;
		}




		public static string ToStringUA(this HealthStatus healthStatus) {
			if (healthStatus >= 0 && (int)healthStatus < HealthStatusName.Length) return HealthStatusName[(int)healthStatus];
			return "---";
		}

		public static string ToStringUA(this Gender gender) {
			if (gender >= 0 && (int)gender < GenderName.Length) return GenderName[(int)gender];
			return "---";
		}
	}
}
