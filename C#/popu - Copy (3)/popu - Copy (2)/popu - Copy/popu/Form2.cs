using ChaosbunnySimulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace popu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eindK = 4;
            int M = 128; //projectie
            int N = M * 2; // Aantal jaren om te simuleren

            // Maak bifercatie object
            Bifercatie model = new Bifercatie(this);

            for(double k = 0; k <= eindK; k += 0.1)
            {
                // Simuleer k waardes
                model.Update(N, k); // Berekent de volgende k waarde

                foreach (double stabielewaarde in model.StabieleWaardenTolerantie(3, M))
                {
                    //Debug.WriteLine(k);
                    
                    chart1.Series[0].Points.AddXY(k, stabielewaarde);
                }
            }
        }

    }
}
