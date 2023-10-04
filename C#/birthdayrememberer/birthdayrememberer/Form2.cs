using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birthdayrememberer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("verjaardagen.txt");
            List<DateTime> dates = new List<DateTime>();
            foreach (string line in lines)
            {
                DateTime date;
                if (DateTime.TryParseExact(line, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    dates.Add(date);
                }
            }
            dates = dates.OrderBy(d => d).ToList(); // Sort dates in ascending order
            using (StreamWriter sw = new StreamWriter("verjaardagen.txt"))
            {
                foreach (DateTime date in dates)
                {
                    sw.WriteLine(date.ToString("dd/MM/yyyy"));
                }
            }
            labelVerjaardagen.Text = string.Join(Environment.NewLine, lines);
        }
    }
}
