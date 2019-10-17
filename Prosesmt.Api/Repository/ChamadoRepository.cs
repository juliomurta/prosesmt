using Prosesmt.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosesmt.Api.Repository
{
    public class ChamadoRepository : GenericRepository<Chamado>, IChamadoRepository
    {
        public ChamadoRepository(ProsesmtContext context):base(context)
        {

        }
    }
}
