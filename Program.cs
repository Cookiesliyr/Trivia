namespace Trivia {
	public static class Program {
		public static Form1 TriviaForm = new Form1();
		[STAThread]
		static void Main() {

			ApplicationConfiguration.Initialize();
			Application.Run(TriviaForm);
		}
	}
}