using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.ModelsAd
{
    public class Employee : BaseEntity
    {
        public string EmployeeCode { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal WorkSchedule { get; set; }
        public DateTime HiringDate { get; set; } //fecha de contratación
        public DateTime TerminationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
