using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week1
{
    public partial class StudentForm : Form
    {

        private List<Student> studenten;
        private List<Resultaat> resultaten;
        private List<Vak> vakken;

        private int currentStudentNr = -1;

        public StudentForm()
        {
            InitializeComponent();

            studenten = new List<Student>();
            resultaten = new List<Resultaat>();
            vakken = new List<Vak>();

            vakken.Add(new Vak("SE12", "Softweer", 42));
            vakken.Add(new Vak("DB12", "Databees", 1337));
            vakken.Add(new Vak("EE21", "Electro", 9999));
        }

        private void updateList()
        {
            listView1.Items.Clear();
            foreach (Student s in studenten)
            {
                ListViewItem item = new ListViewItem(new[] {s.getNrAsString(), s.getNaam(), s.getAdres(), s.getDateAsString()});
                listView1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studenten.Add(new Student(textBox1.Text, textBox3.Text, dateTimePicker1.Value));
            updateList();
        }

        private void updateResultatenDingetje()
        {

            ListViewItem item = null;
            if (listView1.SelectedItems.Count > 0)
            {
                item = listView1.SelectedItems[0];

                textBox4.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;

                currentStudentNr = Convert.ToInt32(item.SubItems[0].Text);

                listView2.Items.Clear();

                int hoogste = 0;
                int SBU = 0;

                foreach (Resultaat r in resultaten)
                {
                    if (r.getStudNr() == currentStudentNr)
                    {
                        string gehaald = "Nee";
                        if (r.getCijfer() > 5) gehaald = "Ja";
                        ListViewItem item2 = new ListViewItem(new[] { r.getVak().getVakCode(), r.getCijfer().ToString(), gehaald });
                        listView2.Items.Add(item2);
                        if(r.getCijfer() > hoogste) hoogste = r.getCijfer();
                        if(r.getCijfer() > 5) SBU += r.getVak().getSBU();
                    }
                }

                label9.Text = hoogste.ToString();
                label10.Text = SBU.ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateResultatenDingetje();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentStudentNr != -1)
            {
                Vak vak = vakken.Find(x => x.getVakCode().Equals(textBox5.Text));
                resultaten.Add(new Resultaat(currentStudentNr, vak, (int)numericUpDown1.Value));
            }
            updateResultatenDingetje();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            if (listView1.SelectedItems.Count > 0)
            {
                item = listView1.SelectedItems[0];
                string studnr = item.SubItems[0].Text;

                Student s = studenten.Find(x => x.getNrAsString().Equals(studnr));
                s.setAdres(textBox2.Text);
                s.setNaam(textBox4.Text);
            }
            updateList();
            updateResultatenDingetje();
        }
    }
}
