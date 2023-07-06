using UnityEngine;

public class Bucket : LevelObject
{
	public enum BucketState
	{
		welded = 0,
		broken = 1,
		sprung = 2,
		waitingfortimmy = 3,
	}

	public WellObject wellObject;
	public BucketState currentState;
	public GameObject attachedSprite;
	public GameObject detachedSprite;
}
