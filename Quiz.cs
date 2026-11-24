using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trivia {
	public class Quiz {
		public Dictionary<string, Question> Questions = new Dictionary<string, Question>();
		public string QuizID;
		public Quiz () {}
		public Quiz(string QuizData) {
			int k = 0, z = 0; string DataPart, TempS1;
			QuizID   = ShFun.Token(QuizData, ref k, '\u01f0');
			DataPart = ShFun.Token(QuizData, ref k, '\u01f3'); z=0;
			while ((TempS1 = ShFun.Token(DataPart, ref z, '\u01f2')) != ""){
				int Z = 0;
				Questions.Add(ShFun.Token(TempS1, ref Z, '\u01f0'), new Question(ShFun.Token(TempS1, ref Z, '\u01f2')));
			}
		}

		public string Save () {
			StringBuilder SB = new StringBuilder();
			SB.Append(QuizID+"\u01f0"); 
			foreach (KeyValuePair<string, Question> QK in Questions)
				SB.Append(QK.Key + '\u01f0' + QK.Value.Save() + '\u01f2'); SB.Append('\u01f3');
			return SB.ToString();
		}

		public void SaveToFile () {
			try {
                StreamWriter SW = new StreamWriter (Application.StartupPath + "\\Quiz\\" + QuizID + ".qiz" );
				SW.Write(Save());
                SW.Close();
            } catch (IOException ex) { Console.WriteLine(ex.Message); } 
		}
	}

	public class Question {
		public List<string> Choices = new List<string>();
		public string ID, Quest, Category, Type;
		public int Diff, CorrChoice; public bool BoolValue;

		public Question () {}

		public Question(string id, string quest, string category, int diff, string type, bool isRNG, int CorrectChoice, List<string> choices) {
			ID=id; Quest=quest; Category=category; Diff=diff;Type=type; BoolValue=isRNG; CorrChoice=CorrectChoice;
			foreach (string CS in choices) Choices.Add(CS);
		}

 		public Question (string QuestData) {
			int k = 0, z = 0; string DataPart, TempS1;
			//ShFun.Token(QuestData, ref k, '\u01f0');
			ID		 = ShFun.Token(QuestData, ref k, '\u01f0');
			Quest    = ShFun.Token(QuestData, ref k, '\u01f0');
			Category = ShFun.Token(QuestData, ref k, '\u01f0');
			Diff     = int.Parse (ShFun.Token(QuestData, ref k, '\u01f0'));
			Type	 = ShFun.Token(QuestData, ref k, '\u01f0');
			BoolValue = bool.Parse (ShFun.Token(QuestData, ref k, '\u01f0'));
			CorrChoice = int.Parse (ShFun.Token(QuestData, ref k, '\u01f0'));
			if (Type=="Bool") return;
			DataPart = ShFun.Token(QuestData, ref k, '\u01f1'); z=0;
			while ((TempS1=ShFun.Token(DataPart, ref z, '\u01f0'))!="") {
				int Z = 0; Choices.Add(ShFun.Token(TempS1, ref Z, '\u01f0')); }

		}

		public string Save () {
			StringBuilder SB = new StringBuilder();
			SB.Append(ID+"\u01f0"+Quest+"\u01f0"+Category+"\u01f0" + Diff + "\u01f0" + Type + "\u01f0" + BoolValue + "\u01f0" + CorrChoice+ "\u01f0");
			if (Type=="Bool") return SB.ToString();
			foreach (string CK in Choices) SB.Append(CK+"\u01f0"); SB.Append("\u01f1");
			return SB.ToString();
		}

	}
}
