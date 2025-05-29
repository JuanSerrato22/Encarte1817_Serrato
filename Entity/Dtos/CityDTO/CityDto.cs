using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.CityDTO
{
    public class CityDto : UpdateDtoBase
    {
        public string CityCode { get; set; }
        public bool Status { get; set; }
        public int DepartmentId { get; set; }
    }
}
