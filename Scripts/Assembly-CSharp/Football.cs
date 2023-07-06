using UnityEngine;

public class Football : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D body;
	[SerializeField]
	private Transform spawnPosition;
	public CollisionNoise collisionNoise;
	public bool explodeOnIdle;
}
