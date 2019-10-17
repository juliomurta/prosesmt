using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosesmt.Api.Models.ViewModels
{
    public enum Status
    {
        OK,
        Erro,
        Invalido
    }

    public class ClienteViewModel
    {
        public Status Status { get; set; }

        public string Mensagem { get; set; }

        public int TotalItens { get; set; }

        public IEnumerable<Cliente> Clientes { get; set; }

        public Cliente Cliente { get; set; }
    }
}
