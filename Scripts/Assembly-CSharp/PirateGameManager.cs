using UnityEngine;

public class PirateGameManager : PartyGame
{
	[SerializeField]
	private ObjectPool barrelPool;
	[SerializeField]
	private PirateFailureBoundary failureBoundary;
	[SerializeField]
	private float gameOverTime;
	[SerializeField]
	private float barrelSpawnRate;
	[SerializeField]
	private Transform rightSpawn;
	[SerializeField]
	private Transform leftSpawn;
	[SerializeField]
	private float cannonSpawnRate;
	[SerializeField]
	private PortHole[] leftPorts;
	[SerializeField]
	private PortHole[] rightPorts;
}
