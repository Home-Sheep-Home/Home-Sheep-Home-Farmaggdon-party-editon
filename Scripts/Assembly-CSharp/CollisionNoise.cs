using UnityEngine;

public class CollisionNoise : MonoBehaviour
{
	[SerializeField]
	private bool sfxEnabled;
	[SerializeField]
	private int speedDivisor;
	[SerializeField]
	private float minSpeed;
	[SerializeField]
	private string contactNoise;
	[SerializeField]
	private bool ignoreSheep;
	[SerializeField]
	private bool ignorePortal;
	[SerializeField]
	private bool overlapSounds;
}
