public class Collectable : LevelObject
{
	public enum CollectableType
	{
		Sock = 0,
		Cake = 1,
		Bonus = 2,
		Secret = 3,
	}

	public CollectableType type;
	public string id;
}
