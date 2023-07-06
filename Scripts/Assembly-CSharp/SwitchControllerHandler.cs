using UnityEngine;

public class SwitchControllerHandler : MonoBehaviour
{
	public enum SwitchMode
	{
		Handheld = 0,
		Tabletop = 1,
		TV = 2,
	}

	public SwitchMode currentMode;
}
