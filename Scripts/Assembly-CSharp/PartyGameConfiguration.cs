public class PartyGameConfiguration
{
	public enum PartyGames
	{
		Football = 0,
		FootballPortals = 1,
		Volleyball = 2,
		Sumo = 3,
		Highway = 4,
		Pirate = 5,
		Skipping = 6,
		SlamBall = 7,
		Crusher = 8,
		Hurdles = 9,
		KingOfTheHill = 10,
		Exit = 11,
	}

	public PartyGames[] PartySelectionPool;
	public PartyGames gameToLoad;
	public bool farmageddon;
	public int numberOfGames;
}
