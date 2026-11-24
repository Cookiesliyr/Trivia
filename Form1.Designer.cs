namespace Trivia {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components=new System.ComponentModel.Container();
			menuStrip1=new MenuStrip();
			fileToolStripMenuItem=new ToolStripMenuItem();
			setQuiziesGroupToolStripMenuItem=new ToolStripMenuItem();
			refreshQuizzesToolStripMenuItem=new ToolStripMenuItem();
			playToolStripMenuItem=new ToolStripMenuItem();
			triviaToolStripMenuItem=new ToolStripMenuItem();
			منسيربحالمليونToolStripMenuItem=new ToolStripMenuItem();
			quizToolStripMenuItem=new ToolStripMenuItem();
			createQuizToolStripMenuItem=new ToolStripMenuItem();
			helpToolStripMenuItem=new ToolStripMenuItem();
			aboutToolStripMenuItem=new ToolStripMenuItem();
			QuizList=new CheckedListBox();
			QCM=new ContextMenuStrip(components);
			editQuizeToolStripMenuItem=new ToolStripMenuItem();
			renameToolStripMenuItem=new ToolStripMenuItem();
			label1=new Label();
			GameGroup=new GroupBox();
			Extender=new CheckBox();
			Games=new GroupBox();
			PlayButt=new Button();
			GameCB=new ComboBox();
			GOpt2=new GroupBox();
			TOCB1=new CheckBox();
			GOpt1=new GroupBox();
			DCB4=new CheckBox();
			QTL2=new NumericUpDown();
			WAL=new NumericUpDown();
			DCB3=new CheckBox();
			QTL1=new NumericUpDown();
			DCB2=new CheckBox();
			QuestDifMax=new NumericUpDown();
			QuestDifMin=new NumericUpDown();
			DCB1=new CheckBox();
			groupBox2=new GroupBox();
			QuestNum=new NumericUpDown();
			label2=new Label();
			QTCB3=new CheckBox();
			QTCB2=new CheckBox();
			QTCB1=new CheckBox();
			label3=new Label();
			CreateQuiz=new Button();
			QuizGroup=new GroupBox();
			P2=new Panel();
			TF2=new RadioButton();
			TF1=new RadioButton();
			QuizSave=new Button();
			groupBox6=new GroupBox();
			label4=new Label();
			QuestCat=new ComboBox();
			label5=new Label();
			QuestName=new TextBox();
			QuestList=new ListBox();
			QuestAdd=new Button();
			QuestDel=new Button();
			QuestSave=new Button();
			CSL=new Label();
			QuestDif=new NumericUpDown();
			QuestText=new TextBox();
			CSV=new NumericUpDown();
			label6=new Label();
			label7=new Label();
			QTRB3=new RadioButton();
			P1=new Panel();
			ChoiceRNG=new CheckBox();
			ChoiceDel=new Button();
			ChoiceSave=new Button();
			ChoiceAdd=new Button();
			ChoiceLabel=new Label();
			ChoiceText=new TextBox();
			ChoiceList=new ListBox();
			QTRB2=new RadioButton();
			QTRB1=new RadioButton();
			menuStrip1.SuspendLayout();
			QCM.SuspendLayout();
			GameGroup.SuspendLayout();
			Games.SuspendLayout();
			GOpt2.SuspendLayout();
			GOpt1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)QTL2).BeginInit();
			((System.ComponentModel.ISupportInitialize)WAL).BeginInit();
			((System.ComponentModel.ISupportInitialize)QTL1).BeginInit();
			((System.ComponentModel.ISupportInitialize)QuestDifMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)QuestDifMin).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)QuestNum).BeginInit();
			QuizGroup.SuspendLayout();
			P2.SuspendLayout();
			groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)QuestDif).BeginInit();
			((System.ComponentModel.ISupportInitialize)CSV).BeginInit();
			P1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playToolStripMenuItem, quizToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location=new Point(0, 0);
			menuStrip1.Name="menuStrip1";
			menuStrip1.Size=new Size(732, 24);
			menuStrip1.TabIndex=0;
			menuStrip1.Text="menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setQuiziesGroupToolStripMenuItem, refreshQuizzesToolStripMenuItem });
			fileToolStripMenuItem.Name="fileToolStripMenuItem";
			fileToolStripMenuItem.Size=new Size(37, 20);
			fileToolStripMenuItem.Text="File";
			// 
			// setQuiziesGroupToolStripMenuItem
			// 
			setQuiziesGroupToolStripMenuItem.Name="setQuiziesGroupToolStripMenuItem";
			setQuiziesGroupToolStripMenuItem.Size=new Size(168, 22);
			setQuiziesGroupToolStripMenuItem.Text="Set Quizzes group";
			setQuiziesGroupToolStripMenuItem.Click+=setQuiziesGroupToolStripMenuItem_Click;
			// 
			// refreshQuizzesToolStripMenuItem
			// 
			refreshQuizzesToolStripMenuItem.Name="refreshQuizzesToolStripMenuItem";
			refreshQuizzesToolStripMenuItem.Size=new Size(168, 22);
			refreshQuizzesToolStripMenuItem.Text="Refresh Quizzes";
			refreshQuizzesToolStripMenuItem.Click+=refreshQuizzesToolStripMenuItem_Click;
			// 
			// playToolStripMenuItem
			// 
			playToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { triviaToolStripMenuItem, منسيربحالمليونToolStripMenuItem });
			playToolStripMenuItem.Name="playToolStripMenuItem";
			playToolStripMenuItem.Size=new Size(41, 20);
			playToolStripMenuItem.Text="Play";
			// 
			// triviaToolStripMenuItem
			// 
			triviaToolStripMenuItem.Name="triviaToolStripMenuItem";
			triviaToolStripMenuItem.Size=new Size(161, 22);
			triviaToolStripMenuItem.Text="Trivia";
			triviaToolStripMenuItem.Click+=triviaToolStripMenuItem_Click;
			// 
			// منسيربحالمليونToolStripMenuItem
			// 
			منسيربحالمليونToolStripMenuItem.Enabled=false;
			منسيربحالمليونToolStripMenuItem.Name="منسيربحالمليونToolStripMenuItem";
			منسيربحالمليونToolStripMenuItem.Size=new Size(161, 22);
			منسيربحالمليونToolStripMenuItem.Text="من سيربح المليون";
			// 
			// quizToolStripMenuItem
			// 
			quizToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createQuizToolStripMenuItem });
			quizToolStripMenuItem.Name="quizToolStripMenuItem";
			quizToolStripMenuItem.Size=new Size(43, 20);
			quizToolStripMenuItem.Text="Quiz";
			// 
			// createQuizToolStripMenuItem
			// 
			createQuizToolStripMenuItem.Name="createQuizToolStripMenuItem";
			createQuizToolStripMenuItem.Size=new Size(135, 22);
			createQuizToolStripMenuItem.Text="Create Quiz";
			createQuizToolStripMenuItem.Click+=createQuizToolStripMenuItem_Click;
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name="helpToolStripMenuItem";
			helpToolStripMenuItem.Size=new Size(44, 20);
			helpToolStripMenuItem.Text="Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size=new Size(107, 22);
			aboutToolStripMenuItem.Text="About";
			aboutToolStripMenuItem.Click+=aboutToolStripMenuItem_Click;
			// 
			// QuizList
			// 
			QuizList.ContextMenuStrip=QCM;
			QuizList.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			QuizList.FormattingEnabled=true;
			QuizList.Location=new Point(12, 76);
			QuizList.Name="QuizList";
			QuizList.Size=new Size(159, 312);
			QuizList.TabIndex=1;
			// 
			// QCM
			// 
			QCM.Items.AddRange(new ToolStripItem[] { editQuizeToolStripMenuItem, renameToolStripMenuItem });
			QCM.Name="QCM";
			QCM.Size=new Size(128, 48);
			// 
			// editQuizeToolStripMenuItem
			// 
			editQuizeToolStripMenuItem.Name="editQuizeToolStripMenuItem";
			editQuizeToolStripMenuItem.Size=new Size(127, 22);
			editQuizeToolStripMenuItem.Text="Edit Quize";
			editQuizeToolStripMenuItem.Click+=editQuizeToolStripMenuItem_Click;
			// 
			// renameToolStripMenuItem
			// 
			renameToolStripMenuItem.Name="renameToolStripMenuItem";
			renameToolStripMenuItem.Size=new Size(127, 22);
			renameToolStripMenuItem.Text="Rename";
			renameToolStripMenuItem.Click+=renameToolStripMenuItem_Click;
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location=new Point(12, 35);
			label1.Name="label1";
			label1.Size=new Size(152, 30);
			label1.TabIndex=2;
			label1.Text="Select Quizzes";
			// 
			// GameGroup
			// 
			GameGroup.Controls.Add(Extender);
			GameGroup.Controls.Add(Games);
			GameGroup.Controls.Add(GOpt2);
			GameGroup.Controls.Add(GOpt1);
			GameGroup.Controls.Add(groupBox2);
			GameGroup.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			GameGroup.Location=new Point(816, 68);
			GameGroup.Name="GameGroup";
			GameGroup.Size=new Size(261, 336);
			GameGroup.TabIndex=3;
			GameGroup.TabStop=false;
			GameGroup.Text="Options";
			// 
			// Extender
			// 
			Extender.Appearance=Appearance.Button;
			Extender.Location=new Point(231, 26);
			Extender.Margin=new Padding(4, 3, 4, 3);
			Extender.Name="Extender";
			Extender.Size=new Size(26, 294);
			Extender.TabIndex=244;
			Extender.Text=">";
			Extender.UseVisualStyleBackColor=true;
			Extender.CheckedChanged+=Extender_CheckedChanged;
			// 
			// Games
			// 
			Games.Controls.Add(PlayButt);
			Games.Controls.Add(GameCB);
			Games.Location=new Point(6, 173);
			Games.Name="Games";
			Games.Size=new Size(218, 145);
			Games.TabIndex=3;
			Games.TabStop=false;
			Games.Text="Playing Games";
			// 
			// PlayButt
			// 
			PlayButt.BackColor=Color.FromArgb(115, 225, 102);
			PlayButt.FlatStyle=FlatStyle.Flat;
			PlayButt.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			PlayButt.Location=new Point(16, 89);
			PlayButt.Margin=new Padding(4, 3, 4, 3);
			PlayButt.Name="PlayButt";
			PlayButt.Size=new Size(180, 40);
			PlayButt.TabIndex=18;
			PlayButt.Text="Play";
			PlayButt.UseVisualStyleBackColor=false;
			PlayButt.Click+=PlayButt_Click;
			// 
			// GameCB
			// 
			GameCB.DropDownStyle=ComboBoxStyle.DropDownList;
			GameCB.FlatStyle=FlatStyle.System;
			GameCB.FormattingEnabled=true;
			GameCB.Items.AddRange(new object[] { "Trivia" });
			GameCB.Location=new Point(6, 36);
			GameCB.Name="GameCB";
			GameCB.Size=new Size(206, 28);
			GameCB.TabIndex=0;
			// 
			// GOpt2
			// 
			GOpt2.Controls.Add(TOCB1);
			GOpt2.Location=new Point(230, 173);
			GOpt2.Name="GOpt2";
			GOpt2.Size=new Size(261, 145);
			GOpt2.TabIndex=2;
			GOpt2.TabStop=false;
			GOpt2.Text="Options";
			GOpt2.Visible=false;
			// 
			// TOCB1
			// 
			TOCB1.AutoSize=true;
			TOCB1.Location=new Point(6, 22);
			TOCB1.Name="TOCB1";
			TOCB1.Size=new Size(205, 24);
			TOCB1.TabIndex=1;
			TOCB1.Text="Show if answered correctly";
			TOCB1.UseVisualStyleBackColor=true;
			// 
			// GOpt1
			// 
			GOpt1.Controls.Add(DCB4);
			GOpt1.Controls.Add(QTL2);
			GOpt1.Controls.Add(WAL);
			GOpt1.Controls.Add(DCB3);
			GOpt1.Controls.Add(QTL1);
			GOpt1.Controls.Add(DCB2);
			GOpt1.Controls.Add(QuestDifMax);
			GOpt1.Controls.Add(QuestDifMin);
			GOpt1.Controls.Add(DCB1);
			GOpt1.Location=new Point(230, 22);
			GOpt1.Name="GOpt1";
			GOpt1.Size=new Size(261, 145);
			GOpt1.TabIndex=1;
			GOpt1.TabStop=false;
			GOpt1.Text="Difficulty";
			GOpt1.Visible=false;
			// 
			// DCB4
			// 
			DCB4.AutoSize=true;
			DCB4.Location=new Point(6, 107);
			DCB4.Name="DCB4";
			DCB4.Size=new Size(163, 24);
			DCB4.TabIndex=398;
			DCB4.Text="Wrong answers limit";
			DCB4.UseVisualStyleBackColor=true;
			// 
			// QTL2
			// 
			QTL2.Location=new Point(194, 80);
			QTL2.Maximum=new decimal(new int[] { 3600, 0, 0, 0 });
			QTL2.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QTL2.Name="QTL2";
			QTL2.Size=new Size(54, 27);
			QTL2.TabIndex=397;
			QTL2.Value=new decimal(new int[] { 600, 0, 0, 0 });
			// 
			// WAL
			// 
			WAL.Location=new Point(194, 107);
			WAL.Minimum=new decimal(new int[] { 3, 0, 0, 0 });
			WAL.Name="WAL";
			WAL.Size=new Size(54, 27);
			WAL.TabIndex=393;
			WAL.Value=new decimal(new int[] { 3, 0, 0, 0 });
			// 
			// DCB3
			// 
			DCB3.AutoSize=true;
			DCB3.Location=new Point(6, 80);
			DCB3.Name="DCB3";
			DCB3.Size=new Size(157, 24);
			DCB3.TabIndex=396;
			DCB3.Text="Game Time Limit \\s";
			DCB3.UseVisualStyleBackColor=true;
			// 
			// QTL1
			// 
			QTL1.Location=new Point(194, 52);
			QTL1.Maximum=new decimal(new int[] { 3600, 0, 0, 0 });
			QTL1.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QTL1.Name="QTL1";
			QTL1.Size=new Size(54, 27);
			QTL1.TabIndex=395;
			QTL1.Value=new decimal(new int[] { 180, 0, 0, 0 });
			// 
			// DCB2
			// 
			DCB2.AutoSize=true;
			DCB2.Location=new Point(6, 53);
			DCB2.Name="DCB2";
			DCB2.Size=new Size(173, 24);
			DCB2.TabIndex=394;
			DCB2.Text="Question Time Limit\\s";
			DCB2.UseVisualStyleBackColor=true;
			// 
			// QuestDifMax
			// 
			QuestDifMax.Location=new Point(194, 19);
			QuestDifMax.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QuestDifMax.Name="QuestDifMax";
			QuestDifMax.Size=new Size(54, 27);
			QuestDifMax.TabIndex=393;
			QuestDifMax.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// QuestDifMin
			// 
			QuestDifMin.Location=new Point(137, 19);
			QuestDifMin.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QuestDifMin.Name="QuestDifMin";
			QuestDifMin.Size=new Size(54, 27);
			QuestDifMin.TabIndex=392;
			QuestDifMin.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// DCB1
			// 
			DCB1.AutoSize=true;
			DCB1.Location=new Point(6, 22);
			DCB1.Name="DCB1";
			DCB1.Size=new Size(125, 24);
			DCB1.TabIndex=0;
			DCB1.Text="Filter Difficulty";
			DCB1.UseVisualStyleBackColor=true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(QuestNum);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(QTCB3);
			groupBox2.Controls.Add(QTCB2);
			groupBox2.Controls.Add(QTCB1);
			groupBox2.Location=new Point(6, 22);
			groupBox2.Name="groupBox2";
			groupBox2.Size=new Size(218, 145);
			groupBox2.TabIndex=0;
			groupBox2.TabStop=false;
			groupBox2.Text="Questions Types";
			// 
			// QuestNum
			// 
			QuestNum.Location=new Point(158, 21);
			QuestNum.Maximum=new decimal(new int[] { 1000, 0, 0, 0 });
			QuestNum.Minimum=new decimal(new int[] { 10, 0, 0, 0 });
			QuestNum.Name="QuestNum";
			QuestNum.Size=new Size(54, 27);
			QuestNum.TabIndex=395;
			QuestNum.Value=new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(6, 23);
			label2.Margin=new Padding(4, 0, 4, 0);
			label2.Name="label2";
			label2.Size=new Size(144, 20);
			label2.TabIndex=394;
			label2.Text="Number of Question";
			// 
			// QTCB3
			// 
			QTCB3.AutoSize=true;
			QTCB3.Checked=true;
			QTCB3.CheckState=CheckState.Checked;
			QTCB3.Location=new Point(6, 98);
			QTCB3.Name="QTCB3";
			QTCB3.Size=new Size(110, 24);
			QTCB3.TabIndex=2;
			QTCB3.Text="True or False";
			QTCB3.UseVisualStyleBackColor=true;
			// 
			// QTCB2
			// 
			QTCB2.AutoSize=true;
			QTCB2.Checked=true;
			QTCB2.CheckState=CheckState.Checked;
			QTCB2.Location=new Point(6, 73);
			QTCB2.Name="QTCB2";
			QTCB2.Size=new Size(128, 24);
			QTCB2.TabIndex=1;
			QTCB2.Text="Type Questions";
			QTCB2.UseVisualStyleBackColor=true;
			// 
			// QTCB1
			// 
			QTCB1.AutoSize=true;
			QTCB1.Checked=true;
			QTCB1.CheckState=CheckState.Checked;
			QTCB1.Location=new Point(6, 48);
			QTCB1.Name="QTCB1";
			QTCB1.Size=new Size(79, 24);
			QTCB1.TabIndex=0;
			QTCB1.Text="Choices";
			QTCB1.UseVisualStyleBackColor=true;
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(12, 485);
			label3.Margin=new Padding(4, 0, 4, 0);
			label3.Name="label3";
			label3.Size=new Size(59, 15);
			label3.TabIndex=395;
			label3.Text="Ver 1.0.0.2";
			// 
			// CreateQuiz
			// 
			CreateQuiz.BackColor=Color.FromArgb(115, 225, 102);
			CreateQuiz.FlatStyle=FlatStyle.Flat;
			CreateQuiz.Font=new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
			CreateQuiz.Location=new Point(162, 36);
			CreateQuiz.Margin=new Padding(4, 3, 4, 3);
			CreateQuiz.Name="CreateQuiz";
			CreateQuiz.Size=new Size(32, 31);
			CreateQuiz.TabIndex=396;
			CreateQuiz.Text="+";
			CreateQuiz.TextAlign=ContentAlignment.TopCenter;
			CreateQuiz.UseVisualStyleBackColor=false;
			CreateQuiz.Click+=CreateQuiz_Click;
			// 
			// QuizGroup
			// 
			QuizGroup.Controls.Add(P2);
			QuizGroup.Controls.Add(QuizSave);
			QuizGroup.Controls.Add(groupBox6);
			QuizGroup.Controls.Add(CSL);
			QuizGroup.Controls.Add(QuestDif);
			QuizGroup.Controls.Add(QuestText);
			QuizGroup.Controls.Add(CSV);
			QuizGroup.Controls.Add(label6);
			QuizGroup.Controls.Add(label7);
			QuizGroup.Controls.Add(QTRB3);
			QuizGroup.Controls.Add(P1);
			QuizGroup.Controls.Add(QTRB2);
			QuizGroup.Controls.Add(QTRB1);
			QuizGroup.Location=new Point(195, 36);
			QuizGroup.Name="QuizGroup";
			QuizGroup.Size=new Size(615, 456);
			QuizGroup.TabIndex=397;
			QuizGroup.TabStop=false;
			QuizGroup.Text="CreateQuiz";
			QuizGroup.Visible=false;
			// 
			// P2
			// 
			P2.Controls.Add(TF2);
			P2.Controls.Add(TF1);
			P2.Location=new Point(224, 265);
			P2.Name="P2";
			P2.Size=new Size(200, 100);
			P2.TabIndex=406;
			P2.Visible=false;
			// 
			// TF2
			// 
			TF2.AutoSize=true;
			TF2.Location=new Point(3, 39);
			TF2.Name="TF2";
			TF2.Size=new Size(51, 19);
			TF2.TabIndex=1;
			TF2.TabStop=true;
			TF2.Text="False";
			TF2.UseVisualStyleBackColor=true;
			// 
			// TF1
			// 
			TF1.AutoSize=true;
			TF1.Checked=true;
			TF1.Location=new Point(3, 14);
			TF1.Name="TF1";
			TF1.Size=new Size(47, 19);
			TF1.TabIndex=0;
			TF1.TabStop=true;
			TF1.Text="True";
			TF1.UseVisualStyleBackColor=true;
			// 
			// QuizSave
			// 
			QuizSave.BackColor=Color.FromArgb(115, 225, 102);
			QuizSave.FlatStyle=FlatStyle.Flat;
			QuizSave.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			QuizSave.Location=new Point(182, 404);
			QuizSave.Margin=new Padding(4, 3, 4, 3);
			QuizSave.Name="QuizSave";
			QuizSave.Size=new Size(180, 40);
			QuizSave.TabIndex=417;
			QuizSave.Text="Save";
			QuizSave.UseVisualStyleBackColor=false;
			QuizSave.Click+=QuizSave_Click;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(label4);
			groupBox6.Controls.Add(QuestCat);
			groupBox6.Controls.Add(label5);
			groupBox6.Controls.Add(QuestName);
			groupBox6.Controls.Add(QuestList);
			groupBox6.Controls.Add(QuestAdd);
			groupBox6.Controls.Add(QuestDel);
			groupBox6.Controls.Add(QuestSave);
			groupBox6.Location=new Point(6, 22);
			groupBox6.Name="groupBox6";
			groupBox6.Size=new Size(199, 363);
			groupBox6.TabIndex=406;
			groupBox6.TabStop=false;
			groupBox6.Text="Question Info";
			// 
			// label4
			// 
			label4.Location=new Point(140, 51);
			label4.Margin=new Padding(4, 0, 4, 0);
			label4.Name="label4";
			label4.Size=new Size(50, 20);
			label4.TabIndex=391;
			label4.Text="Category";
			// 
			// QuestCat
			// 
			QuestCat.FormattingEnabled=true;
			QuestCat.Location=new Point(9, 48);
			QuestCat.Name="QuestCat";
			QuestCat.Size=new Size(124, 23);
			QuestCat.TabIndex=390;
			// 
			// label5
			// 
			label5.Location=new Point(140, 25);
			label5.Margin=new Padding(4, 0, 4, 0);
			label5.Name="label5";
			label5.Size=new Size(39, 15);
			label5.TabIndex=389;
			label5.Text="Name";
			// 
			// QuestName
			// 
			QuestName.Location=new Point(8, 23);
			QuestName.Margin=new Padding(4, 3, 4, 3);
			QuestName.Name="QuestName";
			QuestName.Size=new Size(125, 23);
			QuestName.TabIndex=388;
			// 
			// QuestList
			// 
			QuestList.FormattingEnabled=true;
			QuestList.ItemHeight=15;
			QuestList.Location=new Point(8, 77);
			QuestList.Margin=new Padding(4, 3, 4, 3);
			QuestList.Name="QuestList";
			QuestList.ScrollAlwaysVisible=true;
			QuestList.Size=new Size(180, 244);
			QuestList.TabIndex=384;
			QuestList.SelectedIndexChanged+=QuestList_SelectedIndexChanged;
			// 
			// QuestAdd
			// 
			QuestAdd.Location=new Point(131, 329);
			QuestAdd.Margin=new Padding(4, 3, 4, 3);
			QuestAdd.Name="QuestAdd";
			QuestAdd.Size=new Size(57, 28);
			QuestAdd.TabIndex=385;
			QuestAdd.Text="Add";
			QuestAdd.UseVisualStyleBackColor=true;
			QuestAdd.Click+=QuestAdd_Click;
			// 
			// QuestDel
			// 
			QuestDel.Location=new Point(9, 329);
			QuestDel.Margin=new Padding(4, 3, 4, 3);
			QuestDel.Name="QuestDel";
			QuestDel.Size=new Size(56, 28);
			QuestDel.TabIndex=386;
			QuestDel.Text="Delete";
			QuestDel.UseVisualStyleBackColor=true;
			QuestDel.Click+=QuestDel_Click;
			// 
			// QuestSave
			// 
			QuestSave.Location=new Point(70, 329);
			QuestSave.Margin=new Padding(4, 3, 4, 3);
			QuestSave.Name="QuestSave";
			QuestSave.Size=new Size(56, 28);
			QuestSave.TabIndex=387;
			QuestSave.Text="Save";
			QuestSave.UseVisualStyleBackColor=true;
			QuestSave.Click+=QuestSave_Click;
			// 
			// CSL
			// 
			CSL.AutoSize=true;
			CSL.Location=new Point(452, 216);
			CSL.Margin=new Padding(4, 0, 4, 0);
			CSL.Name="CSL";
			CSL.Size=new Size(86, 15);
			CSL.TabIndex=416;
			CSL.Text="Correct Choice";
			// 
			// QuestDif
			// 
			QuestDif.Location=new Point(539, 13);
			QuestDif.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QuestDif.Name="QuestDif";
			QuestDif.Size=new Size(54, 23);
			QuestDif.TabIndex=409;
			QuestDif.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// QuestText
			// 
			QuestText.Location=new Point(215, 42);
			QuestText.Margin=new Padding(4, 3, 4, 3);
			QuestText.Multiline=true;
			QuestText.Name="QuestText";
			QuestText.ScrollBars=ScrollBars.Vertical;
			QuestText.Size=new Size(382, 166);
			QuestText.TabIndex=407;
			// 
			// CSV
			// 
			CSV.Location=new Point(543, 214);
			CSV.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			CSV.Name="CSV";
			CSV.Size=new Size(54, 23);
			CSV.TabIndex=415;
			CSV.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label6
			// 
			label6.AutoSize=true;
			label6.Location=new Point(215, 24);
			label6.Margin=new Padding(4, 0, 4, 0);
			label6.Name="label6";
			label6.Size=new Size(55, 15);
			label6.TabIndex=408;
			label6.Text="Question";
			// 
			// label7
			// 
			label7.AutoSize=true;
			label7.Location=new Point(481, 15);
			label7.Margin=new Padding(4, 0, 4, 0);
			label7.Name="label7";
			label7.Size=new Size(55, 15);
			label7.TabIndex=410;
			label7.Text="Difficulty";
			// 
			// QTRB3
			// 
			QTRB3.AutoSize=true;
			QTRB3.Location=new Point(346, 214);
			QTRB3.Name="QTRB3";
			QTRB3.Size=new Size(90, 19);
			QTRB3.TabIndex=414;
			QTRB3.Text="True or False";
			QTRB3.UseVisualStyleBackColor=true;
			// 
			// P1
			// 
			P1.Controls.Add(ChoiceRNG);
			P1.Controls.Add(ChoiceDel);
			P1.Controls.Add(ChoiceSave);
			P1.Controls.Add(ChoiceAdd);
			P1.Controls.Add(ChoiceLabel);
			P1.Controls.Add(ChoiceText);
			P1.Controls.Add(ChoiceList);
			P1.Location=new Point(215, 232);
			P1.Name="P1";
			P1.Size=new Size(382, 166);
			P1.TabIndex=411;
			// 
			// ChoiceRNG
			// 
			ChoiceRNG.Location=new Point(316, 127);
			ChoiceRNG.Name="ChoiceRNG";
			ChoiceRNG.Size=new Size(104, 39);
			ChoiceRNG.TabIndex=405;
			ChoiceRNG.Text="Random Choices";
			ChoiceRNG.UseVisualStyleBackColor=true;
			// 
			// ChoiceDel
			// 
			ChoiceDel.Location=new Point(322, 100);
			ChoiceDel.Margin=new Padding(4, 3, 4, 3);
			ChoiceDel.Name="ChoiceDel";
			ChoiceDel.Size=new Size(56, 28);
			ChoiceDel.TabIndex=404;
			ChoiceDel.Text="Delete";
			ChoiceDel.UseVisualStyleBackColor=true;
			ChoiceDel.Click+=ChoiceSave_Click;
			// 
			// ChoiceSave
			// 
			ChoiceSave.Location=new Point(322, 66);
			ChoiceSave.Margin=new Padding(4, 3, 4, 3);
			ChoiceSave.Name="ChoiceSave";
			ChoiceSave.Size=new Size(56, 28);
			ChoiceSave.TabIndex=403;
			ChoiceSave.Text="Save";
			ChoiceSave.UseVisualStyleBackColor=true;
			ChoiceSave.Click+=ChoiceSave_Click;
			// 
			// ChoiceAdd
			// 
			ChoiceAdd.Location=new Point(322, 32);
			ChoiceAdd.Margin=new Padding(4, 3, 4, 3);
			ChoiceAdd.Name="ChoiceAdd";
			ChoiceAdd.Size=new Size(56, 28);
			ChoiceAdd.TabIndex=402;
			ChoiceAdd.Text="Add";
			ChoiceAdd.UseVisualStyleBackColor=true;
			ChoiceAdd.Click+=ChoiceAdd_Click;
			// 
			// ChoiceLabel
			// 
			ChoiceLabel.AutoSize=true;
			ChoiceLabel.ImageAlign=ContentAlignment.TopCenter;
			ChoiceLabel.Location=new Point(305, 10);
			ChoiceLabel.Margin=new Padding(4, 0, 4, 0);
			ChoiceLabel.Name="ChoiceLabel";
			ChoiceLabel.Size=new Size(44, 15);
			ChoiceLabel.TabIndex=401;
			ChoiceLabel.Text="Choice";
			// 
			// ChoiceText
			// 
			ChoiceText.Location=new Point(5, 7);
			ChoiceText.Margin=new Padding(4, 3, 4, 3);
			ChoiceText.Name="ChoiceText";
			ChoiceText.Size=new Size(292, 23);
			ChoiceText.TabIndex=400;
			// 
			// ChoiceList
			// 
			ChoiceList.FormattingEnabled=true;
			ChoiceList.ItemHeight=15;
			ChoiceList.Location=new Point(5, 36);
			ChoiceList.Margin=new Padding(4, 3, 4, 3);
			ChoiceList.Name="ChoiceList";
			ChoiceList.ScrollAlwaysVisible=true;
			ChoiceList.Size=new Size(309, 124);
			ChoiceList.TabIndex=399;
			ChoiceList.SelectedIndexChanged+=ChoiceList_SelectedIndexChanged;
			// 
			// QTRB2
			// 
			QTRB2.AutoSize=true;
			QTRB2.Location=new Point(291, 214);
			QTRB2.Name="QTRB2";
			QTRB2.Size=new Size(49, 19);
			QTRB2.TabIndex=413;
			QTRB2.Text="Type";
			QTRB2.UseVisualStyleBackColor=true;
			// 
			// QTRB1
			// 
			QTRB1.AutoSize=true;
			QTRB1.Checked=true;
			QTRB1.Location=new Point(215, 214);
			QTRB1.Name="QTRB1";
			QTRB1.Size=new Size(67, 19);
			QTRB1.TabIndex=412;
			QTRB1.TabStop=true;
			QTRB1.Text="Choices";
			QTRB1.UseVisualStyleBackColor=true;
			// 
			// Form1
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=SystemColors.ActiveCaption;
			ClientSize=new Size(732, 509);
			Controls.Add(QuizGroup);
			Controls.Add(CreateQuiz);
			Controls.Add(label3);
			Controls.Add(GameGroup);
			Controls.Add(label1);
			Controls.Add(QuizList);
			Controls.Add(menuStrip1);
			FormBorderStyle=FormBorderStyle.Fixed3D;
			MainMenuStrip=menuStrip1;
			Name="Form1";
			Text="Trivia";
			FormClosing+=Form1_FormClosing;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			QCM.ResumeLayout(false);
			GameGroup.ResumeLayout(false);
			Games.ResumeLayout(false);
			GOpt2.ResumeLayout(false);
			GOpt2.PerformLayout();
			GOpt1.ResumeLayout(false);
			GOpt1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)QTL2).EndInit();
			((System.ComponentModel.ISupportInitialize)WAL).EndInit();
			((System.ComponentModel.ISupportInitialize)QTL1).EndInit();
			((System.ComponentModel.ISupportInitialize)QuestDifMax).EndInit();
			((System.ComponentModel.ISupportInitialize)QuestDifMin).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)QuestNum).EndInit();
			QuizGroup.ResumeLayout(false);
			QuizGroup.PerformLayout();
			P2.ResumeLayout(false);
			P2.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)QuestDif).EndInit();
			((System.ComponentModel.ISupportInitialize)CSV).EndInit();
			P1.ResumeLayout(false);
			P1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem setQuiziesGroupToolStripMenuItem;
		private ToolStripMenuItem playToolStripMenuItem;
		private ToolStripMenuItem quizToolStripMenuItem;
		private ToolStripMenuItem createQuizToolStripMenuItem;
		private ToolStripMenuItem triviaToolStripMenuItem;
		private ToolStripMenuItem منسيربحالمليونToolStripMenuItem;
		private CheckedListBox QuizList;
		private Label label1;
		private ToolStripMenuItem refreshQuizzesToolStripMenuItem;
		private GroupBox GameGroup;
		private GroupBox Games;
		private GroupBox GOpt2;
		private GroupBox GOpt1;
		private GroupBox groupBox2;
		public CheckBox DCB1;
		public CheckBox QTCB3;
		public CheckBox QTCB2;
		public CheckBox QTCB1;
		public NumericUpDown QTL2;
		public CheckBox DCB3;
		public NumericUpDown QTL1;
		public CheckBox DCB2;
		public NumericUpDown QuestDifMax;
		public NumericUpDown QuestDifMin;
		public NumericUpDown WAL;
		public CheckBox DCB4;
		public NumericUpDown QuestNum;
		public Label label2;
		public Label label3;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		public CheckBox TOCB1;
		private ComboBox GameCB;
		internal Button PlayButt;
		internal Button CreateQuiz;
		private GroupBox QuizGroup;
		private GroupBox groupBox6;
		private Label label4;
		private ComboBox QuestCat;
		private Label label5;
		public TextBox QuestName;
		public ListBox QuestList;
		internal Button QuestAdd;
		internal Button QuestDel;
		internal Button QuestSave;
		private Label CSL;
		private NumericUpDown QuestDif;
		private TextBox QuestText;
		private NumericUpDown CSV;
		private Label label6;
		private Label label7;
		private RadioButton QTRB3;
		private Panel P1;
		private CheckBox ChoiceRNG;
		internal Button ChoiceDel;
		internal Button ChoiceSave;
		internal Button ChoiceAdd;
		private Label ChoiceLabel;
		public TextBox ChoiceText;
		public ListBox ChoiceList;
		private RadioButton QTRB2;
		private RadioButton QTRB1;
		private ContextMenuStrip QCM;
		private ToolStripMenuItem editQuizeToolStripMenuItem;
		private ToolStripMenuItem renameToolStripMenuItem;
		private Panel P2;
		private RadioButton TF2;
		private RadioButton TF1;
		internal Button QuizSave;
		private CheckBox Extender;
	}
}