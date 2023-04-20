using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Relationship
    {
        Animal animal1;
        Animal animal2;

        protected Relationship(Animal animal1, Animal animal2)
        {
            this.animal1 = animal1;
            this.animal2 = animal2;
        }

        public Animal Animal1
        {
            get { return animal1; }
        }
        public Animal Animal2 
        { 
            get { return animal2; } 
        }

    }
}
