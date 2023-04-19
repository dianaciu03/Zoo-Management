using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class MateRelationship:Relationship
    {
        public MateRelationship(Animal animal1, Animal animal2)
            :base(animal1,animal2) 
        {

        }
    }
}
