using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleU1 {
	internal class Usuario {
		//Os atributos: nome, login, senha
		//Cadeia = String
		//INT = Inteiro
		//Float = Real
		public string nome;
		public string login;
		public string senha;
		public int qtdLogin;
		public float peso;
		public bool ehsolteiro;
		public char abrvNomeMeio;

		public bool Logar(string _login, string _senha) {
			if (_login == login) {
				if (_senha == senha) {
					return true;
				}
			}
			return false;
		}
	}
}
