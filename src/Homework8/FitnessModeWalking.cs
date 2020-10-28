using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    public class FitnessModeWalking : AbcstractFitnessIndicators
    {
        private Func<double> SpeedAndDistance;
        private Func<int> PulseAndSteps;
        private event Action Notify;

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
        public double DistanseWalking { get; private set; }

        private double UserAverageSpeed()
        {
            int[] speedWalking = new int[] { 2, 5 };
            AverageSpeed = speedWalking.Average();
            return AverageSpeed;
        }

        private double UserDistanseWalking() => DistanseWalking = AverageSpeed * _timeWalking;

        private int UserPulseWalking() => Pulse = (int)GetRandomList().Average();

        private void Massage()
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

        private IEnumerable<int> GetRandomList()
        {
            var list = new List<int>();
            for (int i = 0; i < _timeWalking; i++)
            {
                list.Add(new Random().Next(50, 90));
            }

            return list;
        }

        private int UserSteps()
        {
            double[] stepsLenght = new double[] { 0.7, 0.9 };
            var countSteps = DistanseWalking / stepsLenght.Average();
            return Steps = (int)countSteps;
        }
        
        private void AddToDeligate()
        {
            SpeedAndDistance = UserAverageSpeed;
            SpeedAndDistance += UserDistanseWalking;
            PulseAndSteps = UserPulseWalking;
            PulseAndSteps += UserSteps;
            Notify += Massage;
            SpeedAndDistance();
            PulseAndSteps();
        }
        
        public void GetInfoWalking()
        {
            AddToDeligate();
            Console.WriteLine($"\nTime walking: {_timeWalking} min");
            Console.WriteLine($"You average speed: {AverageSpeed} km/h");
            Console.Write($"You pulse: {Pulse} bp/m, ");
            Notify?.Invoke();
            Console.WriteLine($"You distanse: {DistanseWalking / 1000} km");
            Console.WriteLine($"Count you steps: {Steps}");
            Console.WriteLine($"Time of start walking: {DateTime.Now - new DateTime().AddMinutes(_timeWalking).TimeOfDay}");
            Console.WriteLine($"Time of end walking: {DateTime.Now}");
        }
    }
}
