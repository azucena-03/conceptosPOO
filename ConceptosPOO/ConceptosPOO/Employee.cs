using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public abstract class Employee: IPay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HireDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"id{Id} - {FirstName} {LastName}, Birth: {BirthDate}, Hire: {HireDate}, Is Active: {IsActive}";
        }
    }
}
