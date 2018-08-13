namespace Engine
{
	public class Character
	{
		public int CurrentHitPoints { get; set; }
		public int MaximumHitPoints { get; set; }

		public Character(int currentHitPoints, int maximumHitPoints)
		{
			CurrentHitPoints = currentHitPoints;
			MaximumHitPoints = maximumHitPoints;
		}		
	}
}
