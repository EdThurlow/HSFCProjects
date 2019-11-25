using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        //create the Coach as a public attribute available throughout
        public Coach myCoach = new Coach();
        public Form1()
        {
            InitializeComponent();
        }
        //this method creates a Person with name and age
        //then adds it to the coach
        private void AddButton_Click(object sender, EventArgs e)
        {
            //create a Person with correct name and age
            Person p1 = new Person(NameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
            //add to the Coach;it passes back the seat number
            int seat = myCoach.AddPerson(p1);
            //now display the seat number
            SeatTextBox.Text = seat + "";
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            //to get a name we use nameTextBox.Text --> the previous 'GetSeatByName' is now know
            //as NameTextBox.Text;
            string GetSeatByName = NameTextBox.Text;
            //to set the seat, we set seatTextBox.Text
            string SetSeatByName = SeatTextBox.Text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //to remove a name we use 
            int GetRemovePersonByName = NameTextBox.Text;
        }
    }
}
