using Prosesmt.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosesmt.Api.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProsesmtContext context) : base(context)
        {

        }

        public int Count()
        {
            return base.context.Set<Cliente>().Count();
        }
    }
}
