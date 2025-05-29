using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ClientDTO
{
    public class ClientDto : UpdateDtoBase
    {
        public bool Active { get; set; }
        public string PaymentTerms { get; set; }
        public int UserId { get; set; }
    }
}
