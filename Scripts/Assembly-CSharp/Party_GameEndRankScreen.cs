using UnityEngine.UI;
using UnityEngine;

public class Party_GameEndRankScreen : AppScreen
{
	public GamemodeSelect gameModeSelect;
	public Button continueButton;
	public GameObject ffaLayoutHolder;
	public Party_GameEndPlayerPanel[] playerPanels;
	public GameObject teamLayoutHolder;
	public Party_GameEndPlayerPanel[] teamPlayerPanels;
	public Transform leftTeamPlayerHorizontalGroup;
	public Transform righTeamPlayerHorizontalGroup;
	public Text leftTeamWinStatusText;
	public Text leftTeamNameText;
	public Image leftTeamNameBackgroundImage;
	public Text rightTeamWinStatusText;
	public Text rightTeamNameText;
	public Image rightTeamNameBackgroundImage;
	public ConfettiParctles confettiPrefab;
}
