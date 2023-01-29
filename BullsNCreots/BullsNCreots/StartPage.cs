namespace BullsNCreots
{
    public partial class StartPageFrm : Form
    {
        public StartPageFrm()
        {
            InitializeComponent();
        }
        GameplayFrm game = new GameplayFrm();
        private void StartBtn_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
            StartPageFrm start = new StartPageFrm();
            
        }
    }
}