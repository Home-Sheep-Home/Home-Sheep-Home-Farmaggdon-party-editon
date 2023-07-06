using UnityEngine;

public class Player : MonoBehaviour
{
	public int playerId;
	public Sheep controlSheep;
	public Color playerColor;
	public Sprite playerNumberSprite;
	public Sprite partyHatSprite;
	public MultiPlayerManager.Team playerTeam;
	public PartyHatController.SheepHat selectedPartyHat;
}
