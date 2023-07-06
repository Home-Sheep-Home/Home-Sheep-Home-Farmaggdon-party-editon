using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	private int playerCount;
	[SerializeField]
	private bool multiplayer;
	[SerializeField]
	private bool partyGame;
	[SerializeField]
	private int levelToLoad;
	[SerializeField]
	private string levelStringToLoad;
	[SerializeField]
	private bool hsh1;
	[SerializeField]
	private string currentEpisode;
	public bool debug;
	public bool debugButtons;
	public string debugLevel;
}
