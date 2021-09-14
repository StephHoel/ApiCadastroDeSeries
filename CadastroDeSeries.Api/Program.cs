using System;
using System.IO;
using System.Configuration;
using CadastroDeSeries;

namespace CadastroDeSeries.AppConsole
{
   public class Program
   {
		static SerieRepositorio repositorio = new SerieRepositorio();

		public static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine(Environment.NewLine + "Bem vindx ao Cadastro de Séries!");

			Output.MenuPrincipal();
			string opcao = Output.RetornoMenu();

			while (opcao.ToUpper() != "X")
			{
				switch (opcao)
				{
					case "1": // lista todas as séries
						Arquivo.ListarTudo();
						break;
					case "2": // lista apenas séries não excluídas
						Arquivo.ListarNaoExcluida();
						break;
					case "3": // lista apenas séries excluídas
						Arquivo.ListarExcluida();
						break;
					case "4":
						Principal.InserirSerie();
						break;
					case "5":
						Principal.AtualizarSerie();
						break;
					case "6":
						Principal.ExcluirSerie();
						break;
					case "7":
						Principal.VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				Output.MenuPrincipal();
				opcao = Output.RetornoMenu();
			}

			Console.WriteLine(Environment.NewLine + "Obrigada por utilizar nossos serviços. Até a próxima!");
			Console.WriteLine("Pressione ENTER para sair");
			Console.ReadLine();
		}
   }
}
