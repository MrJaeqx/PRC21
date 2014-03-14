using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {

        private List<Animal> animals;
        
        public Administration()
        {
            animals = new List<Animal>();

            this.Add(new Cat((12341).ToString(), new SimpleDate(10, 8, 2018), "Pinky", "diek", true));
            this.Add(new Cat((12342).ToString(), new SimpleDate(11, 8, 2018), "Mousie", "massive", true));
            this.Add(new Cat((12343).ToString(), new SimpleDate(12, 8, 2018), "Tijger", "lui", false));
            this.Add(new Dog((12321).ToString(), new SimpleDate(1, 1, 1651), "Munnie", new SimpleDate(5, 8, 1483), false));
            this.Add(new Dog((12321).ToString(), new SimpleDate(1, 1, 1651), "Doge", new SimpleDate(5, 8, 2333), false));
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
