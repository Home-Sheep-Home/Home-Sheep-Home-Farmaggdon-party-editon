using UnityEngine;

public class Indicator : MonoBehaviour
{
	public GameObject objectToTrack;
	public GameObject indicatorSprite;
	[SerializeField]
	private bool isPlayer;
	[SerializeField]
	private MultiPlayerManager.Team teamColour;
}
