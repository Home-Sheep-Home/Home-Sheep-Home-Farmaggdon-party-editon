using UnityEngine;
using System.Collections.Generic;

public class LevelFactory : MonoBehaviour
{
	public bool levelComplete;
	public bool levelLoaded;
	public bool HSH1;
	public LoadingScreen loadingScreen;
	public int levelNumber;
	public LevelUI levelUI;
	public LevelBackground levelBackground;
	public HiddenRoom hiddenRoom;
	public LevelCanvas levelCanvas;
	public LevelParticles levelParticles;
	public SheepManager sheepManager;
	public GameObject hiddenRoomObject;
	public GameObject levelCanvasObject;
	public GameObject levelObjects;
	public GameObject levelHints;
	public Level LevelScript;
	public List<LevelObject> objectList;
	public bool restartAllowed;
	public GoalData goalData;
	public TriggerVolume goal;
	public TriggerVolume sheepLock;
	public TriggerVolume sheepUnlock;
	public TriggerVolume triggerBreakage;
	public LevelObject[] planks;
	public LevelObject windsock;
}
