using UnityEngine;

public class HurdleSpawner : MonoBehaviour
{
	[SerializeField]
	private ObjectPool easyHurdles;
	[SerializeField]
	private ObjectPool mediumHurdles;
	[SerializeField]
	private ObjectPool hardHurdles;
	[SerializeField]
	private float timeUntilFirstSpawn;
	[SerializeField]
	private float hurdleSpawnRate;
	[SerializeField]
	private float timeEasy;
	[SerializeField]
	private float timeMedium;
	[SerializeField]
	private float timeHard;
	[SerializeField]
	private Transform spawnTransform;
	public float speed;
	public GameObject HurdleDestroyedFX;
}
