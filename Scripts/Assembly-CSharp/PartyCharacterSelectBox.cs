using UnityEngine;
using UnityEngine.UI;

public class PartyCharacterSelectBox : MonoBehaviour
{
	public enum BoxState
	{
		NoPlayer = 0,
		HatSelect = 1,
		SheepLockedIn = 2,
	}

	public Menu_PartyPlayerSelectScreen partyPlayerSelectScreen;
	public BoxState boxState;
	public int boxIndex;
	public int controllerIndex;
	public int currentHatIndex;
	public Image sheepImage;
	public Image hatImage;
	public Button leftNavButton;
	public Button rightNavButton;
	public Image characterMarkerImage;
	public Image characterMarkerTabImage;
	public GameObject noPlayerLayoutGO;
	public Color characterMarkerLockedInColour;
	public Color characterMarkerDisabledColour;
	public Image inputTypeImage;
	public Sprite inputTypeControllerSprite;
	public Sprite inputTypeKeyboardWASDSprite;
	public Sprite inputTypeKeyboardArrowsSprite;
	public Image confirmCircleImage;
	public Image confirmButtonImage;
	public Sprite confirmButtonControllerSprite;
	public Sprite confirmButtonKeyboardWASDSprite;
	public Sprite confirmButtonKeyboardArrowsSprite;
	public Image cancelCircleImage;
	public Image cancelButtonImage;
	public Sprite cancelButtonControllerSprite;
	public Sprite cancelButtonKeyboardWASDSprite;
	public Sprite cancelButtonKeyboardArrowsSprite;
}
