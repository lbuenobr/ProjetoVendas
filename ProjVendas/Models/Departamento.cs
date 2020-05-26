using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProjVendasWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjVendas.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
        public Departamento()
        {
        }
        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionaVendedor(Vendedor vendedor) {
            Vendedores.Add(vendedor);
        }
        public void RemoverVendedor(Vendedor vendedor)
        {
            Vendedores.Remove(vendedor);
        }
        public double TotalVendas(DateTime inicio, DateTime fim) {

            return Vendedores.Sum(Seller => Seller.TotalVendas(inicio, fim));

        }
    }

}
