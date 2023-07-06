using UnityEngine;

public class TrafficLights : MonoBehaviour
{
	public enum state
	{
		Red = 0,
		RedAmber = 1,
		Green = 2,
		Amber = 3,
	}

	public state currentState;
}
