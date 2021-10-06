using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Motor
    {
        public int size;
        public string description, motorType;

        public Motor(int size, string motorType, string description)
        {
            this.setMotor(size, motorType, description);
        }

        private void setMotor(int size, string motorType, string description)
        {
            this.size = size;
            this.motorType = motorType;
            this.description = description;
        }

        public int getSize()
        {
            return this.size;
        }

        public string getMotorType()
        {
            return this.motorType;
        }

        public string getDescription()
        {
            return this.description;
        }
    }
}
