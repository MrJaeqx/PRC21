using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnimalShelter
{
    public partial class AdminForm : Form
    {

        private Administration admin = new Administration();

        public AdminForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            updateList();
        }

        private void updateList()
        {
            List<Animal> reservedAnimals = admin.ReservedAnimals;
            reservedAnimals.Sort();
            List<Animal> notReservedAnimals = admin.NotReservedAnimals;
            notReservedAnimals.Sort();

            listView1.Items.Clear();
            listView1.Groups.Clear();

            ListViewGroup lvgReserved = new ListViewGroup("Gereserveerde dieren");
            ListViewGroup lvgNotReserved = new ListViewGroup("Niet gereserveerde dieren");

            listView1.Groups.Add(lvgReserved);
            foreach (Animal animal in reservedAnimals)
            {
                ListViewItem item = new ListViewItem(animal.ToString(), lvgReserved);
                listView1.Items.Add(item);
            }

            listView1.Groups.Add(lvgNotReserved);
            foreach (Animal animal in notReservedAnimals)
            {
                ListViewItem item = new ListViewItem(animal.ToString(), lvgNotReserved);
                listView1.Items.Add(item);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Kat")
            {
                textBoxWDDay.Enabled = false;
                textBoxWDDay.Text = "";
                textBoxWDMonth.Enabled = false;
                textBoxWDMonth.Text = "";
                textBoxWDYear.Enabled = false;
                textBoxWDYear.Text = "";

                textBoxBadHabits.Enabled = true;
            }
            else
            {
                textBoxWDDay.Enabled = true;
                textBoxWDMonth.Enabled = true;
                textBoxWDYear.Enabled = true;

                textBoxBadHabits.Enabled = false;
                textBoxBadHabits.Text = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxChipNr.Text = "";
            textBoxName.Text = "";
            textBoxBDDay.Text = "";
            textBoxBDMonth.Text = "";
            textBoxBDYear.Text = "";
            textBoxWDDay.Text = "";
            textBoxWDMonth.Text = "";
            textBoxWDYear.Text = "";
            textBoxBadHabits.Text = "";
            checkBoxReserved.Checked = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string chipNr = textBoxChipNr.Text;
            string name = textBoxName.Text;
            bool reserved = checkBoxReserved.Checked;
            SimpleDate birthDay = null;

            try
            {
                birthDay = new SimpleDate(Convert.ToInt32(textBoxBDDay.Text), Convert.ToInt32(textBoxBDMonth.Text), Convert.ToInt32(textBoxBDYear.Text));
            }
            catch (InvalidCastException exc)
            {
                MessageBox.Show(exc.Message, "Fout bij het toevegen van dier");
                return;
            }
            catch (ArgumentOutOfRangeException exc1)
            {
                MessageBox.Show(exc1.Message, "Fout bij het toevegen van dier");
                return;
            }
            catch (FormatException exc2)
            {
                MessageBox.Show(exc2.Message, "Fout bij het toevoegen van dier");
                return;
            }

            if (comboBoxType.Text == "Kat")
            {
                if (!admin.Add(new Cat(chipNr, birthDay, name, textBoxBadHabits.Text, reserved)))
                {
                    MessageBox.Show("Dier bestaat al.", "Fout bij het toevegen van dier");
                    return;
                }
            }
            else if (comboBoxType.Text == "Hond")
            {
                SimpleDate lastWalkDate = null;
                try
                {
                    lastWalkDate = new SimpleDate(Convert.ToInt32(textBoxWDDay.Text), Convert.ToInt32(textBoxWDMonth.Text), Convert.ToInt32(textBoxWDYear.Text));
                    
                } catch (InvalidCastException exc) {
                    MessageBox.Show("Geen geldige uitlaat datum.", "Fout bij het toevoegen van dier");
                    return;
                }
                catch (ArgumentOutOfRangeException exc1)
                {
                    MessageBox.Show(exc1.Message, "Fout bij het toevegen van dier");
                    return;
                }
                catch (FormatException exc2)
                {
                    MessageBox.Show(exc2.Message, "Fout bij het toevoegen van dier");
                    return;
                }

                if (!admin.Add(new Dog(chipNr, birthDay, name, lastWalkDate, reserved))) {
                    MessageBox.Show("Fout bij het toevegen van dier", "Dier bestaat al.");
                    return;
                }
            }

            updateList();
            buttonClear_Click(null, null);
        }

        private string getChipNrSelectedItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string[] animalStringSplit = listView1.SelectedItems[0].Text.Split(' ');
                return animalStringSplit[1].Substring(0, animalStringSplit[1].Length - 1);
            }
            else
            {
                return null;
            }
        }

        private void gereserveerdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                List<Animal> animals = admin.AllAnimals;
                string chipNr = getChipNrSelectedItem();
                foreach (Animal animal in animals)
                {
                    if (animal.ChipRegistrationNumber == chipNr)
                    {
                        animal.IsReserved = !animal.IsReserved;
                    }
                }
            }
            updateList();
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (!admin.RemoveAnimal(getChipNrSelectedItem()))
                {
                    MessageBox.Show("Oeps", "Fout bij het verwijderen van dier");
                }
            }
            updateList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            admin.Save(@"C:\Users\Lars\Desktop\MyFile.bin");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            admin.Load(@"C:\Users\Lars\Desktop\MyFile.bin");
            updateList();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            admin.Export(@"C:\Users\Lars\Desktop\MyFile.txt");
        }

    }
}
