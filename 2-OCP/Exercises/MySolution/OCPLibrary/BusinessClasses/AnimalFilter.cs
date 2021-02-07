using System.Collections.Generic;
using System.Linq;

namespace OCPLibrary.BusinessClasses
{
    public class AnimalFilter 
    { 
        public List<IAnimal> FilterByClass(IEnumerable<IAnimal> animals, AnimalClass animalClass)
        {
            return animals.Where(o => o.Class.Equals(animalClass)).ToList(); 
        }        
    }
}
