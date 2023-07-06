using UnityEngine;
using UnityEngine.UI;

public class StoryLevelSelectPanel : MonoBehaviour
{
	public Text levelTitleText;
	public Image panelTopImage;
	public Image panelBottomImage;
	public Color panelLevelCompletedColour;
	public Color panelLevelUnlockedColour;
	public Image previewImage;
	public Image[] starImages;
	public Image starOutline;
	public Sprite starOffSprite;
	public Sprite starOnSprite;
	public Image[] collectableImages;
	public Sprite collectableUnfoundSprite;
	public Sprite collectableFoundSockSprite;
	public Sprite collectableFoundCupcakeSprite;
	public Sprite collectableFoundJoystickSprite;
	public Text bestTimeTitleText;
	public Text bestTimeText;
	public Transform levelUnlockedRoot;
	public Transform levelLockedRoot;
	public Text lockedLevelTitleText;
}
