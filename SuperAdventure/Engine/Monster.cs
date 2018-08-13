namespace Engine
{
	public class Monster : Character
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int MaximumDamage { get; set; }
		public int RewardExperiencePoints { get; set; }
		public int RewardGold { get; set; }

		public Monster(int id, int currentHitPoints, int maximumHitPoints, string name, int maxDamage, int rewardExpPoints, int rewardGold) : base (currentHitPoints, maximumHitPoints)
		{
			Id = id;
			Name = name;
			MaximumDamage = maxDamage;
			RewardExperiencePoints = rewardExpPoints;
			RewardGold = rewardGold;
		}
	}
}
