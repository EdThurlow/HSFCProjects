using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject2
{
    class Address
    {
        //address variables
        private String houseName = "";
        private int houseNumber = 0;
        private String streetName = "";
        private String cityName = "";
        private String countryName = "";

        //address methods

        //Setter and Getter methods:
        public void SetHouseName(string theHouseName)
        {
            houseName = theHouseName; //Store the value.
        }

        public string GetName()
        {
            return houseName; //Retrieve the stored value.
        }


        public void SetHouseNumber(int theHouseNumber)
        {
            houseNumber = theHouseNumber;
        }

        public int GetNumber()
        {
            return houseNumber;
        }


        public void SetStreetName(string theStreetName)
        {
            streetName = theStreetName;
        }

        public string GetSteetName()
        {
            return streetName;
        }


        public void SetCityName(string theCityName)
        {
            cityName = theCityName;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public void setCountryName(string theCountryName)
        {
            cityName = theCountryName;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public override string ToString()
        {
            return houseName + houseNumber + streetName + cityName + countryName;
        }

    }
}
