using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class VehicleColor
    {
        public int id;
        public String description;

        public VehicleColor(String description)
        {
            this.setColor(description);
        }

        private void setColor(String description)
        {
            this.description = description;
        }

        public String getDescription()
        {
            return this.description;
        }
    }
}
