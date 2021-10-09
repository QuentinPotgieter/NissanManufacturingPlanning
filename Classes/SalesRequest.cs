using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class SalesRequest
    {
        private int quantity, derivativeId, planId;
        private DateTime dateRequired;

        public SalesRequest()
        {
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            new SalesRequest(0, 0, 0, dt);
        }

        public SalesRequest(int quantity, int derivativeId, int planId, DateTime dateRequired)
        {
            setDemand(quantity, derivativeId, planId, dateRequired);
        }

        private void setDemand(int quantity, int derivativeId, int planId, DateTime dateRequired)
        {
            this.quantity     = quantity;
            this.derivativeId = derivativeId;
            this.planId       = planId;
            this.dateRequired = dateRequired;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public int getdDerivativeId()
        {
            return derivativeId;
        }


        public int getPlanId()
        {
            return planId;
        }

        public DateTime getDateRequired()
        {
            return dateRequired;
        }

        public Boolean isPlanEqual(int capacity)
        {
            return quantity == capacity;
        }

    }
}
