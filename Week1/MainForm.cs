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
    public partial class MainForm : Form
    {
        private List<int> cijfers = new List<int>();
        private ListTools listTools = new ListTools();

        public MainForm()
        {
            InitializeComponent();
            updateList();
        }

        private void updateList()
        {
            //Update list
            listViewCijfers.Items.Clear();
            foreach (int cijfer in cijfers)
            {
                listViewCijfers.Items.Add(new ListViewItem(new[] { cijfer.ToString() }));
            }

            //Update aantal
            labelAantal.Text = cijfers.Count.ToString();

            //Update gemiddelde
            try
            {
                labelGemiddelde.Text = cijfers.Average().ToString();
            }
            catch (InvalidOperationException exc) {
                //Indien er nog geen cijfers zijn: 0
                labelGemiddelde.Text = "0";
            }

            //Update maximum
            labelMax.Text = listTools.GetMax(cijfers).ToString();

            //Update minimum
            labelMin.Text = listTools.GetMin(cijfers).ToString();

            //Update tel
            int tel = Convert.ToInt32(numericUpDownTel.Value);
            int aantal = 0;
            foreach (int cijfer in cijfers)
            {
                if (cijfer == tel) aantal++;
            }
            labelTel.Text = aantal.ToString();
        }

        private void buttonAddCijfer_Click(object sender, EventArgs e)
        {
            cijfers.Add(Convert.ToInt32(numericUpDownCijfer.Value));
            updateList();
        }

        private void numericUpDownTel_ValueChanged(object sender, EventArgs e)
        {
            updateList();
        }

    }
}
