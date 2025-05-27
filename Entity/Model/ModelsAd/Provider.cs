using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.ModelsAd
{
    public class Provider : GenericModel
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }

        // Relación: Un proveedor puede tener muchos clientes 
        public ICollection<Client> Clients { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
