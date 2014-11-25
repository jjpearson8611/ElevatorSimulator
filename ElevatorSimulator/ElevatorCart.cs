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
            Direction = 0;
            loading = true;
            otherDirection = 0;
        }


        #region Properites
        //Properties
        public bool loading
        {
            get;
            set;
        }
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
        public int otherDirection
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
        #endregion

        //Public Methods
        public ArrayList doOneTick(ArrayList AllPeople)
        {
            if (AllPeople.Count == 0)
            {
                goToGroundFloor();
            }
            else
            {
                //we are standing still are we done moving what now
                if (Direction == 0)
                {
                    if (loading)
                    {
                        GetPeopleAtLevel(AllPeople);
                        foreach (Person person in DropPeopleOff())
                        {
                            AllPeople.Remove(person);
                        }
                        loading = false;
                    }
                    else
                    {
                        Direction = otherDirection;
                    }
                }

                //going upwards
                if (Direction == 1)
                {
                    if (CurrentFloor == 5)
                    {
                        Direction = -1;
                    }
                    otherDirection = Direction;
                }

                //going downwards
                if (Direction == -1)
                {
                    if (CurrentFloor == 0)
                    {
                        Direction = 1;
                    }
                    otherDirection = Direction;
                }

            }

            updateGUI();
            return AllPeople;
        }

        #region HelperFunctions
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
                //the person wants this floor and is in the cart
                if (((Person)person).CurrentFloor == this.CurrentFloor && ((Person)person).CurrentCart == null)
                {
                    //are we going the way that the person wants?
                    if (this.Direction > 0 && ((Person)person).GetDirection() > 0)
                    {
                        ((Person)person).CurrentCart = this;
                        temp.Add(person);
                    }

                    //are we going the way that the person wants?
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
        #endregion

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
