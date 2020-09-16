using System;
using System.Collections.Generic;
using System.Text;

namespace QPH_MAIN.Core.DTOs
{
    public class Branched_EnterpriseDto
    {
        public int Id { get; set; }
        public int Id_enterprise { get; set; }
        public string Identification { get; set; }
        public string Direction { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool Status { get; set; }
    }
}
