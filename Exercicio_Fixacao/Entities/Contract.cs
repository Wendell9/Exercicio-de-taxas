using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime DateTime { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime dateTime, double totalValue)
        {
            Number = number;
            DateTime = dateTime;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }

    }
}
