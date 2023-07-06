using UnityEngine;

public class MPPIDCarousel : MonoBehaviour
{
	public float proportionalGain;
	public float integralGain;
	public float derivativeGain;
	public Transform anchor;
	public Camera parentCamera;
	public RectTransform touchArea;
	public GameObject[] entries;
	public float entryDirectionAngle;
	public float entrySeparationDistance;
	public int selectedIndex;
	public bool disableOffscreenEntries;
	public bool wrapEntries;
	public float wrappingPointValue;
	public float maxVelocity;
	public float swipeVelocityMultiplier;
	public float updateEntryDistance;
	public float clampDistance;
	public bool inputEnabled;
}
