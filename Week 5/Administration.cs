using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        /// <summary>
        /// Lijst van dieren die geregistreerd zijn.
        /// </summary>
        private List<Animal> animals;
        
        /// <summary>
        /// Maak een nieuw Administration object aan en voegt dummy data toe.
        /// </summary>
        public Administration()
        {
            animals = new List<Animal>();

            this.Add(new Cat((12341).ToString(), new SimpleDate(10, 8, 2018), "Pinky", "diek", true));
            this.Add(new Cat((12342).ToString(), new SimpleDate(11, 8, 2018), "Mousie", "massive", true));
            this.Add(new Cat((12343).ToString(), new SimpleDate(12, 8, 2018), "Tijger", "lui", false));
            this.Add(new Dog((12321).ToString(), new SimpleDate(1, 1, 1651), "Munnie", new SimpleDate(5, 8, 1483), false));
            this.Add(new Dog((12321).ToString(), new SimpleDate(1, 1, 1651), "Doge", new SimpleDate(5, 8, 2333), false));
        }

        /// <summary>
        /// Dier toevoegen aan de administratie.
        /// </summary>
        /// <param name="animal">Toe te voegen dier.</param>
        /// <returns>True indien het dier is toegevoegd.
        /// False indien het dier al bestaat.</returns>
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

        /// <summary>
        /// Dier verwijderen uit de administratie.
        /// </summary>
        /// <param name="chipRegistrationNumber">Chip nummer van het te verwijderen dier.</param>
        /// <returns>True indien het dier is verwijderd.
        /// False indien het dier niet is verwijderd.</returns>
        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            Animal animalToRemove = FindAnimal(chipRegistrationNumber);

            if (animalToRemove == null)
            {
                return false;
            }
            else
            {
                animals.Remove(animalToRemove);
                return true;
            }
        }

        /// <summary>
        /// Dier zoeken in de administratie.
        /// </summary>
        /// <param name="chipRegistrationNumber">Chip nummer van het te vinden dier.</param>
        /// <returns>Resultaat van het zoeken.</returns>
        public Animal FindAnimal(string chipRegistrationNumber)
        {
            Animal foundAnimal = null;
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    foundAnimal = animal;
                }
            }
            return foundAnimal;
        }

        /// <summary>
        /// Lijst met dieren ophalen.
        /// </summary>
        public List<Animal> AllAnimals
        {
            get
            {
                return animals;
            }
        }

        /// <summary>
        /// Lijst met gereserveerde dieren.
        /// </summary>
        public List<Animal> ReservedAnimals
        {
            get {
                List<Animal> reservedAnimals = new List<Animal>();
                foreach (Animal animal in animals)
                {
                    if (animal.IsReserved)
                    {
                        reservedAnimals.Add(animal);
                    }
                }
                return reservedAnimals;
            }
        }

        /// <summary>
        /// Lijst met niet gereserveerde dieren.
        /// </summary>
        public List<Animal> NotReservedAnimals
        {
            get
            {
                List<Animal> notReservedAnimals = new List<Animal>();
                foreach (Animal animal in animals)
                {
                    if (!animal.IsReserved)
                    {
                        notReservedAnimals.Add(animal);
                    }
                }
                return notReservedAnimals;
            }
        }

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            if (animals == null)
            {
                throw new ArgumentNullException("animals", "Anminals kan niet null zijn.");
            }
            if (fileName == null) {
                throw new ArgumentNullException("fileName", "Geef een geldig bestandspad op.");
            }
                
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, animals);
            stream.Close();
                
        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName", "Geef een geldig bestandspad op.");
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Animal> loadedAnimals = (List<Animal>)formatter.Deserialize(stream);
            stream.Close();

            animals = loadedAnimals;
        }

        /// <summary>
        /// Exports the info of all animals to a text file with the given file name.
        /// 
        /// Each line of the file contains the info about exactly one animal.
        /// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
        /// followed by the properties of the animal seperated by comma's.
        /// </summary>
        /// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
        {

        }

    }
}
