﻿using Dapper.Contrib.Extensions;
using System;

namespace Comercio.Entities
{
    [Table("tb_produto")]
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco_custo { get; set; }
        public double Preco_venda { get; set; }
        public int Setor_id { get; set; }
        public sbyte Ativo { get; set; }
        public DateTime Data_criacao { get; set; }
        public DateTime Data_alteracao { get; set; }

        [Write(false)] 
        public virtual Setor Setor { get; set; }
    }
}