using UnityEngine;

public class JumpingGameManager : PartyGame
{
	[SerializeField]
	private JumpFailureBoundary failureBoundary;
	[SerializeField]
	private float gameOverTime;
}
