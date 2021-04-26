using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class FamilyCar : TransportEntity
    //МАШИНА СЕМЬЯНИНА
    {
        public string[] FamilyMembers { get; }
        //РАССТРЕЛЬНЫЙ СПИСОК
        public FamilyCar(double engineDisplacement, string transmission, double maxSpeed, string[]familyMembers)
            : base(engineDisplacement, transmission, maxSpeed)
        {
            FamilyMembers = familyMembers;
        }
        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            #region Family members information
            for (int i = 0; i < FamilyMembers.Length; i++)
            {
                fullInfo.Append( "Family member №");
                fullInfo.Append((i+1).ToString());
                fullInfo.Append(": ");
                fullInfo.Append(FamilyMembers[i]);
                fullInfo.Append(".\n");
            }
            #endregion
            return fullInfo.ToString();
        }
    }
}
