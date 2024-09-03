using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationSimulationProject
{
    internal class konijnModel
    {
        private List<double> Populaties { get; set; } = new List<double>();

        public void Update(int N, double k)
        {
            //start populatie
            double fn = 0.5;

            for(int i = 0; i < N; i++)
            {
                fn=k*fn*(1-fn);
            }
        }

        public List<double> StabieleWaarden()
        {
            return 0;
        }
    }
}
