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
        public String description, motorType;

        public Motor(int size, String motorType, String description)
        {
            this.setMotor(size, motorType, description);
        }

        private void setMotor(int size, String motorType, String description)
        {
            this.size = size;
            this.motorType = motorType;
            this.description = description;
        }

        public int getSize()
        {
            return this.size;
        }

        public String getMotorType()
        {
            return this.motorType;
        }

        public String getDescription()
        {
            return this.description;
        }
    }
}
