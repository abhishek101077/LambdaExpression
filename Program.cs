using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace LamdaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<person> listpersonincity = new List<person>();
            AddRecords(listpersonincity);
            // RetriveTwoRecordsislessthensixty(listpersonincity);
            // RetriveTwoRecordsislessthenthirteen(listpersonincity);
            // AvaraageAge(listpersonincity);
            // specific_Name(listpersonincity);
            RetriveTwoRecordsisgreaterthensixty(listpersonincity);

        }
        private static void AddRecords(List<person> listpersonincity)
        {
            listpersonincity.Add(new person("874562184", "john", "12thmainstreet", 65));
            listpersonincity.Add(new person("874562174", "smith", "12thmainstreet", 25));
            listpersonincity.Add(new person("874563194", "Rafael", "12thmainstreet", 35));
            listpersonincity.Add(new person("874567194", "gavi", "12thmainstreet", 45));
            listpersonincity.Add(new person("874569194", "pedri", "12thmainstreet", 55));
            listpersonincity.Add(new person("874562194", "varane", "12thmainstreet", 17));
            listpersonincity.Add(new person("874563194", "Dybala", "12thmainstreet", 85));
            listpersonincity.Add(new person("874563194", "Roger", "12thmainstreet", 75));
        }
        private static void RetriveTwoRecordsislessthensixty(List<person> listperson)
        {
            foreach (person person in listperson.FindAll(a => (a.Age < 60)).Take(4))

            {
                Console.WriteLine(person.Name + " " + person.Age);

            }


        }
        private static void RetriveTwoRecordsislessthenthirteen(List<person> listperson)
        {
            foreach (person person in listperson.FindAll(a => (a.Age < 18 && a.Age > 13)).Take(4))

            {
                Console.WriteLine(person.Name + " " + person.Age);

            }
        }
        private static void AvaraageAge(List<person> listperson)
        {
            double avgage = listperson.Average(a => a.Age);
            Console.WriteLine("The Avarage Age" + avgage);
        }
        private static void specific_Name(List<person> listperson)
        {
            bool val = listperson.Exists(e => e.Name == "Abhishek");
            if (val)
            {
                Console.WriteLine("Name exists");
            }
            else
            {
                Console.WriteLine("Name does not exist");
            }
        }

        private static void RetriveTwoRecordsisgreaterthensixty(List<person> listperson)
        {
            foreach (person person in listperson.FindAll(a => (a.Age > 60)))

            {
                Console.WriteLine(person.Name + " " + person.Age);

            }
        }
    }
}

              
             
                
             



        
    



          