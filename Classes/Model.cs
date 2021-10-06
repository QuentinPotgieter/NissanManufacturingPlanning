using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Model : Vehicle
    {
        private string name;
        private int motorId;
        private int year;

        public Model(string name, int motorId, int year) {
            setModel(name, motorId, year);
        }

        public Model(string modelType, int motorId, int year, int Id, String Name) : base(Name)
        {
            setModel(modelType, motorId, year);
        }

        private void setModel(string modelType, int motorId, int year) {
            this.name = modelType;
            this.motorId = motorId;
            this.year = year;
        }

         public string getName() {
            return name;
        }

        public int getMotorId() {
            return motorId;
        }

        public int getYear() {
            return year;
        }

    }
}
