using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QPH_MAIN.Api.Responses;
using QPH_MAIN.Core.CustomEntities;
using QPH_MAIN.Core.DTOs;
using QPH_MAIN.Core.Interfaces;
using QPH_MAIN.Core.QueryFilters;
using QPH_MAIN.Infrastructure.Interfaces;

namespace QPH_MAIN.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchedEnterpriseController : ControllerBase
    {
        private readonly IBranched_EnterpriseService _branched_enterpriseService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        public BranchedEnterpriseController(IBranched_EnterpriseService branched_EnterpriseService, IMapper mapper, IUriService uriService)
        {
            _branched_enterpriseService = branched_EnterpriseService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpPost("RetrieveBranchedEnterprises")]
        public IActionResult GetBranched_Enterprise([FromBody] Branched_EnterpriseQueryFilter filtro)
        {
            var branched = _branched_enterpriseService.GetBranched_Enterprises(filtro);
            var otro = _mapper.Map<IEnumerable<Branched_EnterpriseDto>>(branched);
            var metadata = new Metadata
            {
                TotalCount = branched.TotalCount,
                PageSize = branched.PageSize,
                CurrentPage = branched.CurrentPage,
                TotalPages = branched.TotalPages,
                HasNextPage = branched.HasNextPage,
                HasPreviousPage = branched.HasPreviousPage
            };
            var response = new ApiResponse<IEnumerable<Branched_EnterpriseDto>>(otro)
            {
                Meta = metadata
            };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return Ok(response);
        }
    }
}
