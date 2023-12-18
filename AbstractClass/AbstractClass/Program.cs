using System;

namespace AbstractClass
{

    public abstract class Car
    {

        #region Public Properties
        // virtual methods allow the dervied class to override the function implementation


        public abstract int WheelDiameterInches { get; }

        /// <summary>
        /// Indicates if the handbrake is released
        /// </summary>
        public bool HandBrakeRelased { get; set; } = false;

        #endregion

        #region Public Methods

        /// <summary>
        /// Turns the car radio on
        /// </summary>
        public virtual void RadioOn()
        {
            Console.WriteLine("Turned the radio on");
        }

        /// <summary>
        /// Attempts to release the cars handbrake
        /// </summary>
        public virtual void ReleaseHandbrake()
        {
            HandBrakeRelased = true;
            Console.WriteLine("Successfully released the handbrake");
        }


        /// <summary>
        /// Goes on the gas to drive the car
        /// </summary>
        public virtual void Drive()
        {
            // Release the handbrake
            ReleaseHandbrake();
            if (HandBrakeRelased)
            {
                Console.WriteLine("Pressed the gas peddle");
            }
            else
            {
                Console.WriteLine("Cannot move... hardbrake jammed");
            }

        }
        // Standard methods
        public float GearboxOutputSpeedRpm()
        {
            return 1000;
        }
        public float CalculateSpeedMph()
        {
            // if handbrake is on, we are not moving
            if  (!HandBrakeRelased)
                return 0;

            var inchesPerRev = (float)(Math.PI * WheelDiameterInches);
            var inchesPerMinute = inchesPerRev * GearboxOutputSpeedRpm();
            var mph = inchesPerMinute * 60 * 0.0000157828;

            return (float)mph;
        }



        #endregion
    }

    public class BudgetCar : Car
    {
        public override int WheelDiameterInches => 16;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow World!");
        }
    }


}