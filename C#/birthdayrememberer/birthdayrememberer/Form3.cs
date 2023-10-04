using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace birthdayrememberer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void buttonOpslaan_Click(object sender, EventArgs e)
        {
            string dateString = textBoxVerjaardagDatum.Text;
            DateTime date;
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                if (!File.Exists("verjaardagen.txt")) // If file does not exists
                {
                    File.Create("verjaardagen.txt").Close(); // Create file
                    using (StreamWriter sw = File.AppendText("verjaardagen.txt"))
                    {
                        sw.WriteLine(dateString); // Write text to .txt file
                    }
                }
                else // If file already exists
                {
                    using (StreamWriter sw = File.AppendText("verjaardagen.txt"))
                    {
                        sw.WriteLine(dateString); // Write text to .txt file
                    }
                }
            }
        }
    }
}
