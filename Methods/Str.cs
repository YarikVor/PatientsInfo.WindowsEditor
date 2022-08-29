using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods {
	public static class Str {
		public static string DeleteChar(this string str, char c = ' ') {
			StringBuilder sb = new StringBuilder(str.Length);
			for (int i = 0; i < str.Length; i++) {
				if (str[i] != c) {
					sb.Append(str[i]);
				}
			}
			return sb.ToString();
		}

		public static int Approximately(this string orig, string input) {
			int count = 0;
			orig = orig.ToLower();
			input = input.ToLower();
			int keyChar = 0;
			for (int i = 0; i < input.Length; i++) {
				for (int j = keyChar; j < orig.Length; j++) {
					if (orig[j] == input[i]) {
						count++;
						keyChar = j;
						break;
					}
				}
			}
			return count;
		}
	}
}
