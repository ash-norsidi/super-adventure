namespace Engine
{
	public class Player : Character
	{
		public int Gold { get; set; }
		public int ExperiencePoints { get; set; }
		public int Level { get; set; }

		public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoionts, int level): base(currentHitPoints, maximumHitPoints)
		{
			Gold = gold;
			ExperiencePoints = experiencePoionts;
			Level = level;
		}
	}
}
