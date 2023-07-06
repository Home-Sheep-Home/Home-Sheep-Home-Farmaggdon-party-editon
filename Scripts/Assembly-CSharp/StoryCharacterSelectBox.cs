using UnityEngine;
using UnityEngine.UI;

public class StoryCharacterSelectBox : MonoBehaviour
{
	public enum BoxState
	{
		NoPlayer = 0,
		SheepSelect = 1,
		SheepLockedIn = 2,
	}

	public Menu_StoryPlayerSelectScreen storyPlayerSelectScreen;
	public BoxState boxState;
	public Button leftNavButton;
	public Button rightNavButton;
	public Image sheepImage;
	public RuntimeAnimatorController shaunController;
	public RuntimeAnimatorController shirleyController;
	public RuntimeAnimatorController timmyController;
	public Menu_StoryPlayerSelectScreen.SheepOption selectedSheep;
	public int boxIndex;
	public int controllerIndex;
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
