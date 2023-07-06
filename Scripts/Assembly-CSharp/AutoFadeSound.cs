using UnityEngine;

public class AutoFadeSound : MonoBehaviour
{
	[SerializeField]
	private string audioString;
	[SerializeField]
	private GameObject[] listeners;
	[SerializeField]
	private float maxDistance;
	[SerializeField]
	private float maxVolume;
	[SerializeField]
	private float initialDelay;
	[SerializeField]
	private bool persistent;
}
