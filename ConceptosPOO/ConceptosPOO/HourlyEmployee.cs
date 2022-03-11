using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:P2}",18}" +
                $"\n\tHour Value.... ......: {$"{HourValue:N2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
