using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {

        private Administration administration = new Administration();

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            updateLists();
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (animalTypeComboBox.Text == "Dog")
            {
                SimpleDate birth = new SimpleDate(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                SimpleDate walk = new SimpleDate(0,0,0);
                if(textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != ""){
                    walk = new SimpleDate(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox6.Text));
                }
                administration.Add(new Dog(textBox1.Text, birth, textBox2.Text, walk, checkBox1.Checked));
            }

            if (animalTypeComboBox.Text == "Cat")
            {
                SimpleDate birth = new SimpleDate(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                administration.Add(new Cat(textBox1.Text, birth, textBox2.Text, textBox11.Text, checkBox1.Checked));
            }
            updateLists();
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            //label9.Text = animal.ToString();
            updateLists();
        }

        private void updateLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            List<Animal> animals = administration.GetAnimals();
            List<Animal> reservedAnimals = new List<Animal>();
            List<Animal> notReservedAnimals = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (animal.IsReserved)
                {
                    reservedAnimals.Add(animal);
                }
                else
                {
                    notReservedAnimals.Add(animal);
                }
            }

            foreach (Animal animal in reservedAnimals)
            {
                listBox1.Items.Add(animal.ToString());
            }

            foreach (Animal animal in notReservedAnimals)
            {
                listBox2.Items.Add(animal.ToString());
            }
        }
    }
}
