class Program {
	static void Main(string[] args) {
		if (!args.Any()) {
			Console.WriteLine("Error: Please input folder path");
			return;
		}
		Assesment assesment = new Assesment();
        assesment.Start(args[0]);
	}
}