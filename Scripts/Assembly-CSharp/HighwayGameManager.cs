using UnityEngine.UI;
using UnityEngine;

public class HighwayGameManager : PartyGame
{
	public int scoreToWin;
	[SerializeField]
	private Text redScoreText;
	[SerializeField]
	private Text blueScoreText;
	[SerializeField]
	private Text yellowScoreText;
	[SerializeField]
	private Text greenScoreText;
	[SerializeField]
	private Text countdownText;
	[SerializeField]
	private float respawnTime;
	[SerializeField]
	private float startTime;
	[SerializeField]
	private float gameOverTime;
	[SerializeField]
	private VehicleHandler vehicleHandler;
	[SerializeField]
	private HighwayFailureBoundary failureBoundary;
	[SerializeField]
	private PartyModePowerUpManager powerupSpawner;
	public Rigidbody2D[] windObjects;
	public Vector2 windForce;
	public DangerIndicator DangerIndicator;
	[SerializeField]
	private GantryCamera gantryCamera;
	[SerializeField]
	private GantryButton[] gantryButtons;
	public float gantrySpawnX;
	public float gantrySpeed;
	public GameObject SheepEliminatedFX;
}
