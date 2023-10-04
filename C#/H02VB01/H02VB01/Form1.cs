namespace H02VB01
{
    public partial class labPrijs : Form
    {
        public labPrijs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((TextBox)txtPrijs).Clear();
            ((TextBox)txtAantal).Clear();
            ((TextBox)txtTeBetalen).Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butBerekenen_Click(object sender, EventArgs e)
        {
            //Berken te betalen bedrag

            //Declaratie variabelen
            decimal prijs, teBetalen;
            int aantal;

            //prijs inlezen en omzetten naar Int
            prijs = Convert.ToDecimal(txtPrijs.Text.Replace(".", ","));

            //Aantal inlezen en omzetten naar Int
            aantal = Convert.ToInt32(txtAantal.Text);

            //Totaalbedrag berekenen
            teBetalen = prijs * aantal;

            //Totaalbedrag in tekstvak zetten
            txtTeBetalen.Text = teBetalen.ToString();
        }

        private void butSluiten_Click(object sender, EventArgs e)
        {
            
        }
    }
}