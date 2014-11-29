using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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
            Direction = -1;
            loading = true;
            this.Floors = new List<Label>();
            this.PersonsOnCart = new List<Person>();
            this.FloorLine = new List<ListBox>();
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

        public int Direction
        {
            get;
            set;
        }
        public ListBox ElevatorInventory
        {
            get;
            set;
        }
        public List<Label> Floors
        {
            get;
            set;
        }
        public List<Person> PersonsOnCart
        {
            get;
            set;
        }
        public Label Status
        {
            get;
            set;
        }
        public List<ListBox> FloorLine
        {
            get;
            set;
        }
        #endregion

        //Public Methods
        public List<Person> doOneTick(List<Person> AllPeople)
        {

            if (AllPeople.Count == 0 && this.ElevatorInventory.Items.Count == 0)
            {
                goToGroundFloor();
            }
            else
            {
                //we are standing still are we done moving what now
                switch (Direction)
                {
                    //going upwards
                    case 1:
                        HandleUp(AllPeople);
                        break;
                    case 0:
                        if (AllPeople.Count != 0)
                        {
                            Direction = 1;
                        }
                        break;

                    //going downwards
                    case -1:
                        HandleDown(AllPeople);
                        break;
                }
            }

            return AllPeople;
        }

        #region HelperFunctions
        //Private Methods
        private void goToGroundFloor()
        {
            if (CurrentFloor > 0)
            {
                Direction = -1;
            }
            else
            {
                Direction = 0;
            }
            updateGUI();
        }

        private void HandleDown(List<Person> AllPeople)
        {
            if (CurrentFloor == 0)
            {
                if (AllPeople.Count == 0 && ElevatorInventory.Items.Count == 0)
                {
                    Direction = 0;
                }
                else
                {
                    Direction = 1;
                }
            }

            GetPeopleAtLevel(AllPeople);
            DropPeopleOff(AllPeople);
            updateGUI();
        }
        private void HandleUp(List<Person> AllPeople)
        {
            //reverse direction if we are at the top
            if (CurrentFloor == 5)
            {
                if (AllPeople.Count == 0 && ElevatorInventory.Items.Count == 0)
                {
                    Direction = 0;
                }
                else
                {
                    Direction = -1;
                }
            }
            GetPeopleAtLevel(AllPeople);
            DropPeopleOff(AllPeople);
            if (AllPeople.Count == 0 && this.ElevatorInventory.Items.Count == 0)
            {
                Direction = 0;
            }

            updateGUI();
        } 

        private void GetPeopleAtLevel(List<Person> AllPeople)
        {
            //check if anyone above us needss to be picked up
            for (int i = 0; i < AllPeople.Count; i++)
            {
                if (AllPeople[i].CurrentFloor == this.CurrentFloor && AllPeople[i].GetDirection() == this.Direction)
                {
                    this.PersonsOnCart.Add(AllPeople[i]);
                    RemoveFromList(this.CurrentFloor, AllPeople[i]);
                    AllPeople.Remove(AllPeople[i]);
                    i--;
                }
            }
        }

        private void RemoveFromList(int floor, Person person)
        {
            switch (floor)
            {
                case 0:
                    FloorLine[0].Items.Remove(person);
                    break;
                case 1:
                    FloorLine[1].Items.Remove(person);
                    break;
                case 2:
                    FloorLine[2].Items.Remove(person);
                    break;
                case 3:
                    FloorLine[3].Items.Remove(person);
                    break;
                case 4:
                    FloorLine[4].Items.Remove(person);
                    break;
                case 5:
                    FloorLine[5].Items.Remove(person);
                    break;
            }
            ElevatorInventory.Items.Add(person);
        }

        private void DropPeopleOff(List<Person> AllPeople)
        {
            //now drop off people we have too
            for (int i = 0; i < this.PersonsOnCart.Count; i++)
            {
                //if they are going to the floor we are on
                if (this.PersonsOnCart[i].DestinationFloor == this.CurrentFloor)
                {
                    //drop them off and remove them from both lists
                    this.ElevatorInventory.Items.Remove(this.PersonsOnCart[i]);
                    this.PersonsOnCart.Remove(this.PersonsOnCart[i]);
                    i--;
                }
            }
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
