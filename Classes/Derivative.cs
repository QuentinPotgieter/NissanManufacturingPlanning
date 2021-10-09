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
        private int modelId, motorId;
        string color;

        public Derivative(int modelId, string name, string color, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats, int motorId)
        {
            setDerivative(color, modelId, electricWindows, automaticGearbox, sunRoof, leatherSeats, motorId);
        }

        public Derivative(int id, String name, int modelID, string color, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats, int motorId) : base(name)
        {
            setDerivative(color, modelID, electricWindows, automaticGearbox, sunRoof, leatherSeats, motorId);
        }

        private void setDerivative(string color, int modelId, bool electricWindows, bool automaticGearbox, bool sunRoof, bool leatherSeats, int motorId)
        {
            this.color = color;
            this.modelId = modelId;
            this.electricWindows = electricWindows;
            this.automaticGearbox = automaticGearbox;
            this.sunRoof = sunRoof;
            this.leatherSeats = leatherSeats;
            this.motorId = motorId;
        }

        public int getMotorId()
        {
            return motorId;
        }
        public int isElectricWindows()
        {
            if (electricWindows) return 1; else return 0;
        }

        public int isAutomaticGearbox()
        {
            if (automaticGearbox) return 1; else return 0;
        }

        public int isSunRoof()
        {
            if (sunRoof) return 1; else return 0;
        }

        public int isLeatherSeats()
        {
            if (leatherSeats) return 1; else return 0;
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
