using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    class Administration
    {

        private List<Animal> animals = new List<Animal>();
        
        public Administration()
        {
            
        }

        public bool Add(Animal animal)
        {
            if (animals.Exists(x => x.ChipRegistrationNumber == animal.ChipRegistrationNumber))
            {
                return false;
            }
            else
            {
                animals.Add(animal);
                return true;
            }
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            try
            {
                animals.Remove(animals.Find(x => x.ChipRegistrationNumber == chipRegistrationNumber));
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            return animals.Find(x => x.ChipRegistrationNumber == chipRegistrationNumber);
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
