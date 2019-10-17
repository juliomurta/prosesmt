using Prosesmt.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosesmt.Api.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        int Count();
    }
}
