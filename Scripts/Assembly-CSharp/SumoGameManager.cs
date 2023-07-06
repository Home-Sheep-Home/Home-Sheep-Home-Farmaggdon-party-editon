using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SumoGameManager : PartyGame
{
	[SerializeField]
	private bool seesawVariant;
	[SerializeField]
	private GameObject seesaw;
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
	private SumoFailureBoundary failureBoundary;
	[SerializeField]
	private PartyModePowerUpManager powerupSpawner;
	[SerializeField]
	private float HazardWarningTime;
	[SerializeField]
	private List<DangerIndicator> DangerIndicators;
	[SerializeField]
	private List<Transform> explosiveSpawns;
	[SerializeField]
	private ContactExplosive contactExplosive;
	[SerializeField]
	private GameObject cratePrefab;
	[SerializeField]
	private List<SumoPlatform> SumoPlatforms;
}
