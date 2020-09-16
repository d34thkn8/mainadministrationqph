using Microsoft.Extensions.Options;
using QPH_MAIN.Core.CustomEntities;
using QPH_MAIN.Core.Entities;
using QPH_MAIN.Core.Interfaces;
using QPH_MAIN.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPH_MAIN.Core.Services
{
    public class Branched_EnterpriseService: IBranched_EnterpriseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;

        public Branched_EnterpriseService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }

        public Task<bool> DeleteBranched_Enterprise(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Branched_enterprise> GetBranched_Enterprise(int id)
        {
            throw new NotImplementedException();
        }

        public PagedList<Branched_enterprise> GetBranched_Enterprises(Branched_EnterpriseQueryFilter filters)
        {
            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            var branched = _unitOfWork.Branched_EnterpriseRepository.GetAll();
            if (filters.filter != null)
            {
                branched = branched.Where(x => x.Identification.ToLower().Contains(filters.filter.ToLower()));
            }
            var pagedPosts = PagedList<Branched_enterprise>.Create(branched, filters.PageNumber, filters.PageSize);
            return pagedPosts;
        }

        public async Task InsertBranched_Enterprise(Branched_enterprise branched)
        {
            await _unitOfWork.Branched_EnterpriseRepository.Add(branched);
            await _unitOfWork.SaveChangesAsync();
        }

        public Task<bool> UpdateBranched_Enterprise(Branched_enterprise branchedEnterprise)
        {
            throw new NotImplementedException();
        }
    }
}
