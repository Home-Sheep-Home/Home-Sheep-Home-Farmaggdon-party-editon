using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
	[SerializeField]
	private int minutes;
	[SerializeField]
	private float seconds;
	[SerializeField]
	private Text minuteText;
	[SerializeField]
	private Text secondsText;
	[SerializeField]
	private float secondsRemainingToStartWobble;
	[SerializeField]
	private float wobbleMoveAmountY;
	[SerializeField]
	private float wobbleMoveSpeedMax;
	[SerializeField]
	private float wobbleMoveSpeedMin;
	[SerializeField]
	private Vector2 offscreenPos;
}
