using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempLab1;

namespace TempLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //predetermind methods
            string averageAge(double ages_sum)
            {
                double average = (ages_sum / 4);
                return $"Average age is: {average}";
            }

            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            
            //line 1
            Console.WriteLine(person2.displayPersonInfo()); 
            //line 2-7
            Console.WriteLine(person3.ToString());
            //line 8
            person1.changeFavouriteColour("White");
            Console.WriteLine(person1.displayPersonInfo());
            //line 9
            Console.WriteLine($"{person4.fname} {person4.lname}'s Age in 10 years is: {person4.getAgeInTenYears()}");
            //line 10 - 11
            Relations relations1 = new Relations("Sister");
            Relations relations2 = new Relations("Brother");
            Console.WriteLine(relations1.showRelationship(person2, person4, "Sister"));
            Console.WriteLine(relations2.showRelationship(person1, person3, "Brother"));
            //line 12
            int ages_sum = (person1.age + person2.age + person3.age + person4.age);
            Console.WriteLine(averageAge(ages_sum));
            //line 13
            string youngest_person = "";
            int youngest_person_age = Math.Min(Math.Min(person1.age, person2.age), Math.Min(person3.age, person4.age));
            if (youngest_person_age == person1.age) // for Ian
            {
                youngest_person = person1.fname;
            }
            else if (youngest_person_age == person2.age) // for Gina
            {
                youngest_person = person2.fname;
            }
            else if (youngest_person_age == person3.age) // for Mike
            {
                youngest_person = person3.fname;
            }
            else if (youngest_person_age == person4.age) // for Mary
            {
                youngest_person = person4.fname;
            }
            Console.WriteLine($"The youngest person is: {youngest_person}");
            //line 14
            string oldest_person = "";
            int oldest_person_age = Math.Max(Math.Max(person1.age, person2.age), Math.Max(person3.age, person4.age));
            if (oldest_person_age == person1.age) // for Ian
            {
                oldest_person = person1.fname;
            }
            else if (oldest_person_age == person2.age) // for Gina
            {
                oldest_person = person2.fname;
            }
            else if (oldest_person_age == person3.age) // for Mike
            {
                oldest_person = person3.fname;
            }
            else if (oldest_person_age == person4.age) // for Mary
            {
                oldest_person = person4.fname;
            }
            Console.WriteLine($"The oldest person is: {oldest_person}");
            //line 15 - 26
            if ((person1.fname).Contains("M")) // for Ian
            {
                Console.WriteLine(person1.ToString());
            }
            if ((person2.fname).Contains("M")) // for Gina
            {
                Console.WriteLine(person2.ToString()); 
            }
            if ((person3.fname).Contains("M")) // for Mike
            {
                Console.WriteLine(person3.ToString());
            }
            if ((person4.fname).Contains("M")) // for Mary
            {
                Console.WriteLine(person4.ToString());
            }
            //line 27+
            if ((person1.fav_colour).Contains("Blue")) // for Ian
            {
                Console.WriteLine(person1.ToString());
            }
            if ((person2.fav_colour).Contains("Blue")) // for Gina
            {
                Console.WriteLine(person2.ToString());
            }
            if ((person3.fav_colour).Contains("Blue")) // for Mike
            {
                Console.WriteLine(person3.ToString());
            }
            if ((person4.fav_colour).Contains("Blue")) // for Mary
            {
                Console.WriteLine(person4.ToString());
            }
        }
    }
}
