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
        public User User { get; set; }
        public int UserId { get; set; }
        public string TaxId { get; set; } // NIT
        public string BusinessType { get; set; } 
        public string ServicesProvided { get; set; }
    }
}
