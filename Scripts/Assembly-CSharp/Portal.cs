using UnityEngine;

public class Portal : LevelObject
{
	public Portal otherPortal;
	public bool isCannon;
	public bool isWidePortal;
	public bool isInput;
	public float velocityFactor;
	public GameObject launchPointObject;
	public Collider2D portalTrigger;
}
