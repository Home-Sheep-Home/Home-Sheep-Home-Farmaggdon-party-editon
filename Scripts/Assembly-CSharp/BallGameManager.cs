using UnityEngine;
using UnityEngine.UI;

public class BallGameManager : PartyGame
{
	public int scoreToWin;
	[SerializeField]
	private Football ball;
	[SerializeField]
	private GameObject ballIndicator;
	[SerializeField]
	private FootballGoal redGoal;
	[SerializeField]
	private FootballGoal blueGoal;
	[SerializeField]
	private Text redScoreText;
	[SerializeField]
	private Text blueScoreText;
	[SerializeField]
	private Image scoreBoardImage;
	[SerializeField]
	private float respawnTime;
	[SerializeField]
	private float startTime;
	[SerializeField]
	private float gameOverTime;
	public GoalConfettiManager GoalConfettiManager;
	public Transform redTeamConfettiPosition;
	public Transform blueTeamConfettiPosition;
}
