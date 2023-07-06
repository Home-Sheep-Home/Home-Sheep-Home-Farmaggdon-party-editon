using UnityEngine;
using System.Collections.Generic;

public class LevelObject : MonoBehaviour
{
	public Rigidbody2D body;
	public SpriteRenderer spriteRenderer;
	public PhysicsMaterial2D physicsMat;
	public bool active;
	public List<string> tags;
	public string contactNoise;
	public bool breakableOnShirley;
	public bool unstickOnSheep;
	public bool triggersWell;
	public bool onLift;
	public bool sheepField;
	public bool touchingPortal;
	public bool hasSpring;
	public bool springTouched;
	public bool oneWay;
	public float motorSpeed;
	public int portalCount;
	public bool portalling;
	public bool portalProof;
	public bool exploded;
	public bool inWater;
	public GameObject smokeSpawner;
	public float explosivePower;
	public float buoyancy;
	public bool isMagnetic;
	public List<GameObject> floatPoints;
	public Animator offsetAnimator;
	public int switchCount;
}
