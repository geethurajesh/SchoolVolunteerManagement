using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteersManagement
{/// <summary>
/// 
/// </summary>
    static public class School
    {
        #region
        public static string SchoolName { get; set; }

        public static string SchoolAddress { get; set; }

        public static string TeachersFName { get; set; }

        public static int TeachersLName { get; set; }
        //public string Kids { get; set; }

        public static List<Family> Famlies { get; set; }
        //creting a list to enter all the details of each families
        #endregion
        #region Constructor
        static School()
        {
            Famlies = new List<Family>(); 
            // Internally creating a constructor
        }
        #endregion
        #region Methods
        /// <summary>
        /// adding each family to the family list with this method
        /// </summary>
        /// <param name="family"></param>
        public static void AddFamily(Family family)
        {
            
            Famlies.Add(family);

        }
        /// <summary>
        /// Print the family details 
        /// </summary>
        public static void DisplayFamily()
        {
            foreach (var family in Famlies)
            {
                Console.WriteLine("FamilyName: {0}\n,MothersName: {1}\n,FathersName: {2}\n,Child1 :{3}\n,Child2: {4}\n\n", family.FamilyName, family.MothersName, family.FathersName, family.Child1, family.Child2);
        
            }
        }
        #endregion
    }
}
