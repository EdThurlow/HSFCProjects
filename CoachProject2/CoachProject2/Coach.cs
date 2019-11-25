using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject2
{
    class Coach
    {
        Person[] contents = new Person[52];
        int nextFreeSeat = 0; // nextFreeSeat is another way
        // of saying free location/space/box
         

        public bool AddPerson(Person thePerson)
        {
            if (nextFreeSeat > 51)
                return false; // when returning 'false' that statement goes (its not relevant anymore),
            // and so you can now start the next statement

            contents[nextFreeSeat] = thePerson;
            nextFreeSeat++;
            return true;

        }

        public int GetSeatByName(String Passenger)
        {
            //if not found return -1, this means there is an error or something
            for (int i = 0; i < nextFreeSeat; i++)
            {
                if (Passenger == contents[i].GetName())
                {
                    return i;
                }


                else

                    return -1;
            }
        }   

        public bool RemovePersonByName(Person thePerson)
            //note: this remove the 1st person found
            //with the name == theName
        {
            int location = GetSeatByName(theName);
        }
        public int GetNumofPassengers()
        {
        }
    }
}
