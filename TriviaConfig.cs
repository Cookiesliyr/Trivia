using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Trivia {
	// Used Tokens: u01f0 to u01ff
	public class TriviaConfig {
		public Dictionary<string, Quiz> QuizAr = new Dictionary<string, Quiz>();
		public List<string> SelectedQuiz = new List<string>();
		public List<string> CatAr = new List<string>();
		public List<string> BGAr = new List<string>();
		public List<string> MusicAr = new List<string>();

		public TriviaConfig () { }

		public TriviaConfig(string TData) {
			int k = 0, z = 0; ; string DataPart, TempS1;
			DataPart = ShFun.Token(TData, ref k, '\u01f1'); 
			while ((TempS1=ShFun.Token(DataPart, ref z, '\u01f0'))!="") {
				int Z = 0; CatAr.Add(ShFun.Token(TempS1, ref Z, '\u01f0')); } z=0;
			DataPart = ShFun.Token(TData, ref k, '\u01f1'); 
			while ((TempS1=ShFun.Token(DataPart, ref z, '\u01f0'))!="") {
				int Z = 0; SelectedQuiz.Add(ShFun.Token(TempS1, ref Z, '\u01f0')); } z=0;
		}

		public string Save (){
			StringBuilder SB = new StringBuilder();
			foreach (string CS in CatAr) SB.Append(CS+"\u01f0"); SB.Append("\u01f1"); 
			foreach (string CS in SelectedQuiz) SB.Append(CS+"\u01f0"); SB.Append("\u01f1"); 
			return SB.ToString();
		}

		public static TriviaConfig LoadFromFile () {
			string TriviaConfigData = "";

            try {
                StreamReader FileReader = new StreamReader(Application.StartupPath + "\\Config.txt");
                TriviaConfigData = FileReader.ReadToEnd();
                FileReader.Close();
				return new TriviaConfig(TriviaConfigData);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "File issue");
                Console.WriteLine(e.Message);
            }
			return null;
		}

		public void LoadQuizzes () {
			string[] filePaths = Directory.GetFiles(Application.StartupPath+"Quiz\\");
			foreach (string FS in filePaths) {
				try {
					StreamReader FileReader = new StreamReader(FS);
					string QuizData = FileReader.ReadToEnd();
					FileReader.Close();
					//System.Diagnostics.Debug.WriteLine(FS);
					int k = 0;
					QuizAr.Add(ShFun.Token(Path.GetFileName(FS), ref k, '.'), new Quiz(QuizData));
				
				} catch (Exception e) {
					MessageBox.Show(e.Message, "File issue");
					Console.WriteLine(e.Message);
				}
			}
		}
		public void SaveToFile () {
			try {
                StreamWriter SW = new StreamWriter (Application.StartupPath + "\\Config.txt");
				SW.Write(Save());
                SW.Close();
            } catch (IOException ex) { Console.WriteLine(ex.Message); } 
		}
	}
}
