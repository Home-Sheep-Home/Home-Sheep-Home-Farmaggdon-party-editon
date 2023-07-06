using UnityEngine;
using UnityEngine.UI;

public class HurdlesGameManager : PartyGame
{
	[SerializeField]
	private RepeatingBackground floor;
	[SerializeField]
	private RepeatingBackground movingBackground;
	[SerializeField]
	private Rigidbody2D boulder;
	[SerializeField]
	private HurdleFailureBoundary failureBoundary;
	[SerializeField]
	private PartyModePowerUpManager powerupSpawner;
	[SerializeField]
	private HurdleSpawner HurdleSpawner;
	[SerializeField]
	private float gameOverTime;
	[SerializeField]
	private float respawnTime;
	[SerializeField]
	private float minSpeed;
	[SerializeField]
	private float maxSpeed;
	[SerializeField]
	private int rounds;
	[SerializeField]
	private Text redScoreText;
	[SerializeField]
	private Text blueScoreText;
	[SerializeField]
	private Text yellowScoreText;
	[SerializeField]
	private Text greenScoreText;
	public GameObject SheepEliminatedFX;
}
