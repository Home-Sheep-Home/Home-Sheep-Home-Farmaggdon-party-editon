using UnityEngine;
using UnityEngine.UI;

public class Story_LevelCompletePopup : AppScreen
{
	public GameObject panel;
	public Image blackOverlay;
	public Text timeTakenText;
	public Text timeDifferenceText;
	public Text nextLevelButtonText;
	public Text trainingText;
	public Image[] starImages;
	public Image starOutline;
	public Sprite starFilledSprite;
	public Sprite starEmptySprite;
	public Image[] collectableImages;
	public Sprite emptyCollectableSprite;
	public Sprite cupcakeCollectableSprite;
	public Sprite sockCollectableSprite;
	public Sprite bonusCollectableSprite;
	public GameObject bonusUnlockedPopup;
	public Image bonusUnlockedBody;
	public Text bonusUnlockedText;
}
