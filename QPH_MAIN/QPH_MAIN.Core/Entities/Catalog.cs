using System.Collections.Generic;

namespace QPH_MAIN.Core.Entities
{
    public partial class Catalog : BaseEntity
    {
        public Catalog()
        {
            enterpriseCatalog = new HashSet<EnterpriseHierarchyCatalog>();
        }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
        public virtual ICollection<EnterpriseHierarchyCatalog> enterpriseCatalog { get; set; }
    }
    /*

    public class Empresa
    {
        public int Empresaid { get; set; }
        public string otro { get; set; }

        public ICollection<EmpresaCanal> Canales { get; set; }

        
    }

    public class Canal
    {
        public int Canalid { get; set; }
        public string Otro { get; set; }
        public ICollection<EmpresaCanal> Empresas {get;set;}

     
    }

    public class EmpresaCanal
    {
        public int EmpresaId { get; set; }
        public int CanalId { get; set; }



        public Empresa Empresa { get; set; }
        public Canal Canal { get; set; }
    }
    public class Prueba
    {
       public void tmp()
        {
            var tmp2 = new EmpresaCanal();

            tmp2.Empresa.Canales
        }
    }*/
}