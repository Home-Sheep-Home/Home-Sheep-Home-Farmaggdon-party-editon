using UnityEngine;

public class MPPIDSnapCarousel : MonoBehaviour
{
	public float proportionalGain;
	public float integralGain;
	public float derivativeGain;
	public Transform anchor;
	public Camera parentCamera;
	public RectTransform touchArea;
	public float[] snapPoints;
	public GameObject[] entries;
	public float entryDirectionAngle;
	public int selectedIndex;
	public float disableVelocity;
	public float disableDistance;
	public bool disableOffscreenEntries;
	public float wrappingPointValue;
	public float maxVelocity;
	public float swipeVelocityMultiplier;
	public float updateEntryDistance;
	public float clampDistance;
	public bool inputEnabled;
}
