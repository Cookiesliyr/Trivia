namespace Trivia {
	partial class QuizCreator {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tabControl1=new TabControl();
			tabPage1=new TabPage();
			groupBox1=new GroupBox();
			label53=new Label();
			CatName=new TextBox();
			CatList=new ListBox();
			CatAdd=new Button();
			CatDel=new Button();
			CatSave=new Button();
			tabPage2=new TabPage();
			CSL=new Label();
			CSV=new NumericUpDown();
			P2=new Panel();
			TF2=new RadioButton();
			TF1=new RadioButton();
			QTRB3=new RadioButton();
			QTRB2=new RadioButton();
			QTRB1=new RadioButton();
			P1=new Panel();
			ChoiceRNG=new CheckBox();
			ChoiceDel=new Button();
			ChoiceSave=new Button();
			ChoiceAdd=new Button();
			ChoiceLabel=new Label();
			ChoiceText=new TextBox();
			ChoiceList=new ListBox();
			groupBox3=new GroupBox();
			label6=new Label();
			QuizName=new TextBox();
			QuizList=new ListBox();
			QuizAdd=new Button();
			QuizDel=new Button();
			QuizSave=new Button();
			label3=new Label();
			QuestDif=new NumericUpDown();
			label2=new Label();
			QuestText=new TextBox();
			groupBox2=new GroupBox();
			label4=new Label();
			QuestCat=new ComboBox();
			label1=new Label();
			QuestName=new TextBox();
			QuestList=new ListBox();
			QuestAdd=new Button();
			QuestDel=new Button();
			QuestSave=new Button();
			OK1=new Button();
			OK2=new Button();
			Cancel1=new Button();
			menuStrip1=new MenuStrip();
			QG2=new GroupBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CSV).BeginInit();
			P2.SuspendLayout();
			P1.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)QuestDif).BeginInit();
			groupBox2.SuspendLayout();
			QG2.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location=new Point(12, 27);
			tabControl1.Name="tabControl1";
			tabControl1.SelectedIndex=0;
			tabControl1.Size=new Size(839, 451);
			tabControl1.TabIndex=0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor=SystemColors.GradientInactiveCaption;
			tabPage1.Controls.Add(groupBox1);
			tabPage1.Location=new Point(4, 24);
			tabPage1.Name="tabPage1";
			tabPage1.Padding=new Padding(3);
			tabPage1.Size=new Size(806, 398);
			tabPage1.TabIndex=0;
			tabPage1.Text="Config";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label53);
			groupBox1.Controls.Add(CatName);
			groupBox1.Controls.Add(CatList);
			groupBox1.Controls.Add(CatAdd);
			groupBox1.Controls.Add(CatDel);
			groupBox1.Controls.Add(CatSave);
			groupBox1.Location=new Point(6, 11);
			groupBox1.Name="groupBox1";
			groupBox1.Size=new Size(260, 381);
			groupBox1.TabIndex=0;
			groupBox1.TabStop=false;
			groupBox1.Text="Category Info";
			// 
			// label53
			// 
			label53.AutoSize=true;
			label53.Location=new Point(192, 25);
			label53.Margin=new Padding(4, 0, 4, 0);
			label53.Name="label53";
			label53.Size=new Size(39, 15);
			label53.TabIndex=389;
			label53.Text="Name";
			// 
			// CatName
			// 
			CatName.Location=new Point(8, 23);
			CatName.Margin=new Padding(4, 3, 4, 3);
			CatName.Name="CatName";
			CatName.Size=new Size(180, 23);
			CatName.TabIndex=388;
			// 
			// CatList
			// 
			CatList.FormattingEnabled=true;
			CatList.ItemHeight=15;
			CatList.Location=new Point(8, 53);
			CatList.Margin=new Padding(4, 3, 4, 3);
			CatList.Name="CatList";
			CatList.ScrollAlwaysVisible=true;
			CatList.Size=new Size(245, 289);
			CatList.TabIndex=384;
			// 
			// CatAdd
			// 
			CatAdd.Location=new Point(175, 347);
			CatAdd.Margin=new Padding(4, 3, 4, 3);
			CatAdd.Name="CatAdd";
			CatAdd.Size=new Size(78, 28);
			CatAdd.TabIndex=385;
			CatAdd.Text="Add";
			CatAdd.UseVisualStyleBackColor=true;
			CatAdd.Click+=CatAdd_Click;
			// 
			// CatDel
			// 
			CatDel.Location=new Point(7, 347);
			CatDel.Margin=new Padding(4, 3, 4, 3);
			CatDel.Name="CatDel";
			CatDel.Size=new Size(56, 28);
			CatDel.TabIndex=386;
			CatDel.Text="Delete";
			CatDel.UseVisualStyleBackColor=true;
			CatDel.Click+=CatDel_Click;
			// 
			// CatSave
			// 
			CatSave.Location=new Point(68, 347);
			CatSave.Margin=new Padding(4, 3, 4, 3);
			CatSave.Name="CatSave";
			CatSave.Size=new Size(56, 28);
			CatSave.TabIndex=387;
			CatSave.Text="Save";
			CatSave.UseVisualStyleBackColor=true;
			CatSave.Click+=CatSave_Click;
			// 
			// tabPage2
			// 
			tabPage2.BackColor=SystemColors.GradientInactiveCaption;
			tabPage2.Controls.Add(QG2);
			tabPage2.Controls.Add(groupBox3);
			tabPage2.Location=new Point(4, 24);
			tabPage2.Name="tabPage2";
			tabPage2.Padding=new Padding(3);
			tabPage2.Size=new Size(831, 423);
			tabPage2.TabIndex=1;
			tabPage2.Text="Quiz";
			// 
			// CSL
			// 
			CSL.AutoSize=true;
			CSL.Location=new Point(452, 216);
			CSL.Margin=new Padding(4, 0, 4, 0);
			CSL.Name="CSL";
			CSL.Size=new Size(86, 15);
			CSL.TabIndex=405;
			CSL.Text="Correct Choice";
			// 
			// CSV
			// 
			CSV.Location=new Point(543, 214);
			CSV.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			CSV.Name="CSV";
			CSV.Size=new Size(54, 23);
			CSV.TabIndex=404;
			CSV.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// P2
			// 
			P2.Controls.Add(TF2);
			P2.Controls.Add(TF1);
			P2.Location=new Point(220, 274);
			P2.Name="P2";
			P2.Size=new Size(200, 100);
			P2.TabIndex=403;
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
			// QTRB3
			// 
			QTRB3.AutoSize=true;
			QTRB3.Location=new Point(346, 214);
			QTRB3.Name="QTRB3";
			QTRB3.Size=new Size(90, 19);
			QTRB3.TabIndex=402;
			QTRB3.Text="True or False";
			QTRB3.UseVisualStyleBackColor=true;
			QTRB3.Click+=QuestionType;
			// 
			// QTRB2
			// 
			QTRB2.AutoSize=true;
			QTRB2.Location=new Point(291, 214);
			QTRB2.Name="QTRB2";
			QTRB2.Size=new Size(49, 19);
			QTRB2.TabIndex=401;
			QTRB2.Text="Type";
			QTRB2.UseVisualStyleBackColor=true;
			QTRB2.Click+=QuestionType;
			// 
			// QTRB1
			// 
			QTRB1.AutoSize=true;
			QTRB1.Checked=true;
			QTRB1.Location=new Point(215, 214);
			QTRB1.Name="QTRB1";
			QTRB1.Size=new Size(67, 19);
			QTRB1.TabIndex=400;
			QTRB1.TabStop=true;
			QTRB1.Text="Choices";
			QTRB1.UseVisualStyleBackColor=true;
			QTRB1.Click+=QuestionType;
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
			P1.TabIndex=399;
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
			ChoiceDel.Click+=ChoiceDel_Click;
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
			// groupBox3
			// 
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(QuizName);
			groupBox3.Controls.Add(QuizList);
			groupBox3.Controls.Add(QuizAdd);
			groupBox3.Controls.Add(QuizDel);
			groupBox3.Controls.Add(QuizSave);
			groupBox3.Location=new Point(6, 19);
			groupBox3.Name="groupBox3";
			groupBox3.Size=new Size(196, 363);
			groupBox3.TabIndex=393;
			groupBox3.TabStop=false;
			groupBox3.Text="Quiz Info";
			// 
			// label6
			// 
			label6.Location=new Point(151, 26);
			label6.Margin=new Padding(4, 0, 4, 0);
			label6.Name="label6";
			label6.Size=new Size(39, 15);
			label6.TabIndex=389;
			label6.Text="Name";
			// 
			// QuizName
			// 
			QuizName.Location=new Point(8, 23);
			QuizName.Margin=new Padding(4, 3, 4, 3);
			QuizName.Name="QuizName";
			QuizName.Size=new Size(143, 23);
			QuizName.TabIndex=388;
			// 
			// QuizList
			// 
			QuizList.FormattingEnabled=true;
			QuizList.ItemHeight=15;
			QuizList.Location=new Point(7, 52);
			QuizList.Margin=new Padding(4, 3, 4, 3);
			QuizList.Name="QuizList";
			QuizList.ScrollAlwaysVisible=true;
			QuizList.Size=new Size(181, 274);
			QuizList.TabIndex=384;
			QuizList.SelectedIndexChanged+=QuizList_SelectedIndexChanged;
			// 
			// QuizAdd
			// 
			QuizAdd.Location=new Point(131, 329);
			QuizAdd.Margin=new Padding(4, 3, 4, 3);
			QuizAdd.Name="QuizAdd";
			QuizAdd.Size=new Size(57, 28);
			QuizAdd.TabIndex=385;
			QuizAdd.Text="Add";
			QuizAdd.UseVisualStyleBackColor=true;
			QuizAdd.Click+=QuizAdd_Click;
			// 
			// QuizDel
			// 
			QuizDel.Location=new Point(9, 329);
			QuizDel.Margin=new Padding(4, 3, 4, 3);
			QuizDel.Name="QuizDel";
			QuizDel.Size=new Size(56, 28);
			QuizDel.TabIndex=386;
			QuizDel.Text="Delete";
			QuizDel.UseVisualStyleBackColor=true;
			QuizDel.Click+=QuizDel_Click;
			// 
			// QuizSave
			// 
			QuizSave.Location=new Point(70, 329);
			QuizSave.Margin=new Padding(4, 3, 4, 3);
			QuizSave.Name="QuizSave";
			QuizSave.Size=new Size(56, 28);
			QuizSave.TabIndex=387;
			QuizSave.Text="Save";
			QuizSave.UseVisualStyleBackColor=true;
			QuizSave.Click+=QuizSave_Click;
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(481, 15);
			label3.Margin=new Padding(4, 0, 4, 0);
			label3.Name="label3";
			label3.Size=new Size(55, 15);
			label3.TabIndex=392;
			label3.Text="Difficulty";
			// 
			// QuestDif
			// 
			QuestDif.Location=new Point(539, 13);
			QuestDif.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
			QuestDif.Name="QuestDif";
			QuestDif.Size=new Size(54, 23);
			QuestDif.TabIndex=391;
			QuestDif.Value=new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(215, 24);
			label2.Margin=new Padding(4, 0, 4, 0);
			label2.Name="label2";
			label2.Size=new Size(55, 15);
			label2.TabIndex=390;
			label2.Text="Question";
			// 
			// QuestText
			// 
			QuestText.Location=new Point(215, 42);
			QuestText.Margin=new Padding(4, 3, 4, 3);
			QuestText.Multiline=true;
			QuestText.Name="QuestText";
			QuestText.ScrollBars=ScrollBars.Vertical;
			QuestText.Size=new Size(382, 166);
			QuestText.TabIndex=276;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(QuestCat);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(QuestName);
			groupBox2.Controls.Add(QuestList);
			groupBox2.Controls.Add(QuestAdd);
			groupBox2.Controls.Add(QuestDel);
			groupBox2.Controls.Add(QuestSave);
			groupBox2.Location=new Point(6, 22);
			groupBox2.Name="groupBox2";
			groupBox2.Size=new Size(199, 363);
			groupBox2.TabIndex=1;
			groupBox2.TabStop=false;
			groupBox2.Text="Question Info";
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
			// label1
			// 
			label1.Location=new Point(140, 25);
			label1.Margin=new Padding(4, 0, 4, 0);
			label1.Name="label1";
			label1.Size=new Size(39, 15);
			label1.TabIndex=389;
			label1.Text="Name";
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
			// OK1
			// 
			OK1.BackColor=Color.FromArgb(115, 225, 102);
			OK1.FlatStyle=FlatStyle.Flat;
			OK1.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			OK1.Location=new Point(139, 484);
			OK1.Margin=new Padding(4, 3, 4, 3);
			OK1.Name="OK1";
			OK1.Size=new Size(188, 40);
			OK1.TabIndex=18;
			OK1.Text="Save Changes";
			OK1.UseVisualStyleBackColor=false;
			OK1.Click+=OK1_Click;
			// 
			// OK2
			// 
			OK2.BackColor=Color.FromArgb(115, 225, 102);
			OK2.FlatStyle=FlatStyle.Flat;
			OK2.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			OK2.Location=new Point(334, 484);
			OK2.Margin=new Padding(4, 3, 4, 3);
			OK2.Name="OK2";
			OK2.Size=new Size(211, 40);
			OK2.TabIndex=16;
			OK2.Text="Save and Exit";
			OK2.UseVisualStyleBackColor=false;
			OK2.Click+=OK2_Click;
			// 
			// Cancel1
			// 
			Cancel1.BackColor=Color.FromArgb(115, 225, 102);
			Cancel1.FlatStyle=FlatStyle.Flat;
			Cancel1.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			Cancel1.Location=new Point(12, 484);
			Cancel1.Margin=new Padding(4, 3, 4, 3);
			Cancel1.Name="Cancel1";
			Cancel1.Size=new Size(120, 40);
			Cancel1.TabIndex=17;
			Cancel1.Text="Cancel";
			Cancel1.UseVisualStyleBackColor=false;
			Cancel1.Click+=Cancel1_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Location=new Point(0, 0);
			menuStrip1.Name="menuStrip1";
			menuStrip1.Size=new Size(861, 24);
			menuStrip1.TabIndex=19;
			menuStrip1.Text="menuStrip1";
			// 
			// QG2
			// 
			QG2.Controls.Add(groupBox2);
			QG2.Controls.Add(CSL);
			QG2.Controls.Add(QuestDif);
			QG2.Controls.Add(QuestText);
			QG2.Controls.Add(CSV);
			QG2.Controls.Add(label2);
			QG2.Controls.Add(P2);
			QG2.Controls.Add(label3);
			QG2.Controls.Add(QTRB3);
			QG2.Controls.Add(P1);
			QG2.Controls.Add(QTRB2);
			QG2.Controls.Add(QTRB1);
			QG2.Location=new Point(208, 10);
			QG2.Name="QG2";
			QG2.Size=new Size(606, 406);
			QG2.TabIndex=406;
			QG2.TabStop=false;
			QG2.Text="Question Setting";
			QG2.Visible=false;
			// 
			// QuizCreator
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=SystemColors.ActiveCaption;
			ClientSize=new Size(861, 532);
			ControlBox=false;
			Controls.Add(OK1);
			Controls.Add(OK2);
			Controls.Add(Cancel1);
			Controls.Add(tabControl1);
			Controls.Add(menuStrip1);
			MainMenuStrip=menuStrip1;
			Name="QuizCreator";
			Text="QuizCreator";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)CSV).EndInit();
			P2.ResumeLayout(false);
			P2.PerformLayout();
			P1.ResumeLayout(false);
			P1.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)QuestDif).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			QG2.ResumeLayout(false);
			QG2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		internal Button OK1;
		internal Button OK2;
		internal Button Cancel1;
		private MenuStrip menuStrip1;
		private GroupBox groupBox1;
		private Label label53;
		public TextBox CatName;
		public ListBox CatList;
		internal Button CatAdd;
		internal Button CatDel;
		internal Button CatSave;
		private Label label3;
		private NumericUpDown QuestDif;
		private Label label2;
		private TextBox QuestText;
		private GroupBox groupBox2;
		private Label label1;
		public TextBox QuestName;
		public ListBox QuestList;
		internal Button QuestAdd;
		internal Button QuestDel;
		internal Button QuestSave;
		private Label label4;
		private ComboBox QuestCat;
		private GroupBox groupBox3;
		private Label label6;
		public TextBox QuizName;
		public ListBox QuizList;
		internal Button QuizAdd;
		internal Button QuizDel;
		internal Button QuizSave;
		private Panel P1;
		internal Button ChoiceDel;
		internal Button ChoiceSave;
		internal Button ChoiceAdd;
		private Label ChoiceLabel;
		public TextBox ChoiceText;
		public ListBox ChoiceList;
		private RadioButton QTRB3;
		private RadioButton QTRB2;
		private RadioButton QTRB1;
		private CheckBox ChoiceRNG;
		private Panel P2;
		private RadioButton TF2;
		private RadioButton TF1;
		private Label CSL;
		private NumericUpDown CSV;
		private GroupBox QG2;
	}
}