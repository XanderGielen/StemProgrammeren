using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenVraag
{
    internal class Student
    {
        public int Id { get; }
        public string Naam { get; }
        public double Score { get; }

        public Student(int id, string naam, double score)
        {
            Id = id;
            Naam = naam;
            Score = score;
        }

        public Student(string id, string naam, string score)
        {
            Id = Convert.ToInt32(id);
            Naam = naam;
            Score = Convert.ToDouble(score);
        }
    }
}
