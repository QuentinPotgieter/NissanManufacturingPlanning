using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    class Model : Vehicle
    {
        private ModelType modelType;
        private int motorId;
        private int year;

        private Model(ModelType modelType, int motorId, int year) {
            setModel(modelType, motorId, year);
        }

        public Model(ModelType modelType, int motorId, int year, int Id, String Name) : base(Name)
        {
            setModel(modelType, motorId, year);
        }

        private void setModel(ModelType modelType, int motorId, int year) {
            this.modelType = modelType;
            this.motorId = motorId;
            this.year = year;
        }

        private ModelType getTypeId() {
            return modelType;
        }

        private int getMotorId() {
            return motorId;
        }

        private int getYear() {
            return year;
        }

    }
}
