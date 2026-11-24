using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia {
	internal class ShFun {
		static Random RNG = new Random();
		public static string Token(string s, ref int i, char c) {
            string ST = "";
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
                i += 1;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }
            
            return ST;
        }

        public static string Peek(string s, ref int i, char c) {
            string ST = "";
            int j = i;
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
                i = j;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return ST;
        }

        public static string Peek(string s, char c) {
            string ST = "";
            int i = 0;
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return ST;
        }

		public static List<string> ShuffleList (List<string> TargetList){
			List<string> TL = new List<string>();
			int N = TargetList.Count;
			while (N > 0) { 
				int x = RNG.Next(0, N); TL.Add(TargetList[x]); TargetList.RemoveAt(x); N--;   
			}

			return TL;
		}
	}
}
