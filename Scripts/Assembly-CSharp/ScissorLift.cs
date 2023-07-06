using UnityEngine;

public class ScissorLift : LevelObject
{
	public enum LiftState
	{
		idle = 0,
		checking = 1,
		fail = 2,
		up = 3,
		down = 4,
	}

	public LiftState state;
	public Animator scannerAnimator;
	public LevelObject touchingThisFrame;
	public LevelObject shirleyBox;
	public LevelObject shaunBox;
	public LevelObject timmyBox;
	public float frameTime;
}
