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
        public List<double> StabieleWaardenTolerantie(int afronding, int projectie)
        {
            var stabieleWaardes = new List<double>();
            int transcientWaarde = -1;

            for (int i = 1; i < projectie; i++)
            {
                //check voor elk element of dat de delta kleiner is dan 10^-5
                if (IsGelijkAan(i, i+projectie))
                {
                    transcientWaarde = i;
                    break;
                }
            }

            int nakijker = projectie;
            while (IsGelijkAan(transcientWaarde, transcientWaarde + nakijker))
            {
                nakijker /= 2;
            }
            for(int i = 1; i < nakijker; i++)
            {
                transcientWaarde++;
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
                if (fn > 1 || fn < 0)
                {
                    throw new ValueOutOfRangeException();
                }
                Populaties.Add(fn);
                mainForm.chart1.Series[0].Points.AddXY(i, fn); // Voeg volgend punt toe
            }
        }

        public bool IsGelijkAan(int index1, int index2)
        {
            return -1e-5 <= (Populaties[index1] - Populaties[index2]) && (Populaties[index1] - Populaties[index2]) <= 1e-5;
        }
    }





    public class ValueOutOfRangeException : Exception
    {
    }

}
