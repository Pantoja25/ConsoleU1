namespace consoleU1 {
	internal class Program {
		static void Main(string[] args) {
			Usuario usuario = new Usuario();
			usuario.nome = "José";
			usuario.login = "root";
			usuario.senha = "qwe123";

			string login;
			string senha;

			do {
				Console.WriteLine("Digite seu LOGIN: ");
				login = Console.ReadLine();

				Console.WriteLine("Digite sua SENHA: ");
				senha = Console.ReadLine();

			} while (!usuario.Logar(login, senha));

		}
	}
}
