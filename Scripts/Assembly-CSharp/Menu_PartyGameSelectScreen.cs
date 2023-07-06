using UnityEngine.UI;

public class Menu_PartyGameSelectScreen : AppScreen
{
	public enum GameSelectState
	{
		FarmageddonSelect = 0,
		FarmageddonSetup = 1,
		FarmageddonCustomise = 2,
		SingleGameSelect = 3,
	}

	public GameSelectState currentState;
	public MPPIDSnapCarousel snapCarousel;
	public PartyGameSelectPanel farmageddonPanel;
	public Button[] partyGameButtons;
	public Text roundCountButtonText;
	public Image panelSelectedBorderImage;
	public Image gameSelectedBorderImage;
	public Image[] arrowImages;
}
