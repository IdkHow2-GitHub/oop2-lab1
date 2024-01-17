using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempLab1
{
    internal class Relations
    {
        public string relationship_type;

        public Relations(string relationship_type)
        {
            this.relationship_type = relationship_type;
        }
        public string showRelationship(Person person1, Person person2, string relationship_type)
        {
            return $"Relationship between {person1.fname} and {person2.fname} is: {relationship_type}hood";
        }
    }
}
