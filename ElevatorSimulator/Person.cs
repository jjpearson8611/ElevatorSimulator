using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulator
{
    public class Person
    {
        //Constructors
        public Person(int startingFloor, int destinationFloor)
        {
            this.StartingFloor = this.CurrentFloor = startingFloor;
            this.DestinationFloor = destinationFloor;
        }

        public Person()
        {
            Random TempRandom = new Random();
            
            this.StartingFloor = TempRandom.Next(0, 6);
            this.DestinationFloor = TempRandom.Next(0, 6);

            while(this.DestinationFloor == this.StartingFloor)
            {
                this.DestinationFloor = TempRandom.Next(0, 6);
            }

        }


        #region Properties

        //Properties
        public int StartingFloor
        {
            get;
            set;
        }
        public int DestinationFloor
        {
            get;
            set;
        }
        public int CurrentFloor
        {
            get;
            set;
        }
        public ElevatorCart CurrentCart
        {
            get;
            set;
        }
        #endregion

        //Public Methods
        /// <summary>
        /// Starting Floor minus Destination Floor times -1.
        /// Positive is up Negative is down
        /// </summary>
        /// <returns></returns>
        public int GetDirection()
        {
            if (StartingFloor > DestinationFloor)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return string.Format("Start: {0} End: {1} Direction: {2}", StartingFloor, DestinationFloor, GetDirection() > 0 ? "up" : "down");
        }
    }
}
