using UnityEngine.UI;
using UnityEngine;

public class Menu_StoryPlayerSelectScreen : AppScreen
{
	public enum SheepOption
	{
		None = 0,
		Shaun = 1,
		Shirley = 2,
		Timmy = 3,
	}

	public Image selectBoxesHighlightImage;
	public StoryCharacterSelectBox[] characterSelectBoxes;
	public Button continueButton;
	public Sprite continueButtonDisabledSprite;
	public Sprite continueButtonEnabledSprite;
}
