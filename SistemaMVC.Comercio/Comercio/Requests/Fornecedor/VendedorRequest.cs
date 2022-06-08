﻿namespace Comercio.Requests.Fornecedor
{
    public class VendedorRequest 
    {
        public int Vendedor_id { get; set; }
        public int Fornecedor_id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public string DddAdicional { get; set; }
        public string NumeroAdicional { get; set; }
    }
}