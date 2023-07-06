using UnityEngine;

public class Cannon : MonoBehaviour
{
	[SerializeField]
	private bool mirrored;
	[SerializeField]
	private ObjectPool cannonballPool;
	[SerializeField]
	private Transform cannonballSpawn;
}
