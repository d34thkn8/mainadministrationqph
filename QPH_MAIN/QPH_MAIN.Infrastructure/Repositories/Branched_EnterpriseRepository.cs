using QPH_MAIN.Core.Entities;
using QPH_MAIN.Core.Interfaces;
using QPH_MAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QPH_MAIN.Infrastructure.Repositories
{
    public class Branched_EnterpriseRepository: BaseRepository<Branched_enterprise>,IBranched_EnterpriseRepository
    {
        public Branched_EnterpriseRepository(QPHContext context) : base(context) { }
        //public async Task<IEnumerable<Branched_enterprise>> GetCitiesByIdRegion(int regionId) => await _entities.Where(x => x.id_region == regionId).ToListAsync();
    }
}
