using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    public class FitnessModeWalking : AbcstractFitnessIndicators
    {
        public Func<double> SpeedAndDistance;
        public Func<int> PulseAndSteps;
        public event Action Notify;

        public FitnessModeWalking(int timeWalking)
        {
            _timeWalking = timeWalking;
        }

        /// <summary>
        /// TimeUserWalking
        /// </summary>
        private int _timeWalking;

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

        private double UserDistanseWalking() => DistanseWalking = AverageSpeed * _timeWalking;

        private int UserPulseWalking()
        {
            List<int> heartRate = new List<int> { 60, 100 };
            Pulse = (int)heartRate.Average();
            return Pulse;
        }

        private int UserSteps()
        {
            double[] stepsLenght = new double[] { 0.7, 0.9 };
            var countSteps = DistanseWalking / stepsLenght.Average();
            return Steps = (int)countSteps;
        }

        public void AddToDeligate()
        {
            SpeedAndDistance = UserAverageSpeed;
            SpeedAndDistance += UserDistanseWalking;
            PulseAndSteps = UserPulseWalking;
            PulseAndSteps += UserSteps;
            SpeedAndDistance();
            PulseAndSteps();
        }

        public void GetInfoWalking()
        {
            AddToDeligate();
            Notify += Massage;

            Console.WriteLine($"\nTime walking: {_timeWalking} min");
            Console.WriteLine($"You average speed: {AverageSpeed} km/h");
            Console.Write($"You pulse: {Pulse} bp/m, ");
            Notify?.Invoke();
            Console.WriteLine($"You distanse: {DistanseWalking / 1000} km");
            Console.WriteLine($"Count you steps: {Steps}");
            Console.WriteLine($"Time of start walking: {DateTime.Now - new DateTime().AddMinutes(_timeWalking).TimeOfDay}");
            Console.WriteLine($"Time of end walking: {DateTime.Now}");
        }

        public void Massage()
        {
            if (Pulse > 70)
            {
                Console.WriteLine("Fast heart rate > 60! ");
            }
            else
            {
                Console.WriteLine("Pulse normal.");
            }
        }
    }
}
