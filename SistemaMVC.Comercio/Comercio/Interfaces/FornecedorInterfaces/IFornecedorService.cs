﻿using Comercio.Entities;
using Comercio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comercio.Interfaces.FornecedorInterfaces
{
    public interface IFornecedorService 
    {
        Task<Fornecedor> InserirFornecedor(FornecedorViewModel fornecedor);
        Task<Fornecedor> InserirTelefone(int fornecedor_id, List<Telefone> telefones);
        Task<List<Fornecedor>> ListarFornecedores();
        Task<List<Fornecedor>> FiltrarPorSetor(string setor);
        Task<Fornecedor> BuscarFornecedor(int id);
    }
}
