using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.ModelsAd
{
    public class City : GenericModel
    {
        public int DeparmentId { get; set; }
        public Department Department { get; set; }

        // Relación: Una ciudad puede tener muchos clientes
        public ICollection<Client> Clientes { get; set; }
        public ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
