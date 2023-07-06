using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : AppScreen
{
	public GameObject starRatingBoxRoot;
	public Image[] starImages;
	public Text timeForNextStarText;
	[SerializeField]
	private Text levelTitle;
	[SerializeField]
	private Text levelTip;
	[SerializeField]
	private GameObject startButton;
}
