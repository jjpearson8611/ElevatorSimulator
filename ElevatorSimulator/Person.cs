using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulator
{
    class Person
    {
        //Constructors
        public Person(int startingFloor, int destinationFloor)
        {
            this.StartingFloor = this.CurrentFloor = startingFloor;
            this.DestinationFloor = destinationFloor;
        }

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

        //Public Methods
        /// <summary>
        /// Starting Floor minus Destination Floor times -1.
        /// Positive is up Negative is down
        /// </summary>
        /// <returns></returns>
        public int GetDirection()
        {
            return (StartingFloor - DestinationFloor) * -1;
        }

        public override string ToString()
        {
            return string.Format("Start: {0} End: {1} Direction: {2}", StartingFloor, DestinationFloor, GetDirection() > 0 ? "up" : "down");
        }
    }
}
