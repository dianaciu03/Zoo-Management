using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ParentRelationship : Relationship
    {
        public ParentRelationship( Animal animalParent, Animal animalChild)
            : base(animalParent, animalChild)
        {
        
        }
    }
}
