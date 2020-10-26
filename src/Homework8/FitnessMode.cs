using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    class FitnessMode : FitnessIndicators, IFitnessMode
    {
        public FitnessMode(DateTime timeNow)
        {
            _timeWalking = (timeNow.Minute + 5) - timeNow.Minute;
        }

        private double _timeWalking;

        public double DistanseWalking { get; set; }

        public double Walking() => DistanseWalking = AverageSpeed * _timeWalking;
        


    }
}
