using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.ModelsAd
{
    public class Department : GenericModel
    {
        public string DepartmentCode { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<City> City { get; set; }
    }
}
