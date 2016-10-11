using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteersManagement

{
    public class Program
    {
        public void Main(string[] args)
        {
            var family = new Family();
            family.FamilyID = 1001;

            //for (int i=0;i<)
            Console.Write("\n Enter Family Name: ");
            family.FamilyName = Console.ReadLine();

            Console.Write(" Enter Mother's Name: ");
            family.MothersName = Console.ReadLine();

            Console.Write(" Enter Father's Name: ");
            family.FathersName = Console.ReadLine();

            Console.Write(" Enter Child's Name: ");
            family.Child1 = Console.ReadLine();

            Console.Write(" Do want to add another Child?(Y/N) ");

            char c = Console.ReadKey().KeyChar;
            if (c == 'Y' || c == 'y')
            {
                Console.Write("\n Enter Child's Name: ");
                family.Child2 = Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Thank you ");
            }
            Console.WriteLine(" ");

            //family.Child2 = Console.ReadLine();
            //family.FamilyName = "Diamonds";
            //family.MothersName = "Ann";
            //family.FathersName = "Josh";
            //family.Child1 = "Jack";
            ////class
            ////grade
            //family.Child2 = "Jill";
            ////child
            ////grade
            School.AddFamily(family); //calling the method

            family = new Family();
            family.FamilyID = 12242;
            family.FamilyName = "Smith";
            family.MothersName = "Mary";
            family.FathersName = "Finn";
            family.Child1 = "Dian";
            //class
            //grade
            family.Child2 = "May";
            //child
            //grade
            School.AddFamily(family);
            School.DisplayFamily();
            //Console.ReadKey();
        }
    }
}
