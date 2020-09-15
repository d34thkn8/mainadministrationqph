using System;
using System.Collections.Generic;
using System.Text;

namespace QPH_MAIN.Core.QueryFilters
{
    public class Branched_EnterpriseQueryFilter
    {
        public string filter { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public List<SortModel> orderedBy { get; set; }
    }
}
