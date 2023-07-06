using UnityEngine;

public class Powerup : MonoBehaviour
{
	public enum PowerupType
	{
		MegaJump = 0,
		SpeedBoost = 1,
		Grow = 2,
		Lightning = 3,
	}

	public PowerupType type;
	public float duration;
}
