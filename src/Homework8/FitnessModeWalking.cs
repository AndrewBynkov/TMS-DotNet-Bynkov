using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    class FitnessModeWalking : AbcstractFitnessIndicators, IFitnessModeWalking
    {
        public event Action Notify;
        public Func<double> SpeedAndDistance;
        public Func<int> PulseAndSteps;

        public FitnessModeWalking(DateTime timeNow)
        {
            _timeWalking = (timeNow.Minute + 5) - timeNow.Minute;
        }

        /// <summary>
        /// TimeUserWalking
        /// </summary>
        private double _timeWalking;

        /// <summary>
        /// DistanseUserWalking
        /// </summary>
        public double DistanseWalking { get; set; }

        private double UserAverageSpeed()
        {
            int[] speedWalking = new int[] { 2, 5 };
            AverageSpeed = speedWalking.Average();
            return AverageSpeed;
        }

        private double UserDistanseWalking()
        {
            DistanseWalking = AverageSpeed * _timeWalking;
            return DistanseWalking;
        }

        private int UserPulseWalking()
        {
            int[] heartRate = new int[] { 60, 100 };
            Pulse = (int)heartRate.Average();
            return Pulse;
        }

        private int UserSteps()
        {
            double[] stepsLenght = new double[] { 0.07, 0.09 };
            Steps = (int)(DistanseWalking / stepsLenght.Average());
            return Steps;
        }
        public void AddToDeligate()
        {
            SpeedAndDistance = UserAverageSpeed;
            SpeedAndDistance += UserDistanseWalking;
            PulseAndSteps = UserPulseWalking;
            PulseAndSteps += UserSteps;
            PulseAndSteps();
            SpeedAndDistance();
        }

        public void GetInfoWalking()
        {
            AddToDeligate();
            Console.WriteLine($"You speed: {AverageSpeed} km/h");
            Console.WriteLine($"You pulse: {Pulse} bp/m");
            Console.WriteLine($"You distanse: {DistanseWalking} km");
            Console.WriteLine($"Count you steps: {Steps}");
        }

        public void Massage()
        {
            if (Pulse >70)
            {
                Console.Write("Fast heart rate > 60! ");
            }
            else
            {
                Console.Write("You are at ease");
            }
            
        }
    }
}
