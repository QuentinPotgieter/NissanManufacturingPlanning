using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public abstract class ProductionProgramme
    {
        public int id;
        public int rate;
        public int availablilty;
        public int shiftDuration;

        public ProductionProgramme(int id, int rate, int availablilty, int shiftDuration)
        {
            setOutput(id, rate, availablilty, shiftDuration);
        }

        public void setOutput(int id, int rate, int availablilty, int shiftDuration)
        {
            this.id = id;
            this.rate = rate;
            this.availablilty = availablilty;
            setShiftDurationInMinutes(shiftDuration);
        }

        private void setShiftDurationInMinutes(int shiftDuration)
        {
            this.shiftDuration = shiftDuration * 60;
        }

        public int getId()
        {
            return id;
        }

        private int getRate()
        {
            return rate;
        }

        private int getAvailablity()
        {
            return availablilty;
        }

        private int getShiftDuration()
        {
            return shiftDuration;
        }

        public int getOutput()
        {
            return (getRate() * getAvailablity() * getShiftDuration()) / 100;
        }

        public abstract bool canProduce(int output);
    }
}
