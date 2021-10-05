using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    class Country
    {
        private String description;

        public Country()
        {
            new Country("");
        }

        public Country(String description)
        {
            setCountry(description);
        }

        private void setCountry(String description)
        {
            this.description = description;
        }

        private String getDescription()
        {
            return description;
        }
    }
}
