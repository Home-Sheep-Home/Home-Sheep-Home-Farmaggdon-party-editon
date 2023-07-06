using UnityEngine;
using UnityEngine.UI;

public class VolleyballGameManager : PartyGame
{
	public int scoreToWin;
	[SerializeField]
	private Volleyball ball;
	[SerializeField]
	private GameObject ballIndicator;
	[SerializeField]
	private Transform redSpawn;
	[SerializeField]
	private Transform blueSpawn;
	[SerializeField]
	private VolleyballFloor[] redFloors;
	[SerializeField]
	private VolleyballFloor[] blueFloors;
	[SerializeField]
	private Text redScoreText;
	[SerializeField]
	private Text blueScoreText;
	[SerializeField]
	private Image scoreBoardImage;
	[SerializeField]
	private Text redCountdownText;
	[SerializeField]
	private Text blueCountdownText;
	[SerializeField]
	private float respawnTime;
	[SerializeField]
	private float startTime;
	[SerializeField]
	private float gameOverTime;
	public bool gameOver;
}
