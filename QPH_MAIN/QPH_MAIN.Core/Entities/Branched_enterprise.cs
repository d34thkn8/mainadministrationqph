using System;
using System.Collections.Generic;
using System.Text;

namespace QPH_MAIN.Core.Entities
{
    public partial class Branched_enterprise: BaseEntity
    {
        public int Id_enterprise { get; set; }
        public string Identification { get; set; }
        public string Direction { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
