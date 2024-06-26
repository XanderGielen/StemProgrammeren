﻿using ChaosbunnySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popu
{
    
    internal class Bifercatie
    {
        private Form2 mainForm;
        public Bifercatie(Form2 formulier)
        {
            mainForm = formulier; // Maak constructor dat er voor zorgt dat we het formulier kunnen gebruiken
        }

        public List<double> Populaties { get; set; } = new List<double>();// Hier slaan we alle populaties op

        public List<double> StabieleWaardenTolerantie(int afronding, int projectie)
        {
            var stabieleWaardes = new List<double>();
            int transcientWaarde = -1;
            int populatieLengte = Populaties.Count;

            for (int i = 1; i < projectie; i++)
            {
                //check voor elk element of dat de delta kleiner is dan 10^-5
                if (IsGelijkAan(i, i + projectie))
                {
                    transcientWaarde = i;
                    break;
                }
            }

            if (transcientWaarde < 0) return stabieleWaardes;

            int nakijker = projectie;
            while (IsGelijkAan(populatieLengte - 1, populatieLengte - 1 - nakijker) && nakijker > 0)
            {
                nakijker /= 2;
            }
            if (nakijker == 0) nakijker = 1;
            else nakijker *= 2;

            for (int i = populatieLengte - nakijker; i < populatieLengte; i++)
            {
                stabieleWaardes.Add(Populaties[i]);
                //transcientWaarde++;
            }


            return stabieleWaardes;
        }

        public void Update(int N, double k)
        {
            double fn = 0.5; // Start-populatie

            for (int i = 0; i < N; i++)
            {
                fn = k * fn * (1 - fn); // Bereken volgende populatie
                if (fn > 1 || fn < 0)
                {
                    throw new ValueOutOfRangeException();
                }
                Populaties.Add(fn);
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

