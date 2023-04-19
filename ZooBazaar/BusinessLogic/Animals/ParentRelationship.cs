using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ParentRelationship:Relationship
    {
        public ParentRelationship( Animal animal1, Animal animal2)
            : base(animal1,animal2)
        {
        
        }
    }
}
