using UnityEngine;

public class MultiPlayerManager : MonoBehaviour
{
	public enum Team
	{
		Red = 0,
		Blue = 1,
		Yellow = 2,
		Green = 3,
		None = 4,
	}

	[SerializeField]
	private GameObject playerPrefab;
	[SerializeField]
	private GamemodeSelect gamemodeSelect;
	[SerializeField]
	private PartyUI partyUI;
	public Color32 redTeamColour;
	public Color32 blueTeamColour;
	public Color32 yellowTeamColour;
	public Color32 greenTeamColour;
	public Color32 redTeamTeamGameColour;
	public Color32 blueTeamTeamGameColour;
	public Sprite[] partyHatSprites;
	[SerializeField]
	private Sprite playerOneSprite;
	[SerializeField]
	private Sprite playerTwoSprite;
	[SerializeField]
	private Sprite playerThreeSprite;
	[SerializeField]
	private Sprite playerFourSprite;
	public int[] playerScores;
	public int[] playerScoresAwardedForLastGame;
	public int[] playerPartyGameScoresForLastGame;
}
