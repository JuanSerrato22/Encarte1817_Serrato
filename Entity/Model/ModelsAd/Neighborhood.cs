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
        public string CodePostal { get; set; }
        public StreetType StreetType { get; set; }  // Calle, Carrera, etc.
        public string StreetNumber { get; set; }    // 100
        public StreetLetter StreetLetter { get; set; }    // A, H, B
        public string SecondaryNumber { get; set; }     // 5
        public StreetLetter SecondaryLetter { get; set; }   // A, Z
        public string TertiaryNumber { get; set; }      // 2
        public string AdditionalNumber { get; set; }    // 100
        public StreetLetter AdditionalLetter { get; set; }  // B  
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
