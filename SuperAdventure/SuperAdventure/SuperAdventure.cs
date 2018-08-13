using Engine;
using System.Windows.Forms;

namespace SuperAdventure
{
	public partial class SuperAdventure : Form
	{
		private Player _player;
		private Location _location;
		public SuperAdventure()
		{
			InitializeComponent();

			InitStuff();
			DisplayPlayerStats();
		}

		private void DisplayPlayerStats()
		{
			lblHitPoints.Text = _player.CurrentHitPoints.ToString();
			lblGold.Text = _player.Gold.ToString();
			lblExperience.Text = _player.ExperiencePoints.ToString();
			lblLevel.Text = _player.Level.ToString();
		}

		private void InitStuff()
		{
			_player = new Player(10, 10, 20, 0, 1);
			_location = new Location(1, "Home", "This is your house.");
		}
	}
}
