using System;
using System.Linq;

namespace Homework8
{
    class FitnessModeWalking : AbcstractFitnessIndicators
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

        private double UserDistanseWalking() => DistanseWalking = AverageSpeed * _timeWalking;

        private int UserPulseWalking()
        {
            int[] heartRate = new int[] { 60, 100 };
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

            Console.WriteLine("Time run - 5 min");
            Console.WriteLine($"You speed: {AverageSpeed} km/h");
            Console.Write($"You pulse: {Pulse} bp/m, ");
            Notify?.Invoke();
            Console.WriteLine($"You distanse: {DistanseWalking / 100} km");
            Console.WriteLine($"Count you steps: {Steps}");
            Console.WriteLine($"Date now: {DateTime.Now}");
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
