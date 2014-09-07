using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace ElevatorSimulator
{
    public class ElevatorCart
    {

        //Constructors
        public ElevatorCart(int elevatorNumber, int startingFloor = 1, int maxCapacity = int.MaxValue)
        {
            this.ElevatorNumber = elevatorNumber;
            this.CurrentFloor = startingFloor;
        }

        //Properties
        public int CurrentFloor
        {
            get;
            set;
        }
        public int ElevatorNumber
        {
            get;
            set;
        }
        public int Direction
        {
            get;
            set;
        }
        public ArrayList Floors
        {
            get;
            set;
        }
        public ArrayList PersonsOnCart
        {
            get;
            set;
        }
        public Label Status
        {
            get;
            set;
        }

        //Public Methods
        public ArrayList doOneTick(ArrayList AllPeople)
        {
            Direction = 0;
            if (AllPeople.Count == 0)
            {
                goToGroundFloor();
            }
            else
            {
                GetPeopleAtLevel(AllPeople);
                foreach (Person person in DropPeopleOff())
                {
                    AllPeople.Remove(person);
                }
                //determine which way to go
                
            }

            updateGUI();
            return AllPeople;
        }

        //Private Methods
        private void goToGroundFloor()
        {
            if (CurrentFloor == 0)
            {
                Direction = 1;
            }
            else if (CurrentFloor == 1)
            {
                Direction = 0;
            }
            else
            {
                Direction = -1;
            }
        }

        private ArrayList GetPeopleAtLevel(ArrayList AllPeople)
        {
            ArrayList temp = new ArrayList();

            foreach (var person in AllPeople)
            {
                if (((Person)person).CurrentFloor == this.CurrentFloor && ((Person)person).CurrentCart == null)
                {
                    if (this.Direction > 0 && ((Person)person).GetDirection() > 0)
                    {
                        ((Person)person).CurrentCart = this;
                        temp.Add(person);
                    }
                    else if (this.Direction < 0 && ((Person)person).GetDirection() < 0)
                    {
                        ((Person)person).CurrentCart = this;
                        temp.Add(person);
                    }
                }
            }

            return temp;
        }

        private ArrayList DropPeopleOff()
        {
            ArrayList returningList = new ArrayList();
            if (PersonsOnCart != null)
            {
                foreach (var person in PersonsOnCart)
                {
                    if (((Person)person).DestinationFloor == CurrentFloor)
                    {
                        returningList.Add(person);
                    }
                }

            }
            return returningList;
        }

        #region GuiUpdate
        private void setFloor(int floor, int oldFloor = -8675309)
        {
            ((Label)Floors[floor]).BackColor = Color.Lime;
            if (oldFloor != -8675309)
            {
                ((Label)Floors[oldFloor]).BackColor = Color.Gray;
            }
        }

        private void updateStatus(string Status)
        {
            this.Status.Text = Status;
        }

        private void updateGUI()
        {
            if (Direction == 0)
            {
                setFloor(CurrentFloor);
                updateStatus("Current Status: Waiting at Current Floor");
            }
            else if (Direction > 0)
            {
                setFloor(CurrentFloor + 1, CurrentFloor);
                updateStatus("Current Status: Going Up");
                CurrentFloor++;
            }
            else if (Direction < 0)
            {
                setFloor(CurrentFloor - 1, CurrentFloor);
                updateStatus("Current Status: Going Down");
                CurrentFloor--;
            }
        }
        #endregion

    }
}
