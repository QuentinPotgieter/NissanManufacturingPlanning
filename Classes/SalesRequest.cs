using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    class SalesRequest
    {
        private int quantity, derivativeId, planId;

        public SalesRequest()
        {
            new SalesRequest(0, 0, 0);
        }

        public SalesRequest(int quantity, int derivativeId, int planId)
        {
            setDemand(quantity, derivativeId, planId);
        }

        private void setDemand(int quantity, int derivativeId, int planId)
        {
            this.quantity = quantity;
            this.derivativeId = derivativeId;
            this.planId = planId;
        }

        private int getQuantity()
        {
            return quantity;
        }

        private int getdDerivativeId()
        {
            return derivativeId;
        }

        private int getPlanId()
        {
            return planId;
        }

        public Boolean isPlanEqual(int capacity)
        {
            return quantity == capacity;
        }

    }
}
