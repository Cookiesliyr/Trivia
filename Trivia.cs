using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivia.Properties;

namespace Trivia {

	public partial class Trivia: Form {
		static Random RNG = new Random();
		public List<Button> ButtAr = new List<Button>();
		public Dictionary<Tuple<string, string>, string> QLog = new Dictionary<Tuple<string, string>, string>();
		TriviaConfig TG; Question CurQuestion; Form1 TF;
		List<string> AcceptedCategories = new List<string>();
		List<string> AcceptedTypes = new List<string>();

		string SQ, SU;
		int Corr = 0, QM = 0, QuestCoutner = 0, Score = 0, MaxWrongAnswers = -1, WrongAnswers = 0, GameTime, QuestTime, TT2 = 5;

		public Trivia() {
			InitializeComponent(); TG=Form1.Game; TF=Program.TriviaForm; TF.Enabled=false;
			GenerateButton("True"); GenerateButton("False");
			if (TF.QTCB1.Checked) AcceptedTypes.Add("Choice");
			if (TF.QTCB2.Checked) AcceptedTypes.Add("Type");
			if (TF.QTCB3.Checked) AcceptedTypes.Add("Bool");
			if (TF.DCB2.Checked) { timer1.Enabled=true; QuestTime=(int)TF.QTL1.Value; }
			if (TF.DCB3.Checked) { timer1.Enabled=true; GameTime=(int)TF.QTL2.Value; }
			if (TF.DCB4.Checked) { MaxWrongAnswers=(int)TF.QTL2.Value; }
		}

		public void GenerateButton(string Caption) {
			ButtAr.Add(new Button { Name="B"+ButtAr.Count, Text=Caption, TextAlign=ContentAlignment.MiddleCenter, BackColor=Color.MediumTurquoise, Size=new Size(378, 52), FlatStyle=FlatStyle.Flat, Location=new Point((ButtAr.Count%2==0 ? 12 : 410), 365+((ButtAr.Count/2)*60)) });
			this.Controls.Add(ButtAr.Last()); ButtAr.Last().Click+=Butt_Click;
		}

		public void StartGame() {
			int QN = 0;
			foreach (string SK in TG.SelectedQuiz) QN+=TG.QuizAr[SK].Questions.Count;
			QM=Math.Min(QN, (int)TF.QuestNum.Value);
			PickQuestion();
		}

		private void Butt_Click(object sender, EventArgs e) {
			SubmitAnswer(((Button)sender).Name=="B"+Corr, ((Button)sender).Text);

		}

		private string PrintLog() {
			StringBuilder SB = new StringBuilder();
			foreach (KeyValuePair<Tuple<string, string>, string> LK in QLog)
				SB.Append(TG.QuizAr[LK.Key.Item1].Questions[LK.Key.Item2].Quest+"  User Answer: "+LK.Value+"\r\n");
			return SB.ToString();
		}

		private void Enter_Click(object sender, EventArgs e) {
			string AS = Answer.Text.Trim().ToLower();
			foreach (string CK in CurQuestion.Choices) {
				if (CurQuestion.BoolValue) {
					if (CK.Contains(AS)) {
						SubmitAnswer(true, AS); return;
					}
				} else if (CK==AS) { SubmitAnswer(true, AS); return; }
			}
			SubmitAnswer(false, AS);
		}

		private void SubmitAnswer(bool CorrectAns, string ans) {
			if (CorrectAns) {
				QLog.Add(new Tuple<string, string>(SQ, SU), ans);
				Score++;
				if (TF.TOCB1.Checked ) { AnswerPic.Image=Resources.cby_ph; AnswerPic.Visible=true; timer2.Enabled=true; }
			} else {
				QLog.Add(new Tuple<string, string>(SQ, SU), ans);
				WrongAnswers++;
				if (TF.TOCB1.Checked ) { AnswerPic.Image=Resources.eb_ph; AnswerPic.Visible=true; timer2.Enabled=true; }
			}
			if (QuestCoutner>=QM) { EndGame(); return; }
			if (MaxWrongAnswers>0&&WrongAnswers>=MaxWrongAnswers) { EndGame(); return; } else PickQuestion();
		}

		public void PickQuestion() {
			do {
				SQ=TG.SelectedQuiz[RNG.Next(0, TG.SelectedQuiz.Count)];
				//SQ=ShFun.GetRandomList(TG.SelectedQuiz).First().QuizID;
				SU=TG.QuizAr[SQ].Questions.Keys.ToList()[RNG.Next(0, TG.QuizAr[SQ].Questions.Count)];
				if (!AcceptedTypes.Contains(TG.QuizAr[SQ].Questions[SU].Category)) continue;
				if (TF.DCB1.Checked&&(TG.QuizAr[SQ].Questions[SU].Diff<(int)TF.QuestDifMin.Value||TG.QuizAr[SQ].Questions[SU].Diff>(int)TF.QuestDifMax.Value)) continue;
			} while (QLog.ContainsKey(new Tuple<string, string>(SQ, SU)));
			QuestCoutner++; SetQuestion(SQ, SU);
		}

		public void SetQuestion(string Quiz, string Question) {
			CurQuestion=TG.QuizAr[Quiz].Questions[Question];
			LQ.Text=CurQuestion.Quest; L1.Text="Category: "+CurQuestion.Category; L2.Text="Diff: "+CurQuestion.Diff;
			L3.Text="Q#: "+QuestCoutner; L4.Text="Score: "+Score; GB.Visible=false;
			switch (CurQuestion.Type) {
				case "Choice": SetChoices(CurQuestion); break;
				case "Type":
				for (int i = 0; i<ButtAr.Count; i++) ButtAr[i].Visible=false;
				GB.Visible=true;
				break;
				case "Bool":
				for (int i = 0; i<ButtAr.Count; i++) ButtAr[i].Visible=false;
				ButtAr[0].Text="True"; ButtAr[1].Text="False"; Corr=(CurQuestion.BoolValue ? 0 : 1);
				ButtAr[0].Visible=ButtAr[1].Visible=true;
				break;
			}
		}

		public void SetChoices(Question TQ) {
			Corr=TQ.CorrChoice;
			// ToDo: Randomize the choices
			for (int i = 0; i<ButtAr.Count; i++) ButtAr[i].Visible=false;
			List<string> CAr = (CurQuestion.BoolValue ? ShFun.ShuffleList(TQ.Choices.ToList()) : TQ.Choices.ToList());

			for (int i = 0; i<CAr.Count; i++) {
				if (ButtAr.Count>i) ButtAr[i].Text=CAr[i];
				else GenerateButton(CAr[i]);
				ButtAr[i].Visible=true;
			}
		}

		private void timer1_Tick(object sender, EventArgs e) {
			if (TF.DCB2.Checked) {
				QuestTime--; TimeLabel.Text="Time: "+QuestTime;
				if (QuestTime<0) { SubmitAnswer(false, "Times Out!"); QuestTime=(int)TF.QTL1.Value; }
			}
			if (TF.DCB3.Checked) { GameTime--; this.Text="Trivia: "+GameTime; if (GameTime<=0) EndGame(); }
		}

		private void timer2_Tick(object sender, EventArgs e) {
			TT2--;
			if (TT2<=0) { TT2=5; timer2.Enabled=false; AnswerPic.Visible=false; }
		}

		private void EndGame() {
			timer1.Enabled=false;
			for (int i = 0; i<ButtAr.Count; i++) ButtAr[i].Visible=false;
			SBP.BringToFront(); SBP.Visible=true; GB.Visible=false;
			ScoreBoard.Text="Number of Question: "+QuestCoutner+" Score: "+Score+"\r\n"+PrintLog();

		}

		private void End_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void Trivia_FormClosed(object sender, FormClosedEventArgs e) {
			TF.Enabled=true;
		}


	}
}
