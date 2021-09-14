using System;
using System.Collections.Generic;
using CadastroDeSeries;
using CadastroDeSeries.Interfaces;

namespace CadastroDeSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
	{
	   List<Serie> listaSerie = Arquivo.ListaTudo();

		public void Atualiza(int id, Serie objeto)
		{
			// List<Serie> listaSerie = Arquivo.ListaTudo();
			objeto.Id = id;
			listaSerie[id] = objeto;

			Arquivo.AlterarSerie(listaSerie);
		}

		public void Exclui(int id)
		{
			// List<Serie> listaSerie = Arquivo.ListaTudo();
			listaSerie[id].Excluir();
			Arquivo.AlterarSerie(listaSerie);
		}

		public void Insere(Serie objeto)
		{
			// string obj = $"{objeto.retornaId()}|{objeto.retornaTitulo()}|{objeto.retornaGenero()}|{objeto.retornaAno()}|{objeto.retornaDescricao}|false";
			// Arquivo.Escrever(obj);
			// objeto.Excluido = false;
			Arquivo.EscreverSerie(objeto);
		}

		public void Inserir(string objeto)
		{
			// objeto.Excluido = false;
			Arquivo.Escrever(objeto);
		}

		public List<Serie> Lista()
		{
			// List<Serie> listaSerie = Arquivo.ListaTudo();
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public int InsereId(int id)
		{
			return id;
		}

		public Serie RetornaPorId(int id)
		{
			// List<Serie> listaSerie = Arquivo.ListaTudo();
			return listaSerie[id];
		}
	}
}