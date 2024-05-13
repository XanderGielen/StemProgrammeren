using ChaosbunnySimulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();//maak de textbox leeg
            int N = 50; // Aantal jaren om te simuleren

            // Maak konijmodel object
            KonijnModel model = new KonijnModel(this);
            // Simuleer k waardes
            try
            {
                model.Update(N, Convert.ToDouble(textBox1.Text)); // Berekent de volgende k waarde
            }
            catch(ValueOutOfRangeException) { textBox2.Text = "Getal > 1 of < 0, getal is out of range"; }

            finally
            {
                foreach (double stabielewaarde in model.StabieleWaardenTolerantie(3))
                {
                    textBox2.Text += stabielewaarde.ToString() + "\r\n";//voeg elke stabielewaarde toe aan de textbox
                }
                if (textBox2.Text == "") { textBox2.Text = "geen stabiele waarden"; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Application.Exit(this);
            Application.Run(form);
            
        }
    }
}
