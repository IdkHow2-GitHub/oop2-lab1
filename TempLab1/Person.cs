using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempLab1
{
    internal class Person
    {
        public int person_id;
        public string fname;
        public string lname;
        public string fav_colour;
        public int age;
        public bool is_working;

        public Person(int person_id, string fname, string lname, string fav_colour, int age, bool is_working)
        {
            this.person_id = person_id;
            this.fname = fname;
            this.lname = lname;
            this.fav_colour = fav_colour;
            this.age = age;
            this.is_working = is_working;
        }

        public string displayPersonInfo()
        {
            string name = $"{fname} {lname}";
            return $"{person_id}: {name}’s favourite colour is {fav_colour}";
        }
        public string changeFavouriteColour(string new_fav_colour)
        {
            fav_colour = new_fav_colour;
            return fav_colour;
        }
        public int getAgeInTenYears()
        {
            int age_in_ten_years = age + 10;
            return age_in_ten_years;
        }
        public string ToString()
        {
            return $"PersonID: {person_id}\n" +
                $"FirstName: {fname}\n" +
                $"LastName: {lname}\n" +
                $"FavouriteColour: {fav_colour}\n" +
                $"Age: {age}\n" +
                $"IsWorking: {is_working}";
        }
    }
}