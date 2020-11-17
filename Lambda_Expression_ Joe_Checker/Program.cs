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
            listOfEmployees.Add(new Employee("Joe", "Cool", 2));
            listOfEmployees.Add(new Employee("Joe", "Dirt", 3));
            listOfEmployees.Add(new Employee("Joe", "Schmoe", 4));
            listOfEmployees.Add(new Employee("Angelina", "Jolie", 5));
            listOfEmployees.Add(new Employee("Joe", "Black", 6));
            listOfEmployees.Add(new Employee("Party", "Hardy", 7));
            listOfEmployees.Add(new Employee("Johnny", "Appleseed", 8));
            listOfEmployees.Add(new Employee("Jesse", "Techguy", 9));
            listOfEmployees.Add(new Employee("Joe", "Lean", 10));




            List<Employee> listOfAverageJoes = new List<Employee>();
            Console.WriteLine("Employee List");
            for (var i = 0; i < listOfEmployees.Count; i++)
            {
                Console.WriteLine("Employee Name: " + listOfEmployees[i].FirstName + " " + listOfEmployees[i].LastName +
                   "   Id: " + listOfEmployees[i].Id + "\n");

                if (listOfEmployees[i].FirstName == "Joe")
                {
                    listOfAverageJoes.Add(listOfEmployees[i]);

                }


            }

            Console.ReadLine();


            Console.WriteLine("Employee List of Average Joes");

            for (var i = 0; i < listOfAverageJoes.Count; i++)
            {
                
                Console.WriteLine("Employee Name: " + listOfAverageJoes[i].FirstName + " " + listOfAverageJoes[i].LastName +
                      "   Id: " + listOfAverageJoes[i].Id + "\n");
            }
            Console.ReadLine();

            List<Employee> listOfLambdaAverageJoes = new List<Employee>();
            Console.WriteLine("List of Average Joes");
            listOfLambdaAverageJoes = listOfEmployees.FindAll(e => (e.FirstName == "Joe")).ToList<Employee>();
            for(var i = 0; i<listOfLambdaAverageJoes.Count; i++)
            {
                Console.WriteLine("Employee Name: " + listOfLambdaAverageJoes[i].FirstName + " " + listOfLambdaAverageJoes[i].Id + "\n");

            }

                Console.ReadLine();
            }
        }
            //foreach (Employee[i] in listOfEmployees)
            //{
            //    Console.WriteLine(item);
            //    PrintListDetails(listOfEmployees.item);
            //}
            //Console.WriteLine("\n" + listOfAverageJoes.Count);
            //;
            //Console.ReadLine();


                //void PrintListDetails(List<Employee> item)
                //{
                //    foreach (var field in typeof(Employee).GetType().GetFields())
                //    {
                //        Console.WriteLine(field.ToString());
                //        Console.WriteLine(field.Name + ": " + field.GetValue(listOfEmployees));
                //    }
                //}
        }
    
