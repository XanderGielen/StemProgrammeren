namespace H03VB03
{
    public partial class FormKassa : Form
    {
        public FormKassa()
        {
            InitializeComponent();
        }


        const int btwPerc = 21;
        string aard;
        decimal eenheidsPrijs;
        int aantal;
        decimal totaal;
        decimal korting;
        decimal teBetalenIncl;
        decimal btwBedrag;
        decimal teBetalenExcl;
        decimal kortingsPercentage;




        private void ButtonBerekenen_Click(object sender, EventArgs e)
        {

            if (radioButtonWinkelier.Checked)
            {
                kortingsPercentage = 15;
            }
            else if (radioButtonParticulier.Checked)
            {
                kortingsPercentage = 0;
            }

            eenheidsPrijs = Convert.ToDecimal(textBoxEenheidsprijs.Text);
            aantal = Convert.ToInt32(textBoxAantal.Text);


            totaal = eenheidsPrijs * aantal;
            korting = totaal * kortingsPercentage / 100;
            teBetalenIncl = totaal - korting;
            btwBedrag = teBetalenIncl * btwPerc / (100 + btwPerc);
            teBetalenExcl = teBetalenIncl - btwBedrag;

            // Display the results in textboxes
            textBoxTotaal.Text = totaal.ToString();
            textBoxKortingspercentage.Text = kortingsPercentage.ToString();
            textBoxKorting.Text = korting.ToString();
            textBoxTeBetalenIncl.Text = teBetalenIncl.ToString();
            textBoxTeBetalenExcl.Text = teBetalenExcl.ToString();
            textBoxBTWBedrag.Text = btwBedrag.ToString();
        }

        private void buttonSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}