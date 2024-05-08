using popu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChaosbunnySimulation
{
    class KonijnModel
    {

        private Form1 mainForm;
        public KonijnModel(Form1 formulier)
        {
            mainForm = formulier; // Maak constructor dat er voor zorgt dat we het formulier kunnen gebruiken
        }
        public List<double> Populaties { get; set; } = new List<double>();// Hier slaan we alle populaties op
        
        public List<double> StabieleWaardenTolerantie(int afronding)
        {
            var stabieleWaardes = new List<double>();

            for (int i = 1; i < Populaties.Count; i++)
            {
                for (int j = i + 1; j < Populaties.Count; j++)
                {
                    //check voor elk element of dat de delta kleiner is dan 10^-5
                    if ((Populaties[i] - Populaties[j]) <= 1e-5)
                    {
                        stabieleWaardes.Add(Math.Round(Populaties[i], afronding));
                        break;
                    }
                }
            }
            return stabieleWaardes.Distinct().ToList();
        }
        
        public void Update(int N, double k)
        {
            mainForm.chart1.Series[0].Points.Clear();
            double fn = 0.5; // Start-populatie
            for (int i = 0; i < N; i++)
            {
                fn = k * fn * (1 - fn); // Bereken volgende populatie
                Populaties.Add(fn);
                mainForm.chart1.Series[0].Points.AddXY(i, fn); // Voeg volgend punt toe
            }
        }

       

    }
}
