using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteersManagement
{
    /// <summary>
    /// All families details
    /// </summary>
    public class Family
    {
        #region properties
        public int FamilyID { get; set; }//this should be automatically asigned
        public string FamilyName { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string Child1 { get; set; }
        public string Child2 { get; set; }

        #endregion


    }
}
