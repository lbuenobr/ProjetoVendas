using System;

namespace ProjVendasWebMvc.Models
{
    public class HistoricoVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Double Montante { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public HistoricoVendas()
        {
        }

        public HistoricoVendas(int id, DateTime data, double montante, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
