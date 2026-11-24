using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia {
	public partial class QuizCreator: Form {
		TriviaConfig TempTC = new TriviaConfig();

		public QuizCreator() {
			InitializeComponent();
			TempTC=TriviaConfig.LoadFromFile();

			foreach (string CS in TempTC.CatAr) { CatList.Items.Add(CS); QuestCat.Items.Add(CS); }
			//foreach (string BS in TempTC.BGAr) CatList.Items.Add(BS);
			//foreach (string MS in TempTC.MusicAr) CatList.Items.Add(MS);

			TempTC.LoadQuizzes();
			foreach (KeyValuePair<string, Quiz> QK in TempTC.QuizAr) QuizList.Items.Add(QK.Key);

		}


		private void OK2_Click(object sender, EventArgs e) { Save(); Close(); }

		private void OK1_Click(object sender, EventArgs e) { Save(); }

		private void Cancel1_Click(object sender, EventArgs e) { Close(); }

		private void Save() {
			TempTC.CatAr.Clear();
			foreach (string CS in CatList.Items) { TempTC.CatAr.Add(CS); }
			foreach (KeyValuePair<string, Quiz> QK in TempTC.QuizAr) QK.Value.SaveToFile();
			TempTC.SaveToFile();
		}

		#region Categories
		private void CatAdd_Click(object sender, EventArgs e) {
			if (CatName.Text==""||CatList.Items.Contains(CatName.Text)) return;
			CatList.Items.Add(CatName.Text); QuestCat.Items.Add(CatName.Text);
		}

		private void CatSave_Click(object sender, EventArgs e) {

		}

		private void CatDel_Click(object sender, EventArgs e) {

		}
		#endregion

		#region Quiz
		private void QuizList_SelectedIndexChanged(object sender, EventArgs e) {
			QG2.Visible = (QuizList.SelectedIndex >=0) ;
			if (QuizList.SelectedIndex<=-1) return;
			QuestList.Items.Clear(); QuestReInitialize();
			foreach (KeyValuePair<string, Question> QK in TempTC.QuizAr[QuizList.Text].Questions)
				QuestList.Items.Add(QK.Key);
		}

		private void QuizAdd_Click(object sender, EventArgs e) {
			if (QuizName.Text==""||TempTC.QuizAr.ContainsKey(QuizName.Text)) return;
			QuizList.Items.Add(QuizName.Text);
			TempTC.QuizAr.Add(QuizName.Text, new Quiz());
			TempTC.QuizAr[QuizName.Text].QuizID=QuizName.Text;
			QuizReInitialize();
		}

		private void QuizSave_Click(object sender, EventArgs e) {

		}

		private void QuizDel_Click(object sender, EventArgs e) {

		}

		private void QuizReInitialize() {
			QuestReInitialize(); QuestList.Items.Clear();
			QuizName.Text=""; QuizList.SelectedIndex=-1;
		}
		// ===============================
		private void QuestList_SelectedIndexChanged(object sender, EventArgs e) {
			if (QuestList.SelectedIndex<=-1) return;
			Question TQ = TempTC.QuizAr[QuizList.Text].Questions[QuestList.Text];
			QuestName.Text=TQ.ID; QuestText.Text=TQ.Quest; QuestCat.Text=TQ.Category; QuestDif.Value=TQ.Diff;
			ChoiceList.Items.Clear();
			foreach (string CS in TQ.Choices) ChoiceList.Items.Add(CS);
			switch (TQ.Type) {
				case "Choice": QTRB1.Checked=true; P1.Visible=true; P2.Visible=false; ChoiceRNG.Checked=TQ.BoolValue; CSV.Value=TQ.CorrChoice; ChoiceLabel.Text="Choice"; break;
				case "Type": QTRB2.Checked=true; P1.Visible=true; P2.Visible=false; ChoiceRNG.Checked=TQ.BoolValue; ChoiceLabel.Text="Accepted Answer"; break;
				case "Bool": QTRB3.Checked=true; P2.Visible=true; P1.Visible=false; if (TQ.BoolValue) TF1.Checked=true; else TF2.Checked=true; break;
			}
			QuestionType(sender, e);

		}

		private void QuestAdd_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1||QuestName.Text==""||TempTC.QuizAr[QuizList.Text].Questions.ContainsKey(QuestName.Text)) return;
			TempTC.QuizAr[QuizList.Text].Questions.Add(QuestName.Text, new Question(QuestName.Text, QuestText.Text, QuestCat.Text, (int)QuestDif.Value, GetQT(), (QTRB3.Checked ? TF1.Checked : ChoiceRNG.Checked), (int)CSV.Value, ChoiceList.Items.Cast<string>().ToList()));
			QuestList.Items.Add(QuestName.Text);
			QuestReInitialize();
		}

		private void QuestSave_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1||QuestList.SelectedIndex<=-1) return;
			TempTC.QuizAr[QuizList.Text].Questions[QuestList.Text]=new Question(QuestName.Text, QuestText.Text, QuestCat.Text, (int)QuestDif.Value, GetQT(), (QTRB3.Checked ? TF1.Checked : ChoiceRNG.Checked), (int)CSV.Value, ChoiceList.Items.Cast<string>().ToList());
			QuestReInitialize();
		}

		private void QuestDel_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1||QuestList.SelectedIndex<=-1) return;
			TempTC.QuizAr[QuizList.Text].Questions.Remove(QuestList.Text);
			QuestList.Items.Remove(QuestList.Text); QuestReInitialize();
		}

		private void QuestCatUpdate() {

		}

		private void QuestReInitialize() {
			ChoiceList.Items.Clear(); QuestDif.Value=1;
			QuestText.Text=QuestName.Text=ChoiceText.Text="";

		}
		// ===============================
		private void ChoiceList_SelectedIndexChanged(object sender, EventArgs e) {
			if (ChoiceList.SelectedIndex<=-1) return;
			ChoiceText.Text=ChoiceList.Text;
		}

		private void ChoiceAdd_Click(object sender, EventArgs e) {
			if (ChoiceText.Text==""||ChoiceList.Items.Contains(ChoiceText.Text)) return;
			ChoiceList.Items.Add(ChoiceText.Text); ChoiceText.Text="";
		}

		private void ChoiceSave_Click(object sender, EventArgs e) {
			if (ChoiceText.Text==""||ChoiceList.SelectedIndex<=-1) return;
			ChoiceList.Items[ChoiceList.SelectedIndex]=ChoiceText.Text;
		}

		private void ChoiceDel_Click(object sender, EventArgs e) {
			if (ChoiceList.SelectedIndex<=-1) return;
			ChoiceList.Items.RemoveAt(ChoiceList.SelectedIndex); ChoiceText.Text="";
		}

		private void QuestionType(object sender, EventArgs e) {
			P1.Visible=!QTRB3.Checked; P2.Visible=QTRB3.Checked; CSL.Visible=CSV.Visible=QTRB1.Checked;
			if (QTRB1.Checked) { ChoiceRNG.Text="Random\r\nChoices"; } else if (QTRB2.Checked) { ChoiceRNG.Text="Accept\r\nPartial"; } else if (QTRB3.Checked) { }
		}

		private string GetQT() { if (QTRB1.Checked) return "Choice"; else if (QTRB2.Checked) return "Type"; return "Bool"; }
		#endregion

	}
}
