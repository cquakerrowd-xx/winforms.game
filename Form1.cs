namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            Help_Zcreen helpWindow = new Help_Zcreen();
            helpWindow.Show();
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
