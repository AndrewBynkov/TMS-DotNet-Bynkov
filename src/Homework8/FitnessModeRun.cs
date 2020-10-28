using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    public class FitnessModeRun : AbcstractFitnessIndicators, IFitnessMode
    {
        private Func<double> DistanseAverageSpeed;
        private Func<int> StepsPulse;

        public FitnessModeRun(int timeRun)
        {
            _timeRun = timeRun;
        }

        /// <summary>
        /// TimeUserRun
        /// </summary>
        private double _timeRun;

        /// <summary>
        /// Distanse Run
        /// </summary>
        public double DistanseRun { get; set; }

        public double UserDistanse() => DistanseRun = GetListUserSpeed().Average() * _timeRun;

        public double UserAverageSpeed() => AverageSpeed = DistanseRun / _timeRun;

        private IEnumerable<int> GetListUserSpeed()
        {
            var userSpeed = new List<int>();

            for (int i = 0; i < _timeRun; i++)
            {
                userSpeed.Add(new Random().Next(0, 45));
            }
            return userSpeed;
        }

        public int UserPulse() => Pulse = (int)GetListUserPulse().Average();

        private IEnumerable<int> GetListUserPulse()
        {
            var userPulse = new List<int>();

            for (int i = 0; i < _timeRun; i++)
            {
                userPulse.Add(new Random().Next(90, 180));
            }
            return userPulse;
        }

        public int UserSteps() => Steps = (int)(GetListUserSteps().Average() * DistanseRun);

        private IEnumerable<double> GetListUserSteps()
        {
            double[] stepsLenght = new double[] { 0.7, 0.9 };
            return stepsLenght;
        }

        private void AddToDeligate()
        {
            DistanseAverageSpeed = UserDistanse;
            DistanseAverageSpeed += UserAverageSpeed;
            StepsPulse = UserPulse;
            StepsPulse += UserSteps;
            DistanseAverageSpeed();
            StepsPulse();
        }


        public void GetInfo()
        {
            AddToDeligate();
            Console.WriteLine($"\nTime of run: {_timeRun} min");
            Console.WriteLine($"You average speed: {(int)AverageSpeed} km/h");
            Console.WriteLine($"You average pulse: {Pulse} bp/m, ");
            Console.WriteLine($"You distanse: {DistanseRun / 1000} km");
            Console.WriteLine($"Count you steps: {Steps}");
            Console.WriteLine($"Time of start walking: {DateTime.Now - new DateTime().AddMinutes(_timeRun).TimeOfDay}");
            Console.WriteLine($"Time of end walking: {DateTime.Now}");
        }
    }
}
