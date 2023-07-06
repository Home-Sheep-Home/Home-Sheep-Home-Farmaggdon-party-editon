using UnityEngine;

public class SkippingSweeper : MonoBehaviour
{
	public enum MotorDirection
	{
		Clockwise = 0,
		AntiClockwise = 1,
	}

	public MotorDirection motorDirection;
	public float StartingVecolicty;
	public float MaximumVelocity;
	public float VelocityIncreaseEverySwing;
}
