using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Model : Vehicle
    {
        private string modelType;
        private int motorId;
        private int year;

        public Model(string modelType, int motorId, int year) {
            setModel(modelType, motorId, year);
        }

        public Model(string modelType, int motorId, int year, int Id, String Name) : base(Name)
        {
            setModel(modelType, motorId, year);
        }

        private void setModel(string modelType, int motorId, int year) {
            this.modelType = modelType;
            this.motorId = motorId;
            this.year = year;
        }

         public string getTypeId() {
            return modelType;
        }

        public int getMotorId() {
            return motorId;
        }

        public int getYear() {
            return year;
        }

    }
}
