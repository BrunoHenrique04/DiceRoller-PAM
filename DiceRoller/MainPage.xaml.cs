namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollClicked(object sender, EventArgs e)
        {
            if ( dropbox.SelectedIndex == -1)
            {
                labelDiceValue.Text = "SELECIONE UMA QUANTIDADE DE LADOS.";
                return;
            }
            string dropboxText = dropbox.SelectedItem.ToString();

            int dropboxValue = int.Parse(dropboxText);
            Random rnd = new Random();
            int diceResult = rnd.Next(dropboxValue);


           labelDiceValue.Text = diceResult.ToString();
        }

    }

}
