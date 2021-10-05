using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    class Derivative : Vehicle
    {
        private bool electricWindows, automaticGearbox, sunRoof, leatherSeats;
        private int modelId, colorId;

        public Derivative(int modelId, string name, int colorId, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats)
        {
            setDerivative(colorId, modelId, electricWindows, automaticGearbox, sunRoof, leatherSeats);
        }

        public Derivative(int id, String name, int modelID, int color, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats) : base(name)
        {
            setDerivative(color, modelID, electricWindows, automaticGearbox, sunRoof, leatherSeats);
        }

        private void setDerivative(int colorId, int modelId, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats)
        {
            this.colorId = colorId;
            this.modelId = modelId;
            this.electricWindows = electricWindows;
            this.automaticGearbox = automaticGearbox;
            this.sunRoof = sunRoof;
            this.leatherSeats = leatherSeats;
        }

        private bool isElectricWindows()
        {
            return electricWindows;
        }

        private bool isAutomaticGearbox()
        {
            return automaticGearbox;
        }

        private bool isSunRoof()
        {
            return sunRoof;
        }

        private bool isLeatherSeats()
        {
            return leatherSeats;
        }

        private int getColorId()
        {
            return colorId;
        }

        private int getModelId()
        {
            return this.modelId;
        }
    }
}
