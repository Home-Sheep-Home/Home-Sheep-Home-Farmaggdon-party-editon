using UnityEngine;

public class Sheep : LevelObject
{
	public enum SheepName
	{
		Shirley = 0,
		Shaun = 1,
		Timmy = 2,
	}

	public SheepName identity;
	public SheepAnimation sheepAnimation;
	public GameObject topShape;
	public GameObject leftShape;
	public GameObject rightShape;
	public GameObject bottomShape;
	public GameObject highlight;
	public SpriteRenderer playerNumberSprite;
	public GameObject parachute;
	public GameObject zap;
	public GameObject smoke;
	public SpriteRenderer helmet;
	public GameObject sleepingZeds;
	public ParticleSystem smokeParticles;
	public ParticleSystem drippingParticles;
	public ParticleSystem bubbleParticles;
	public bool disableStuckJump;
	public bool invertControls;
	public bool useTint;
	public string startingAnimDirection;
	public float impulseJump;
	public float impulseJumpWater;
	public float impulseWalk;
	public float impulseAir;
	public float wallJumpSpeed;
	public float maxWalk;
	public float maxAir;
	public int bubbleDelay;
	public bool spaceSheep;
	public bool alwaysRunning;
	public string animDirection;
	public bool animHitL;
	public bool animHitR;
	public bool animHitT;
	public bool animPrevHitL;
	public bool animPrevHitR;
	public bool animPrevHitT;
	public bool electrocuted;
	public bool electricOverride;
	public bool selected;
	public bool PlayerControlled;
	public string id;
	public int jumpDelay;
	public bool wasInWater;
	public LevelObject standingOn;
	public float speedCompensation;
	public bool locked;
	public bool touchingOneWay;
	public LevelObject stoodUnder;
	public string walkType;
	public bool touchingField;
	public bool inDanger;
	public bool inBeam;
	public bool inBox;
	public bool touchingHat;
	public int wallJumpDir;
	public bool airborne;
	public bool hasParachute;
	public bool parachuteDeployed;
	public bool onRoad;
	public float tint;
}
