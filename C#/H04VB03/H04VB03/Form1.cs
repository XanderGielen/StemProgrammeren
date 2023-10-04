namespace H04VB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerekenen_Click(object sender, EventArgs e)
        {
            int jaar;
            double renteperc, beginkapitaal, eindkapitaal;

            textBoxKapitaal.Text = "";
            beginkapitaal = Convert.ToDouble(textBoxBeginkapitaal.Text);
            renteperc = Convert.ToDouble(textBoxRentepercentage.Text);
            eindkapitaal = beginkapitaal;
            jaar = 0;

            while (eindkapitaal <= (2 * beginkapitaal))
            {
                jaar++;
                eindkapitaal *= (1 + renteperc / 100);
                eindkapitaal = Math.Round(eindkapitaal, 2);

                textBoxKapitaal.Text += jaar.ToString() + " - " + eindkapitaal.ToString() + "\r\n";
            }
        }
    }
}