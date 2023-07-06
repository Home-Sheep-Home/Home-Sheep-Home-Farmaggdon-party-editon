using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
	[SerializeField]
	private ObjectPool easyPlatforms;
	[SerializeField]
	private ObjectPool mediumPlatforms;
	[SerializeField]
	private ObjectPool hardPlatforms;
	[SerializeField]
	private float timeMedium;
	[SerializeField]
	private float mediumPlatformSpeedModifier;
	[SerializeField]
	private float timeHard;
	[SerializeField]
	private float hardPlatformSpeedModifier;
	[SerializeField]
	private Transform startingTransform;
	[SerializeField]
	private Platform startingPlatform;
	[SerializeField]
	private float platformSpacing;
	[SerializeField]
	private float platformSpeed;
	[SerializeField]
	private float numberOfSegments;
	public bool spawnFlag;
}
