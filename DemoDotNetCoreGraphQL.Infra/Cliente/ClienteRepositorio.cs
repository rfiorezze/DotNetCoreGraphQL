using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class ClienteRepositorioRepositorio
    {
        private readonly DataContext _context;
        public ClienteRepositorioRepositorio(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> ObterClientes(ClienteFiltro filtro)
        {
            var query = _context.Clientes.AsTracking();
            if (filtro.Id.HasValue && filtro.Id > 0)
                query = query.Where(w => w.Id == filtro.Id);
            if (!string.IsNullOrEmpty(filtro.Nome))
                query = query.Where(w => filtro.Nome.Contains(w.Nome));
            return await query.ToListAsync();
        }
    }
}
