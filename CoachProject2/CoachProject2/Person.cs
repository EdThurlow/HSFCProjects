using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject2
{
    class Person
    {
        //person variables
        private String name = "";
        private int age = 0;
        private Address livesat;
        public Person(String aName)
        {
            name = aName;
        }
        public Person(int anAge)
        {
            age = anAge;
        }


        //person methods

        //setter and getter methods:
        public void setName(string theName)
        {
            name = theName; //store the value.
        }

        public String getName()
        {
            return name; //Retrieve the stored value.

        }

        public void setAge(int theAge)
        {
            age = theAge;
        }

        public int getAge()
        {
            return age;
        }

        public void setLivesat(Address lives)
        {
            livesat = lives;
        }

        public Address getlivesat()
        {
            return livesat;
        }

        public override string ToString()
        {
            return name + age + livesat;
        }



    }
}
