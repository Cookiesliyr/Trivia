using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia {
	public partial class About: Form {
		public About() {
			InitializeComponent();
			StringBuilder SB = new StringBuilder();
			SB.Append("Trivia Program Ver 1.0.0.1:\r\n+Fixed Some Crashes\r\n+Made Type Button work even if with the wrong answer\r\n+Add an option to show if you answered correctly for each question");
			SB.Append("===========\r\nTrivia Program Ver 1.0.0.2:\r\n+About Page Update\r\n+Made it load quizes when the program run the first time\r\n+ Made Quiz creator hide the question setting if a Quiz is not selected\r\n+Made it possible to create quizes and edit them on the main menu\r\n+ A few changes on the GUI");
			LQ.Text=SB.ToString();
		}
	}
}
