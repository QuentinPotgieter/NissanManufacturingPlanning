using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Derivative : Vehicle
    {
        private bool electricWindows, automaticGearbox, sunRoof, leatherSeats;
        private int modelId;
        string color;

        public Derivative(int modelId, string name, string color, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats)
        {
            setDerivative(color, modelId, electricWindows, automaticGearbox, sunRoof, leatherSeats);
        }

        public Derivative(int id, String name, int modelID, string color, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats) : base(name)
        {
            setDerivative(color, modelID, electricWindows, automaticGearbox, sunRoof, leatherSeats);
        }

        private void setDerivative(string color, int modelId, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats)
        {
            this.color = color;
            this.modelId = modelId;
            this.electricWindows = electricWindows;
            this.automaticGearbox = automaticGearbox;
            this.sunRoof = sunRoof;
            this.leatherSeats = leatherSeats;
        }

        public bool isElectricWindows()
        {
            return electricWindows;
        }

        public bool isAutomaticGearbox()
        {
            return automaticGearbox;
        }

        public bool isSunRoof()
        {
            return sunRoof;
        }

        public bool isLeatherSeats()
        {
            return leatherSeats;
        }

        public string getColorId()
        {
            return color;
        }

        public int getModelId()
        {
            return this.modelId;
        }
    }
}
