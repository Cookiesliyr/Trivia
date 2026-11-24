namespace Trivia {
	partial class About {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			pictureBox1=new PictureBox();
			LQ=new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage=(Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout=ImageLayout.Stretch;
			pictureBox1.Location=new Point(312, 9);
			pictureBox1.Name="pictureBox1";
			pictureBox1.Size=new Size(174, 171);
			pictureBox1.TabIndex=9;
			pictureBox1.TabStop=false;
			// 
			// LQ
			// 
			LQ.BackColor=Color.FromArgb(192, 192, 0);
			LQ.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			LQ.Location=new Point(12, 12);
			LQ.Multiline=true;
			LQ.Name="LQ";
			LQ.ReadOnly=true;
			LQ.ScrollBars=ScrollBars.Vertical;
			LQ.Size=new Size(294, 258);
			LQ.TabIndex=10;
			// 
			// About
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=Color.FromArgb(0, 192, 0);
			ClientSize=new Size(498, 282);
			Controls.Add(LQ);
			Controls.Add(pictureBox1);
			FormBorderStyle=FormBorderStyle.FixedToolWindow;
			Name="About";
			StartPosition=FormStartPosition.CenterParent;
			Text="About";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
		private TextBox LQ;
	}
}