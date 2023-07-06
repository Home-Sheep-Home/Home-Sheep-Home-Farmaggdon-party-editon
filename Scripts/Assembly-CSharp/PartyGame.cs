using UnityEngine;
using UnityEngine.UI;

public class PartyGame : MonoBehaviour
{
	[SerializeField]
	protected Text teamText;
	[SerializeField]
	protected Text winText;
	[SerializeField]
	protected bool isGame;
	[SerializeField]
	protected bool teamGame;
	[SerializeField]
	protected bool roundBasedGame;
	[SerializeField]
	protected Transform[] startingPositions;
	[SerializeField]
	protected bool useTimer;
	[SerializeField]
	protected int minutes;
	[SerializeField]
	protected float seconds;
	[SerializeField]
	protected int score_1st;
	[SerializeField]
	protected int score_2nd;
	[SerializeField]
	protected int score_3rd;
	[SerializeField]
	protected int score_4th;
	[SerializeField]
	protected ConfettiParctles confettiPrefab;
}
