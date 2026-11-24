using System.Reflection;
using System.Windows.Forms;

namespace Trivia {
	public partial class Form1: Form {
		static Random RNG = new Random();
		public static TriviaConfig Game;
		public Form1() {
			InitializeComponent();
			if (!File.Exists(Application.StartupPath+"\\Config.txt")) {
				Game=new TriviaConfig(); Game.SaveToFile();
			} else Game=TriviaConfig.LoadFromFile();
			refreshQuizzesToolStripMenuItem_Click(null, null);
			GameCB.SelectedIndex=0; GameGroup.Left=195;
		}

		#region Groups option
		private void Extender_CheckedChanged(object sender, EventArgs e) {
			if (Extender.Text=="<") {
				Extender.Location=new Point(231, 26);
				GameGroup.Size=new Size(261, 336);
				Extender.Text=">"; GOpt1.Visible=GOpt2.Visible=false;

			} else {
				Extender.Location=new Point(493, 26);
				GameGroup.Size=new Size(526, 336);
				Extender.Text="<"; GOpt1.Visible=GOpt2.Visible=true;
			}
		}

		#endregion

		#region Trivia
		private void createQuizToolStripMenuItem_Click(object sender, EventArgs e) {
			QuizCreator QC = new QuizCreator();
			QC.Show();
		}

		private void setQuiziesGroupToolStripMenuItem_Click(object sender, EventArgs e) {
			Game.SelectedQuiz.Clear();
			for (int i = 0; i<QuizList.Items.Count; i++)
				if (QuizList.GetItemChecked(i)) Game.SelectedQuiz.Add((string)QuizList.Items[i]);
			Game.SaveToFile();
		}

		private void refreshQuizzesToolStripMenuItem_Click(object sender, EventArgs e) {
			Game.LoadQuizzes(); QuizList.Items.Clear();
			foreach (KeyValuePair<string, Quiz> QK in Game.QuizAr) QuizList.Items.Add(QK.Key);
			foreach (string SQK in Game.SelectedQuiz) QuizList.SetItemChecked(QuizList.FindString(SQK), true);
			if (Game.QuizAr.Count<=0)
				if ((MessageBox.Show("No Quizzes", "You don't have any quize, do you want to create one now?", MessageBoxButtons.YesNo)==DialogResult.Yes)) {
					createQuizToolStripMenuItem_Click(sender, e);
				}
		}

		private void triviaToolStripMenuItem_Click(object sender, EventArgs e) {
			if (QuizList.CheckedItems.Count<=0) return;
			setQuiziesGroupToolStripMenuItem_Click(sender, e);
			Trivia NT = new Trivia();
			NT.StartGame();
			NT.Show();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) { setQuiziesGroupToolStripMenuItem_Click(sender, e); }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) { new About().Show(); }

		private void PlayButt_Click(object sender, EventArgs e) {
			switch (GameCB.SelectedIndex) {
				case 0: triviaToolStripMenuItem_Click(sender, e); break;
			}
		}
		#endregion

		#region Quiz Creator
		private void CreateQuiz_Click(object sender, EventArgs e) {
			string QName = Microsoft.VisualBasic.Interaction.InputBox("Enter the Quiz Name", "Quiz Name");
			if (QName==""||QuizList.Items.Contains(QName)) return;
			QuizList.Items.Add(QName);
			Game.QuizAr.Add(QName, new Quiz());
			Game.QuizAr[QName].QuizID=QName;
			Game.QuizAr[QName].SaveToFile(); QuizList.SelectedIndex=QuizList.Items.Count-1;
			editQuizeToolStripMenuItem_Click(sender, e);
			//createQuizToolStripMenuItem_Click(sender, e); 
		}
		private void editQuizeToolStripMenuItem_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1) return;
			GameGroup.Visible=false; QuizGroup.Visible=true;
			QuestList.Items.Clear(); QuestReInitialize();
			QuizList.Enabled=false;
			foreach (KeyValuePair<string, Question> QK in Game.QuizAr[QuizList.Text].Questions)
				QuestList.Items.Add(QK.Key);
			Size=new Size(837, 552);
		}
		private void QuizSave_Click(object sender, EventArgs e) {
			QuizList.Enabled=true; QuizGroup.Visible=false; GameGroup.Visible=true;
			Game.QuizAr[QuizList.Text].SaveToFile();
			Size=new Size(752, 552);
		}

		private void renameToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		#region QuizGroup code: a copy code
		private void QuestList_SelectedIndexChanged(object sender, EventArgs e) {
			if (QuestList.SelectedIndex<=-1) return;
			Question TQ = Game.QuizAr[QuizList.Text].Questions[QuestList.Text];
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
			if (QuizList.SelectedIndex<=-1||QuestName.Text==""||Game.QuizAr[QuizList.Text].Questions.ContainsKey(QuestName.Text)) return;
			Game.QuizAr[QuizList.Text].Questions.Add(QuestName.Text, new Question(QuestName.Text, QuestText.Text, QuestCat.Text, (int)QuestDif.Value, GetQT(), (QTRB3.Checked ? TF1.Checked : ChoiceRNG.Checked), (int)CSV.Value, ChoiceList.Items.Cast<string>().ToList()));
			QuestList.Items.Add(QuestName.Text);
			QuestReInitialize();
		}

		private void QuestSave_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1||QuestList.SelectedIndex<=-1) return;
			Game.QuizAr[QuizList.Text].Questions[QuestList.Text]=new Question(QuestName.Text, QuestText.Text, QuestCat.Text, (int)QuestDif.Value, GetQT(), (QTRB3.Checked ? TF1.Checked : ChoiceRNG.Checked), (int)CSV.Value, ChoiceList.Items.Cast<string>().ToList());
			QuestReInitialize();
		}

		private void QuestDel_Click(object sender, EventArgs e) {
			if (QuizList.SelectedIndex<=-1||QuestList.SelectedIndex<=-1) return;
			Game.QuizAr[QuizList.Text].Questions.Remove(QuestList.Text);
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
		#endregion

	}
}