using UnityEngine;

public class TractorBeam : LevelObject
{
	public GameObject[] levelObjects;
	public Transform tractorBeamTransform;
	public Transform shipTransform;
	public Animator beam;
	public float duration;
	public float offset;
	public float delay;
}
