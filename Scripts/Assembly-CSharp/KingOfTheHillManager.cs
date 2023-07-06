using UnityEngine;

public class KingOfTheHillManager : PartyGame
{
	public KingOfTheHillFailureBoundary failureBoundary;
	public KingOfTheHillHeightReferee HeightReferee;
	[SerializeField]
	private ObjectPool haybale_ObjectPool;
	[SerializeField]
	private ObjectPool explosive_ObjectPool;
	[SerializeField]
	private ObjectPool highMass_ObjectPool;
	public bool RandomlySkewBaleObjects;
	[SerializeField]
	private float hazardStartRate;
	[SerializeField]
	private float hazardEndRate;
	[SerializeField]
	private Transform[] rightSpawnLocations;
	[SerializeField]
	private Transform[] leftSpawnLocations;
	[SerializeField]
	private Transform[] boxSpawnLocations;
	[SerializeField]
	private DangerIndicator[] dangerIndicators;
	public float roundTime;
	public float hazardDelay;
	[SerializeField]
	private float gameOverTime;
	public PartyGameTeamWinsScreen PartyGameTeamWinsScreen;
	public PartyGameCountdownTimer PartyGameCountdownTimer;
}
