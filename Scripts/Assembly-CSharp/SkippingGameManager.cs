using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SkippingGameManager : PartyGame
{
	[SerializeField]
	private float gameOverTime;
	[SerializeField]
	private float respawnTime;
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
	public SkippingSweeper SkippingSweeper;
	public uint sheepRemaining;
	public List<SweeperPlatform> SweeperPlatformsSetOne;
	public float SetOneFallsInXSecs;
	public List<SweeperPlatform> SweeperPlatformsSetTwo;
	public float SetTwoFallsInXSecs;
	public GameObject SheepEliminatedFx;
	public GameObject PlatformBreakingFX;
}
