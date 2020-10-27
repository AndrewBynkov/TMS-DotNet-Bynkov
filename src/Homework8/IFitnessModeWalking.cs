using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    public interface IFitnessModeWalking
    {
        private double UserAverageSpeed() => default;

        private double UserDistanseWalking() => default;

        private int UserPulseWalking() => default;

        private int UserSteps() => default;

        public void GetInfoWalking();

    }
}
