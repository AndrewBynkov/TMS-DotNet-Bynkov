using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    public interface IFitnessMode
    {
        public double UserAverageSpeed();

        public double UserDistanseWalking();

        public int UserPulseWalking();

        public int UserSteps();

        public void GetInfoWalking();

    }
}
