using UnityEngine.UI;
using UnityEngine;

public class RankingScene : PartyGame
{
	public enum RankSceneStates
	{
		Start = 0,
		ShowLula = 1,
		AnimateInPizza = 2,
		SplitPizza = 3,
		DeliverPizza = 4,
		ReorderPlayers = 5,
	}

	public RankSceneStates currentState;
	public Text CountdownText;
	public ScoreRanking[] scoreRankings;
	public RankingPizzaController pizzaController;
	public float waitTime;
	public HorizontalLayoutGroup scoreRankingsLayoutGroup;
	public Animator lulaAnimator;
	public Animator pizzaAppearAnimator;
	public Image[] playerHatImages;
	public int playerCount;
}
