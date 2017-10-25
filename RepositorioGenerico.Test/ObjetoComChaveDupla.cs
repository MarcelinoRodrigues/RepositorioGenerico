﻿using RepositorioGenerico.Entities;
using RepositorioGenerico.Entities.Anotacoes;

namespace RepositorioGenerico.Test
{
	public class ObjetoComChaveDupla : Entidade
	{

		[Chave]
		[AutoIncremento(Incremento.Nenhum)]
		[Coluna(Ordem = 0, NomeDoTipo = "int")]
		public int ChaveBase { get; set; }

		[Chave]
		[AutoIncremento(Incremento.Identity)]
		[Coluna(Ordem = 1, NomeDoTipo = "int")]
		public int ChaveAutoIncremento { get; set; }

		[Obrigatorio]
		[Coluna(Ordem = 2, NomeDoTipo = "varchar")]
		[TamanhoMaximo(50)]
		public string Nome { get; set; }

	}
}
