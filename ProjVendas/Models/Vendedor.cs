using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;
using ProjVendas.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjVendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public ICollection<HistoricoVendas> Vendas { get; set; } = new List<HistoricoVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionaVendedor(HistoricoVendas historicoVendas) {
            Vendas.Add(historicoVendas);
        }

        public void RemoveVendas(HistoricoVendas historicoVendas){
            Vendas.Remove(historicoVendas);
            }

        public double TotalVendas(DateTime datainicio, DateTime dataFim) {

            return Vendas.Where(sr => sr.Data > datainicio && sr.Data < dataFim).Sum(sr => sr.Montante); 

        }
    }
}
