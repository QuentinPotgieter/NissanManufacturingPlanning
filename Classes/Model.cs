using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public class Model : Vehicle
    {
        public string name;
        private int year;

        public Model(string name, int year) {
            setModel(name, year);
        }

        public Model(string modelType, int year, int Id, String Name) : base(Name)
        {
            setModel(modelType, year);
        }

        private void setModel(string modelType, int year) {
            this.name = modelType;
            this.year = year;
        }

        public int getYear() {
            return year;
        }

    }
}
