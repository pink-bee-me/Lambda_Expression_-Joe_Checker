using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression__Joe_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listOfEmployees = new List<Employee>();

            listOfEmployees.Add(new Employee("Joe", "Blow", 1));
            listOfEmployees.Add(new Employee("Joe", "Dirt", 3));
            listOfEmployees.Add(new Employee("Joe", "Schmoe", 4));
            listOfEmployees.Add(new Employee("Josephine", "Joe", 5));
            listOfEmployees.Add(new Employee("Party", "Hardy", 7));
            listOfEmployees.Add(new Employee("Johnny", "Appleseed", 8));
            listOfEmployees.Add(new Employee("Jesse", "Techguy", 9));
            listOfEmployees.Add(new Employee("Joe", "Lean", 10));


            List<Employee> listOfAverageJoes = new List<Employee>();

            for (var i = 0; i < listOfEmployees.Count; i++)

                if (listOfEmployees[i].FirstName == "Joe") {
                   listOfEmployees[i] = listOfAverageJoes
                }
        }


    }
}  
