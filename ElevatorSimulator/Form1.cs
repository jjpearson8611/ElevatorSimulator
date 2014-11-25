using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ElevatorSimulator
{
    public partial class Form1 : Form
    {
        public ElevatorCart cartOne = new ElevatorCart(0,3);
        Random Generator = new Random();
        ArrayList Persons = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentStatusLabel.Text = "Current Status: Waiting For Guests";
            ArrayList temp = new ArrayList();
            temp.Add(this.floorZero);
            temp.Add(this.floorOne);
            temp.Add(this.floorTwo);
            temp.Add(this.floorThree);
            temp.Add(this.floorFour);
            temp.Add(this.floorFive);
            cartOne.Floors = temp;
            cartOne.Status = this.currentStatusLabel;
            Persons = cartOne.doOneTick(Persons);
        }

        private void oneStepButton_Click(object sender, EventArgs e)
        {
            Persons = cartOne.doOneTick(Persons);
        }


        #region PersonGeneration
        private void floorFivePersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(5);
            Persons.Add(temp);
            floorFiveListBox.Items.Add(temp);
        }

        private void floorOnePersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(1);
            Persons.Add(temp);
            floorOneListBox.Items.Add(temp);
        }

        private void floorThreePersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(3);
            Persons.Add(temp);
            floorThreeListBox.Items.Add(temp);
        }

        private void floorTwoPersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(2);
            Persons.Add(temp);
            floorTwoListBox.Items.Add(temp);
        }

        private void floorFourPersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(4);
            Persons.Add(temp);
            floorFourListBox.Items.Add(temp);
        }

        private void floorZeroPersonButton_Click(object sender, EventArgs e)
        {
            Person temp = generatePerson(0);
            Persons.Add(temp);
            floorZeroListBox.Items.Add(temp);
        }

        private Person generatePerson(int start)
        {
            int floor = start;
            while (floor == start)
            {
                floor = Generator.Next(0, 6);
            }

            Person temp = new Person(start, floor);
            return temp;
        }

        #endregion


        private void randomPersonButton_Click(object sender, EventArgs e)
        {
            Random randomGen = new Random();

            switch (randomGen.Next(0, 6))
            {
                case 0:
                    this.floorZeroPersonButton_Click(sender, e);
                    break;
                case 1:
                    this.floorOnePersonButton_Click(sender, e);
                    break;
                case 2:
                    this.floorTwoPersonButton_Click(sender, e);
                    break;
                case 3:
                    this.floorThreePersonButton_Click(sender, e);
                    break;
                case 4:
                    this.floorFourPersonButton_Click(sender, e);
                    break;
                case 5:
                    this.floorFivePersonButton_Click(sender, e);
                    break;
            }
        }
    }
}
