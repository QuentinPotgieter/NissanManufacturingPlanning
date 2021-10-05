using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    class Motor
    {
        public int id;
        public int size;
        public MotorType motorType;
        public String description;

        public Motor(int id, int size, MotorType motorType, String description)
        {
            this.setMotor(id, size, motorType, description);
        }

        private void setMotor(int id, int size, MotorType motorType, String description)
        {
            this.id = id;
            this.size = size;
            this.motorType = motorType;
            this.description = description;
        }

        public int getId()
        {
            return this.id;
        }

        public int getSize()
        {
            return this.size;
        }

        public MotorType getMotorType()
        {
            return this.motorType;
        }

        public String getDescription()
        {
            return this.description;
        }
    }
}
