using UnityEngine;
using UnityEngine.UI;

public class Party_RoundEndScoreDisplay : MonoBehaviour
{
	public CanvasGroup canvasGroup;
	public GameObject[] playerDisplays;
	public Image[] playerHatImages;
	public RectTransform[] playerScoreEffectRectTransforms;
	public CanvasGroup[] playerScoreEffectCanvasGroups;
	public Text[] playerScoreTexts;
}
