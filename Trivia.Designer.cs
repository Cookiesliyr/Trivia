namespace Trivia {
	partial class Trivia {
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
			components=new System.ComponentModel.Container();
			L4=new Label();
			L3=new Label();
			L2=new Label();
			L1=new Label();
			LQ=new Label();
			GB=new GroupBox();
			ButEnter=new Button();
			Answer=new TextBox();
			SBP=new Panel();
			End=new Button();
			ScoreBoard=new TextBox();
			TimeLabel=new Label();
			timer1=new System.Windows.Forms.Timer(components);
			AnswerPic=new PictureBox();
			timer2=new System.Windows.Forms.Timer(components);
			GB.SuspendLayout();
			SBP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AnswerPic).BeginInit();
			SuspendLayout();
			// 
			// L4
			// 
			L4.AutoSize=true;
			L4.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			L4.Location=new Point(699, 34);
			L4.Name="L4";
			L4.Size=new Size(49, 21);
			L4.TabIndex=12;
			L4.Text="Score";
			// 
			// L3
			// 
			L3.AutoSize=true;
			L3.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			L3.Location=new Point(556, 34);
			L3.Name="L3";
			L3.Size=new Size(31, 21);
			L3.TabIndex=11;
			L3.Text="Q#";
			// 
			// L2
			// 
			L2.AutoSize=true;
			L2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			L2.Location=new Point(355, 34);
			L2.Name="L2";
			L2.Size=new Size(35, 21);
			L2.TabIndex=9;
			L2.Text="Diff";
			// 
			// L1
			// 
			L1.AutoSize=true;
			L1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			L1.Location=new Point(15, 34);
			L1.Name="L1";
			L1.Size=new Size(73, 21);
			L1.TabIndex=8;
			L1.Text="Category";
			// 
			// LQ
			// 
			LQ.BackColor=Color.RosyBrown;
			LQ.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			LQ.Location=new Point(12, 61);
			LQ.Name="LQ";
			LQ.Size=new Size(776, 287);
			LQ.TabIndex=7;
			LQ.Text="Question";
			// 
			// GB
			// 
			GB.Controls.Add(ButEnter);
			GB.Controls.Add(Answer);
			GB.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			GB.Location=new Point(12, 360);
			GB.Name="GB";
			GB.Size=new Size(776, 131);
			GB.TabIndex=13;
			GB.TabStop=false;
			GB.Text="Enter your answer";
			// 
			// ButEnter
			// 
			ButEnter.BackColor=Color.FromArgb(115, 225, 102);
			ButEnter.FlatStyle=FlatStyle.Flat;
			ButEnter.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			ButEnter.Location=new Point(313, 73);
			ButEnter.Margin=new Padding(4, 3, 4, 3);
			ButEnter.Name="ButEnter";
			ButEnter.Size=new Size(120, 40);
			ButEnter.TabIndex=18;
			ButEnter.Text="Enter";
			ButEnter.UseVisualStyleBackColor=false;
			ButEnter.Click+=Enter_Click;
			// 
			// Answer
			// 
			Answer.BackColor=Color.FromArgb(0, 192, 192);
			Answer.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			Answer.Location=new Point(86, 32);
			Answer.Name="Answer";
			Answer.Size=new Size(597, 35);
			Answer.TabIndex=0;
			// 
			// SBP
			// 
			SBP.Controls.Add(End);
			SBP.Controls.Add(ScoreBoard);
			SBP.Location=new Point(17, 25);
			SBP.Name="SBP";
			SBP.Size=new Size(765, 436);
			SBP.TabIndex=14;
			SBP.Visible=false;
			// 
			// End
			// 
			End.BackColor=Color.FromArgb(115, 225, 102);
			End.FlatStyle=FlatStyle.Flat;
			End.Font=new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			End.Location=new Point(308, 381);
			End.Margin=new Padding(4, 3, 4, 3);
			End.Name="End";
			End.Size=new Size(120, 40);
			End.TabIndex=19;
			End.Text="End";
			End.UseVisualStyleBackColor=false;
			End.Click+=End_Click;
			// 
			// ScoreBoard
			// 
			ScoreBoard.BackColor=Color.Olive;
			ScoreBoard.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			ScoreBoard.ForeColor=Color.Maroon;
			ScoreBoard.Location=new Point(20, 26);
			ScoreBoard.Multiline=true;
			ScoreBoard.Name="ScoreBoard";
			ScoreBoard.ScrollBars=ScrollBars.Vertical;
			ScoreBoard.Size=new Size(711, 349);
			ScoreBoard.TabIndex=0;
			// 
			// TimeLabel
			// 
			TimeLabel.AutoSize=true;
			TimeLabel.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TimeLabel.Location=new Point(699, 1);
			TimeLabel.Name="TimeLabel";
			TimeLabel.Size=new Size(44, 21);
			TimeLabel.TabIndex=15;
			TimeLabel.Text="Time";
			// 
			// timer1
			// 
			timer1.Interval=1000;
			timer1.Tick+=timer1_Tick;
			// 
			// AnswerPic
			// 
			AnswerPic.Image=Properties.Resources.cby_ph;
			AnswerPic.Location=new Point(707, 339);
			AnswerPic.Name="AnswerPic";
			AnswerPic.Size=new Size(74, 63);
			AnswerPic.TabIndex=19;
			AnswerPic.TabStop=false;
			AnswerPic.Visible=false;
			// 
			// timer2
			// 
			timer2.Interval=300;
			timer2.Tick+=timer2_Tick;
			// 
			// Trivia
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=SystemColors.ActiveCaption;
			ClientSize=new Size(795, 503);
			Controls.Add(AnswerPic);
			Controls.Add(TimeLabel);
			Controls.Add(L4);
			Controls.Add(L3);
			Controls.Add(L2);
			Controls.Add(L1);
			Controls.Add(LQ);
			Controls.Add(GB);
			Controls.Add(SBP);
			Name="Trivia";
			StartPosition=FormStartPosition.CenterParent;
			Text="Trivia";
			FormClosed+=Trivia_FormClosed;
			GB.ResumeLayout(false);
			GB.PerformLayout();
			SBP.ResumeLayout(false);
			SBP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)AnswerPic).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label L4;
		private Label L3;
		private Label L2;
		private Label L1;
		private Label LQ;
		private GroupBox GB;
		internal Button ButEnter;
		private TextBox Answer;
		private Panel SBP;
		private TextBox ScoreBoard;
		internal Button End;
		private Label TimeLabel;
		private System.Windows.Forms.Timer timer1;
		private PictureBox AnswerPic;
		private System.Windows.Forms.Timer timer2;
	}
}