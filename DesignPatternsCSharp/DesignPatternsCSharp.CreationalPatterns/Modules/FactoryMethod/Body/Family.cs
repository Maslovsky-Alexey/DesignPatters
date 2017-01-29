using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.CreationalPatterns.Modules.FactoryMethod.Body.Models;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.FactoryMethod.Body
{
    public class Family
    {
        private int nextNumber = 0;
        public int CountMembersFamily { get; private set; }

        public Family(int countMembers)
        {
            nextNumber = countMembers;
            CountMembersFamily = countMembers;
        }

        public void KillOneMember()
        {
            CountMembersFamily--;
        }

        public virtual Child CreateChild()
        {
            CountMembersFamily++;
            nextNumber++;
            return new Child($"Child №{nextNumber}");
        }
    }
}
