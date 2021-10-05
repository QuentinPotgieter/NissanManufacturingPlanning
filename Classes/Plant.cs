using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Plant : ProductionProgramme
    {
        private String name;
        private int countryId;

        public Plant(int id, int rate, int availability, int shiftDuration, String name, int countryId) : base(id, rate, availability, shiftDuration)
        {
            setPlant(name, countryId);
        }

        private void setPlant(String name, int countryId)
        {
            this.name = name;
            this.countryId = countryId;
        }

        private String getName()
        {
            return name;
        }

        private int getCountryId()
        {
            return countryId;
        }

        public override bool canProduce(int output)
        {
            return output <= getOutput();
        }
    }
}
