namespace RaadSpelletje
{
    public partial class Form1 : Form
    {

        int willekeurig;

        public Form1()
        {
            InitializeComponent();
        }

        int gok;

        private void buttonNieuwSpel_Click(object sender, EventArgs e)
        {
            Random getalGenerator = new Random();
            willekeurig = getalGenerator.Next(1, 101);

            textBoxGetal.Text = "";
            labelBoodschap.Text = "";
        }

        private void buttonEvalueren_Click(object sender, EventArgs e)
        {

            if (textBoxGetal.Text != "")
            {
                gok = Convert.ToInt32(textBoxGetal.Text);

                if (gok == willekeurig)
                {
                    labelBoodschap.Text = "Proficiat je hebt het juist";
                }
                else if (gok >= willekeurig)
                {
                    labelBoodschap.Text = "probeer en kleiner getal";
                }
                else if (gok <= willekeurig)
                {
                    labelBoodschap.Text = "Probeer een groter getal";
                }
                textBoxGetal.Focus();
            }
            else
            {
                gok = 0;
            }
        }

        private void buttonEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}