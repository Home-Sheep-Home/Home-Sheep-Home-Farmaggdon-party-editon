using UnityEngine;
using UnityEngine.UI;

public class CrusherGameManager : PartyGame
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
	public Crusher crusher;
	public uint sheepRemaining;
	public GameObject SheepEliminatedFX;
}
