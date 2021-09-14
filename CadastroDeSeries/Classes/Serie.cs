using System.Globalization;
using System;

namespace CadastroDeSeries
{
    public class Serie : EntidadeBase
    {
        private string Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie (int id, string genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = $"{this.Id}|{this.Titulo}|{this.Genero}|{this.Ano}|{this.Descricao}|{this.Excluido}";
            // retorno += "Gênero: " + this.Genero + Environment.NewLine;
            // retorno += "Título: " + this.Titulo + Environment.NewLine;
            // retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            // retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            // retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public string retornaGenero()
        {
            return Genero;
        }

        public string retornaDescricao()
        {
            return Descricao;
        }

        public int retornaAno()
        {
            return Ano;
        }

        public void Excluir()
        {
            this.Excluido = true;
            
        }

        public string retornaLinha()
        {
            return $"{this.Id}|{this.Titulo}|{this.Genero}|{this.Ano}|{this.Descricao}|{this.Excluido}";
        }
    }
}