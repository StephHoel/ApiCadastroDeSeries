using System;

namespace CadastroDeSeries
{
    public class Output
    {
        public static void Titulo(string titulo)
        {
            Console.WriteLine($"**{titulo}**");
        }

        public static string[] Split(string s)
        {
            return s.Split('|');
        }

        public static void MenuPrincipal()
		{
         Console.WriteLine();
			Console.WriteLine("**Menu Principal**");
			Console.WriteLine("1- Listar todas as séries");
			Console.WriteLine("2- Listar apenas séries não excluídas");
			Console.WriteLine("3- Listar apenas séries excluídas");
			Console.WriteLine("4- Inserir nova série");
			Console.WriteLine("5- Atualizar série");
			Console.WriteLine("6- Excluir série");
			Console.WriteLine("7- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
		}

        public static string RetornoMenu()
        {
            Console.WriteLine();
			Console.Write("Informe a opção desejada: ");
			string opcao = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcao;
        }
    }
}