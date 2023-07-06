using UnityEngine;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
	public LevelBackground levelBackground;
	public HiddenRoom hiddenRoom;
	public LevelCanvas levelCanvas;
	public LevelParticles levelParticles;
	public SheepManager sheepManager;
	public Hints hints;
	public bool shakeLevel;
	public bool scaffoldLevel;
	public List<LevelObject> objectList;
	public bool restartAllowed;
	public GoalData goalData;
	public TriggerVolume goal;
	public TriggerVolume sheepLock;
	public bool changeSheepOnLock;
	public TriggerVolume sheepUnlock;
	public TriggerVolume triggerBreakage;
	public TriggerVolume triggerFalling;
	public LevelObject[] planks;
	public Bucket bucket;
	public LevelObject windsock;
	public ScissorLift scissorLift;
	public TractorBeam aliens;
	public Farmer farmer;
	public GameObject sign;
}
