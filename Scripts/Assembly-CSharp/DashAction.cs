using UnityEngine;

public class DashAction : MonoBehaviour
{
	public enum DashMode
	{
		TravelDirection = 0,
		FacingDirection = 1,
	}

	public PowerupEffect DashEffect;
	public DashMode dashMode;
	public float DashPower;
	public float DashCooldown;
}
