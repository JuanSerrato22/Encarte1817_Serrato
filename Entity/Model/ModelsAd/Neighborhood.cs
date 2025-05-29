using Entity.Enums;
using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.ModelsAd
{
    public class Neighborhood : GenericModel
    {
        public int CityId { get; set; }
        public City City { get; set; }
        public User User { get; set; }
        public string CodePostal { get; set; }
    }
}
