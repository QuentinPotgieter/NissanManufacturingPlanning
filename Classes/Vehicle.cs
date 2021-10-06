using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Vehicle
    {
        private String name;

        protected Vehicle()
        {
            new Vehicle("");
        }

        protected Vehicle(String name)
        {
            this.name = name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
    }
}
