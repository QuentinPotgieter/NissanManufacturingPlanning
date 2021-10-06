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
        private string country, address;

        public Plant(int rate, int availability, int shiftDuration, String name, string country, string address) : base(rate, availability, shiftDuration)
        {
            setPlant(name, country, address);
        }

        private void setPlant(String name, string country, string address)
        {
            this.name = name;
            this.country = country;
            this.address = address;
        }

        public String getName()
        {
            return name;
        }

        public string getCountryId()
        {
            return country;
        }

        public string getAddress()
        {
            return address;
        }

        public string getDescription()
        {
            return "'"+getName()+"','"+getCountryId()+"','"+getAddress() + "'," + getRate().ToString() + "," + getAvailablity().ToString() + "," + getShiftDuration().ToString();
        }

        public override bool canProduce(int output)
        {
            return output <= getOutput();
        }
    }
}
