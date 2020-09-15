using QPH_MAIN.Core.CustomEntities;
using QPH_MAIN.Core.Entities;
using QPH_MAIN.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QPH_MAIN.Core.Interfaces
{
    public interface IBranched_EnterpriseService
    {
        PagedList<Branched_enterprise> GetBranched_Enterprises(Branched_EnterpriseQueryFilter filters);
        Task<Branched_enterprise> GetBranched_Enterprise(int id);
        Task InsertBranched_Enterprise(Branched_enterprise branchedEnterprise);
        Task<bool> UpdateBranched_Enterprise(Branched_enterprise branchedEnterprise);
        Task<bool> DeleteBranched_Enterprise(int id);
    }
}
