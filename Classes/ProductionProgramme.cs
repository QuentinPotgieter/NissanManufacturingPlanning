using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NissanManufacturingPlanning.Classes
{
    public abstract class ProductionProgramme
    {
        public int rate;
        public int availablilty;
        public int shiftDuration;

        public ProductionProgramme(int rate, int availablilty, int shiftDuration)
        {
            setOutput( rate, availablilty, shiftDuration);
        }

        public void setOutput( int rate, int availablilty, int shiftDuration)
        {
            this.rate = rate;
            this.availablilty = availablilty;
            setShiftDurationInMinutes(shiftDuration);
        }

        private void setShiftDurationInMinutes(int shiftDuration)
        {
            this.shiftDuration = shiftDuration * 60;
        }

        public int getRate()
        {
            return rate;
        }

        public int getAvailablity()
        {
            return availablilty;
        }

        public int getShiftDuration()
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
